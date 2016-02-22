using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MovieSpider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProgressBar.CheckForIllegalCrossThreadCalls = false;
            Label.CheckForIllegalCrossThreadCalls = false;
            initTudou();
            initBaofeng();
            //tudou.RunWorkerCompleted += _RunWorkerCompleted;
            //tudou.ProgressChanged += _ProgressChanged;
        }



        Youku youku;
        Tudou tudou;
        int s, ed;

        StringBuilder YoukuResultSB = new StringBuilder();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            //string url = @"http://www.youku.com/v_olist/c_96_g__a_%E7%BE%8E%E5%9B%BD_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_1_p_1.html";
            youku = new Youku(textBox1.Text);
            youku.RunWorkerCompleted += youku_RunWorkerCompleted;
            youku.ProgressChanged += youku_ProgressChanged;
            youku.WC = new MyWebClient();

            if (int.TryParse(txt_PageNumber.Text, out s) && int.TryParse(txt_pageNumberEnd.Text, out ed))
            {

            }
            else
            {
                MessageBox.Show("页码不正确!");
                return;
            }
            tryDoYouku();
        }

        void tryDoYouku()
        {
            if (s > ed)
            {
                System.IO.File.WriteAllText("优酷" + txt_Tag.Text + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", YoukuResultSB.ToString());
                MessageBox.Show("完成");
                button1.Enabled = true;
                button1.BackColor = Color.LimeGreen;
                return;
            }
            else
            {
                youku.SetPageNumber(s++);
                if (!youku.IsBusy)
                {

                }
                youku.RunWorkerAsync();
            }
        }

        void youku_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lbl_youkuStatus.Text = e.UserState as string;
            this.pb_Youku.Value = e.ProgressPercentage;
        }

        void youku_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var haha = (e.Result as List<MovieDetail>);
            textBox2.Text = "";
            foreach (MovieDetail item in haha)
            {
                textBox2.AppendText(item.ToString() + "\r\n");
                YoukuResultSB.AppendLine(item.ToString());
            }

            tryDoYouku();
        }



        void initTudou()
        {
            tudou = new Tudou();
            cbType.Items.Clear();
            cbType.Items.AddRange(tudou.dicTypeURL.Keys.ToArray<string>());
        }

        int td_s = 1;//土豆的页码

        StringBuilder TudouResultSB = new StringBuilder();

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            tudou = new Tudou();
            tudou.WC = new MyWebClient();
            if (!tudou.SetType(cbType.SelectedItem.ToString()))
            {
                MessageBox.Show("需要选择类型");
                return;
            }

            tudou.RunWorkerCompleted += new RunWorkerCompletedEventHandler(tudou_RunWorkerCompleted);
            tudou.ProgressChanged += new ProgressChangedEventHandler(tudou_ProgressChanged);
            tryDoTudou();
        }

        private void tryDoTudou()
        {
            this.lbl_tudou_page.Text = "第" + td_s.ToString() + "页";
            tudou.SetPageNumber(td_s++);
            tudou.RunWorkerAsync();
        }

        void tudou_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.lbl_tuDouStatus.Text = (e.UserState as string);
            this.pb_Tudou.Value = e.ProgressPercentage;
        }

        void tudou_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                System.IO.File.WriteAllText("土豆-手动停止-" + cbType.SelectedItem.ToString() + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", TudouResultSB.ToString());
                button2.Enabled = true;
                button2.BackColor = Color.LimeGreen;
                return;
            }

            var haha = (e.Result as List<MovieDetail>);
            txt_ResultTudou.Text = string.Empty;
            foreach (MovieDetail item in haha)
            {
                txt_ResultTudou.AppendText(item.ToString() + "\r\n");
                TudouResultSB.AppendLine(item.ToString());
            }

            if (haha.Count != 0)
            {
                tryDoTudou();
            }
            else
            {
                System.IO.File.WriteAllText("土豆" + cbType.SelectedItem.ToString() + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", TudouResultSB.ToString());
                MessageBox.Show("tudou完成");
                button2.Enabled = true;
                button2.BackColor = Color.LimeGreen;
            }


        }

        private void btn_tudouCancle_Click(object sender, EventArgs e)
        {
            this.tudou.CancelAsync();
        }

        #region 暴风

        MyBackGroundWorker<MovieItem, MovieDetail> mgb = new MyBackGroundWorker<MovieItem, MovieDetail>(10);

        private void initBaofeng()
        {
            mgb.DoSingleWork += new DoWorkEventHandler(mgb_DoSingleWork);

            mgb.ProgressChanged += new ProgressChangedEventHandler(mgb_ProgressChanged);

            mgb.RunWorkCompleted += new RunWorkerCompletedEventHandler(mgb_RunWorkCompleted);

        }

        void mgb_RunWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var list = (e.Result as List<MovieDetail>);
            StringBuilder sb = new StringBuilder();

            foreach (MovieDetail item in list)
            {
                sb.AppendLine(item.ToString());

            }

            System.IO.File.WriteAllText("暴风" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt", sb.ToString());
            MessageBox.Show("完成");
        }

        void mgb_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var timePcent = sw.Elapsed.TotalSeconds / e.ProgressPercentage;
            var remainTimeSpan = TimeSpan.FromSeconds((int)(100 - e.ProgressPercentage) * timePcent);

            this.pb_Baofeng.Value = e.ProgressPercentage;
            this.lbl_Baofeng.Text = this.pb_Baofeng.Value.ToString() + "% 剩余" + remainTimeSpan.Minutes + "分" + remainTimeSpan.Seconds + "秒 "  + (e.UserState as MovieDetail).Title;
        }
        Regex reg = new Regex(@"\d\d\d\d");
        void mgb_DoSingleWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
            MyWebClient mmwc = new MyWebClient();
            string mhtml = mmwc.GetHTML(new Uri((e.Argument as MovieItem).DetailURL));
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(mhtml);
            
            var nodes = doc.DocumentNode.SelectNodes("//div[@class='play-detail-text-area clearfix']");
            string title, lo, tp, direc, actors;
            try
            {
                title = doc.DocumentNode.SelectSingleNode("//div[@class='play-detail-text clearfix']/h2").InnerText;
            }
            catch (Exception)
            {

                title = "";
            }
            try
            {
                lo = nodes[0].SelectNodes("p[@class='play-detail-area-l']")[0].InnerText;
            }
            catch (Exception)
            {

                lo = "";
            }
            try
            {
                tp = nodes[0].SelectNodes("p[@class='play-detail-area-r']")[0].InnerText;
            }
            catch (Exception)
            {

                tp = "";
            }

            try
            {
                direc = nodes[1].SelectNodes("p[@class='play-detail-area-l']")[0].InnerText;
            }
            catch (Exception )
            {
                direc = "";
            }
            try
            {
                actors = nodes[1].SelectNodes("p[@class='play-detail-area-r']")[0].InnerText;
            }
            catch (Exception)
            {
                actors = "";
            }
            

            MovieDetail md = new MovieDetail();
            md.Location = lo.Replace("地区：", "");
            if (reg.IsMatch(md.Location))
            {
                md.YearAbout = reg.Match(md.Location).ToString();
                md.Location = reg.Replace(md.Location, "").Trim();
            }
            else
            {
                md.YearAbout = "";
            }
            
            md.MType = tp.Replace("类型：", "");
            md.Title = title;
            md.Director = direc.Replace("导演：","");
            md.MainActor = actors.Replace("主演：", "");
            md.CoverFile = "";
            md.DetailURL = (e.Argument as MovieItem).DetailURL;
            md.Tag = "";
            md.TotalPlayed = "0";
            md.UpdateInfo = "";
            md.YoukuPublishDate = "";
            e.Result = md;
        }

        private string baofengURL = "http://www.baofeng.com/tv/667/list-type-2-areaid-38-ishot-2-sid-1-p-###.shtml";
        private string baofengCurrentURL = string.Empty;

        private void SetPageNumber(int p)
        {
            this.baofengCurrentURL = baofengURL.Replace("###", p.ToString());
        }


        List<MovieItem> currentItemList = new List<MovieItem>();
        private void btn_Baofeng_Click(object sender, EventArgs e)
        {
            List<MovieItem> list = new List<MovieItem>();
            //page repeat
            for (int i = 1; i < 2; i++)
            {
                list.Clear();
                SetPageNumber(i);
                MyWebClient mwc = new MyWebClient();
                var html = mwc.GetHTML(new Uri(baofengCurrentURL));
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var nodes = doc.DocumentNode.SelectNodes("//ul[@class='sort-list-r-poster clearfix']/li");

                for (int j = 0; j < nodes.Count; j++)
                {
                    MovieItem m = new MovieItem();
                    var link = nodes[j].ChildNodes[1].ChildNodes[1].ChildNodes[1].Attributes["href"].Value;
                    var titl = nodes[j].ChildNodes[1].ChildNodes[1].ChildNodes[1].Attributes["title"].Value;
                    m.DetailURL = "http://baofeng.com/" + link;
                    m.Title = titl;
                    list.Add(m);
                }
                currentItemList.AddRange(list);
                this.txt_baoFengResult.Text = i.ToString();
            }
        }

        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

        private void btn_BaofengGOGOGOG_Click(object sender, EventArgs e)
        {
            sw.Start();
            mgb.Inputs = currentItemList;
            mgb.RunWorkerAsync();
        }
        #endregion





    }
}
