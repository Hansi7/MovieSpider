using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HtmlAgilityPack;
using System.Net;

namespace MovieSpider
{
    public class Youku : System.ComponentModel.BackgroundWorker, ISiteGetable
    {
        public string OURL = "";//原始的地址带###的。
        public Youku(string startpage)
        {
            this.OURL = startpage;
        }
        //http://www.youku.com/v_olist/c_96_g__a_%E9%9F%A9%E5%9B%BD_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_1_p_5.html
        public string CurrentPageURL = "";
        
        public string SetPageNumber(int page)
        {
            CurrentPageURL = OURL.Replace("###", page.ToString());
            return CurrentPageURL;
        }
        //int st, ed;
        //public void SetEndPageNumber(int st)
        //{
        //    this.st = st;
        //}

        //public void SetStartPageNumber(int ed)
        //{
        //    this.ed = ed;
        //}

        List<MovieItem> MovieList;

        public List<MovieItem> GetMovie()
        {
            try
            {
                var htmlstring = (this.wc as MyWebClient).GetHTML(new Uri(CurrentPageURL));

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(htmlstring);

                var list = new List<MovieItem>();

                var nodes = doc.DocumentNode.SelectNodes("//div[@class ='yk-col3']/div/div[4]");
                foreach (HtmlNode item in nodes)
                {
                    MovieItem m = new MovieItem();
                    m.Title = item.ChildNodes[1].ChildNodes[0].Attributes["title"].Value.Trim();
                    m.MainActor = item.ChildNodes[3].InnerText.Replace(" ", "").Replace("\r\n", "").Trim();
                    m.DetailURL = item.ChildNodes[1].ChildNodes[0].Attributes["href"].Value.Trim();
                    m.CoverFile = "";
                    list.Add(m);
                }
                this.MovieList = list;
                return list;
            }
            catch (Exception err)
            {
                throw err;
            }

        }

        System.Net.WebClient wc;

        public System.Net.WebClient WC
        {
            get
            {
                return wc;
            }
            set
            {
                this.wc = value;
            }
        }

        List<MovieDetail> listResult;

        protected override void OnDoWork(System.ComponentModel.DoWorkEventArgs e)
        {
            this.WorkerReportsProgress = true;

            var listMovieItem = GetMovie();

            HtmlAgilityPack.HtmlDocument doc = new HtmlDocument();
            listResult = new List<MovieDetail>();

            var total = (double)listMovieItem.Count;
            int n = 1;
            foreach (MovieItem item in listMovieItem)
            {
                if (this.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                try
                {
                    var o = (this.wc as MyWebClient).GetHTML(new Uri(item.DetailURL));
                    doc.LoadHtml(o);
                }
                catch (WebException err)
                {
                    continue;
                }

                n++;
                MovieDetail md = new MovieDetail();
                int percent = (int)((n / total) * 100);
                if (percent > 100)
                {
                    percent = 100;
                }
                ReportProgress(percent, "第" + n.ToString() + "个/共" + total + ":" + item.Title);
                md.DetailURL = item.DetailURL;
                md.Tag = item.Tag;

                try
                {
                    //md.Title = doc.DocumentNode.SelectNodes("//div[@id='title']")[0].InnerText.Replace(" ", "").Replace("电影:", "").Replace("\n", "").Replace("\t", "").Trim();
                    md.Title = item.Title;
                }
                catch (Exception)
                {
                    md.Title = item.Title;
                }
                try
                {
                    md.MainActor = doc.DocumentNode.SelectNodes("//span[@class='actor']")[0].InnerText.Replace("主演:", "").Replace("\t", "").Trim();
                }
                catch (Exception)
                {
                    md.MainActor = item.MainActor;
                }
                try
                {
                    md.Location = doc.DocumentNode.SelectNodes("//span[@class='area']")[0].InnerText.Replace("地区:", "").Replace("\t", "").Trim();
                }
                catch (Exception)
                {
                    md.Location = "";
                }
                try
                {
                    md.MType = doc.DocumentNode.SelectNodes("//span[@class='type']")[1].InnerText.Replace("类型:", "").Replace("\t", "").Trim();
                }
                catch (Exception)
                {
                    md.MType = "";
                }
                try
                {


                    md.YearAbout = doc.DocumentNode.SelectNodes("//span[@class='pub']")[1].InnerText.Replace("上映:", "").Replace("\t", "").Trim();

                }
                catch (Exception)
                {
                    md.YearAbout = "";
                }
                try
                {
                    int cc = doc.DocumentNode.SelectNodes("//span[@class='pub']").Count;
                    if (cc == 2)
                    {
                        md.YoukuPublishDate = "";
                    }
                    if (cc == 3)
                    {
                        md.YoukuPublishDate = doc.DocumentNode.SelectNodes("//span[@class='pub']")[2].InnerText.Replace("上映:", "").Replace("\t", "").Trim();
                    }
                }
                catch (Exception)
                {
                    md.YoukuPublishDate = "";
                }

                try
                {
                    md.Director = doc.DocumentNode.SelectNodes("//span[@class='director']")[0].InnerText.Replace("导演:", "").Replace("\t", "").Trim();
                }
                catch (Exception)
                {
                    md.Director = "";
                }
                try
                {
                    md.CoverFile = doc.DocumentNode.SelectNodes("//li[@class='thumb']")[0].FirstChild.Attributes["src"].Value.ToString().Trim();
                }
                catch (Exception)
                {
                    md.CoverFile = "";
                }

                try
                {
                    md.TotalPlayed = doc.DocumentNode.SelectNodes("//span[@class='play']")[0].InnerText.Replace("总播放:", "").Replace(" ", "").Trim();
                }
                catch (Exception)
                {

                    md.TotalPlayed = "";
                }
                try
                {
                   var tag = doc.DocumentNode.SelectNodes("//div[@class='basenotice']")[0].InnerText;
                   md.Tag = tag.Substring(0, tag.IndexOf("@")).Replace("\t", "").Replace("\n","").Trim();
                    
                }
                catch (Exception)
                {
                    md.Tag = "";
                }



                listResult.Add(md);
            }
            e.Result = listResult;
        }

        public List<MovieDetail> GetDetail(List<MovieItem> listMovie)
        {
            throw new NotImplementedException();
            //Implemeted in OnDoWork
        }
    }
}
