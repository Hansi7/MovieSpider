using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Json;

namespace MovieSpider
{
    public class Tudou : System.ComponentModel.BackgroundWorker, ISiteGetable
    {
        WebClient wc = new MyWebClient();
        public System.Net.WebClient WC
        {
            get
            {
                return this.wc;
            }
            set
            {
                this.wc = value;
            }
        }
        public readonly Dictionary<string, string> dicTypeURL = new Dictionary<string, string>();
        public Tudou()
        {
            dicTypeURL.Add("香港电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=78&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            dicTypeURL.Add("香港电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=43&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("韩国电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=79&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            dicTypeURL.Add("韩国电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=46&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("美国电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=80&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            dicTypeURL.Add("美国电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=44&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("法国电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=81&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            dicTypeURL.Add("法国电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=49&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            
            dicTypeURL.Add("意大利电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=82&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("英国电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=83&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            dicTypeURL.Add("英国电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=50&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("台湾电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=84&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            dicTypeURL.Add("台湾电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=45&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("泰国电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=85&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            dicTypeURL.Add("泰国电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=47&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
                                          //http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=47&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality
            //dicTypeURL.Add("新加坡电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=48&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            
            dicTypeURL.Add("新加坡电视剧", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=48&tagType=3&firstTagId=3&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");
            
            dicTypeURL.Add("加拿大电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=86&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("德国电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=87&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("俄罗斯电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=89&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("日本电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=88&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");

            dicTypeURL.Add("印度电影", "http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=90&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=quality");


            this.WorkerSupportsCancellation = true;
        }


        string _typeA = "";
        string _currentPage = "";
        public bool SetType(string typeA)
        {
            if (dicTypeURL.ContainsKey(typeA))
            {
                this._typeA = typeA;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SetPageNumber(int page)
        {
            if (dicTypeURL.ContainsKey(_typeA))
            {
                this._currentPage = dicTypeURL[_typeA].Replace("###", page.ToString());
                return this._currentPage;
            }
            else
            {
                throw new ArgumentException("参数错误");
            }
        }

        public List<MovieItem> GetMovie()
        {

            //http://www.tudou.com/s3portal/service/pianku/data.action?pageSize=90&app=mainsitepc&deviceType=1&tags=77&tagType=3&firstTagId=5&areaCode=530100&initials=&hotSingerId=&pageNo=###&sortDesc=pubTime

            //var ssss = System.IO.File.ReadAllText("json.txt");
            //var ddd = Json.JsonParser.Deserialize(ssss);

            List<MovieItem> listMovieItem = new List<MovieItem>();
            var jsonString =  (this.wc as MyWebClient).GetHTML(new Uri(this._currentPage));

            var jsonInstance = JsonParser.Deserialize(jsonString);

            CurrentTypeCount = (int)(jsonInstance.total);
            //Console.WriteLine(jsonInstance.total);
            //Console.WriteLine(ddd.items);
            //Console.WriteLine(ddd.items[0].item[1].Value);
            
            for (int i = 0; i < jsonInstance.items.Count; i++)
			{
                MovieItem mi = new MovieItem();

                mi.Title =  jsonInstance.items[i]["title"];//电影名称

                mi.DetailURL = jsonInstance.items[i]["playUrl"];

                mi.Tag = jsonInstance.items[i]["playtimes"];
                try
                {
                    mi.UpdateInfo = jsonInstance.items[i]["updateInfo"];
                }
                catch (Exception)
                {
                    mi.UpdateInfo = "";
                }
                
                //mi.MainActor = jsonInstance.items[i]["actors"];//可能为列表

                for (int j = 0; j < jsonInstance.items[i]["actors"].Count; j++)
                {
                    mi.MainActor += " " + jsonInstance.items[i]["actors"][j]["name"];
                }
                
                mi.CoverFile = jsonInstance.items[i]["picUrl_448x672"];
                listMovieItem.Add(mi);
			}
            
            
           //Console.WriteLine((new System.Collections.Generic.KeyValuePair<string, object>(ddd.items[1]).Items[0].Value));
           return listMovieItem;
        }

        public int CurrentTypeCount
        {
            get;
            set;
        }


        public List<MovieDetail> GetDetail(List<MovieItem> listMovie)
        {
            throw new NotImplementedException();
        }
        List<MovieDetail> listResult;
        protected override void OnDoWork(System.ComponentModel.DoWorkEventArgs e)
        {
            this.WorkerReportsProgress = true;
            var listMI = GetMovie();

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            listResult = new List<MovieDetail>();

            var total = (double)listMI.Count;

            int n = 1;

            foreach (MovieItem item in listMI)
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
                    md.Title = item.Title;

                    //md.Title = doc.DocumentNode.SelectNodes("//h1[@class='kw']")[0].InnerText.Trim();
                }
                catch (Exception)
                {
                    md.Title = item.Title;
                }
                try
                {
                    md.MainActor = item.MainActor;
                }
                catch (Exception)
                {
                    md.MainActor = item.MainActor;
                }
                try
                {
                    int pCount = doc.DocumentNode.SelectNodes("//div[@class='txt']/p").Count;
                    int localP = 0;

                    for (int jj = 1; jj < pCount+1; jj++)
                    {
                        md.Location = doc.DocumentNode.SelectNodes("//div[@class='txt']/p[" + jj.ToString() + "]")[0].InnerText;
                        if (md.Location.IndexOf("地区")!=-1)
                        {
                            localP = jj;
                            break;
                        }
                    }

                    md.Location = doc.DocumentNode.SelectNodes("//div[@class='txt']/p[" + localP + "]")[0].InnerText.Replace("地区：", "").Replace("\r\t", "").Trim();

                }
                catch (Exception)
                {
                    md.Location = "";
                }
                try
                {
                    md.MType = doc.DocumentNode.SelectNodes("//p[@class='v_tags']")[0].InnerText.Replace("类型：", "").Replace("\r\n", "").Replace("\t", "").Trim();
                }
                catch (Exception)
                {
                    md.MType = "";
                }
                try
                {
                    int pCount = doc.DocumentNode.SelectNodes("//div[@class='txt']/p").Count;

                    //if (pCount == 7)
                    //{
                    //    md.YearAbout = doc.DocumentNode.SelectNodes("//div[@id='panelAlbumDetail']/div[3]/p[5]")[0].InnerText.Replace("年代：", "").Replace("\r\n", "").Trim();
                    //}
                    //else if (pCount == 6)
                    //{
                    //    md.YearAbout = doc.DocumentNode.SelectNodes("//div[@id='panelAlbumDetail']/div[3]/p[4]")[0].InnerText.Replace("年代：", "").Replace("\r\n", "").Trim();
                    //}

                    int yearP=0;
                    for (int ii = 1; ii < pCount+1; ii++)
                    {
                        md.YearAbout = doc.DocumentNode.SelectNodes("//div[@id='panelAlbumDetail']/div[3]/p[" + ii.ToString()+ "]")[0].InnerText;

                        if (md.YearAbout.IndexOf("年代：")!=-1)
                        {
                            yearP = ii;
                            break;
                        }
                    }
                    md.YearAbout = doc.DocumentNode.SelectNodes("//div[@id='panelAlbumDetail']/div[3]/p[" + yearP.ToString() +"]")[0].InnerText.Replace("年代：", "").Replace("\r\n", "").Trim();

                    //else if (pCount==5)
                    //{
                        //md.YearAbout = doc.DocumentNode.SelectNodes("//div[@id='panelAlbumDetail']/div[3]/p[3]")[0].InnerText.Replace("年代：", "").Replace("\r\n", "").Trim();
                    //}

                }
                catch (Exception)
                {
                    md.YearAbout = "";
                }
                try
                {
                    //int cc = doc.DocumentNode.SelectNodes("//span[@class='pub']").Count;
                    //if (cc == 2)
                    //{
                    //    md.YoukuPublishDate = "";
                    //}
                    //if (cc == 3)
                    //{
                    //    md.YoukuPublishDate = doc.DocumentNode.SelectNodes("//span[@class='pub']")[2].InnerText.Replace("上映:", "").Replace("\t", "").Trim();
                    //}
                    md.YoukuPublishDate = "";
                }
                catch (Exception)
                {
                    md.YoukuPublishDate = "";
                }

                try
                {
                    md.Director = doc.DocumentNode.SelectNodes("//div[@id='panelAlbumDetail']/div[3]/p[1]")[0].InnerText.Replace("导演：", "").Replace("\r\n", " ").Replace("\t", "").Trim();
                }
                catch (Exception)
                {
                    md.Director = "";
                }
                try
                {
                    md.CoverFile = item.CoverFile;
                }
                catch (Exception)
                {
                    md.CoverFile = "";
                }

                try
                {
                    //http://www.tudou.com/crp/itemSum.action?jsoncallback=page_play_model_itemSumModel__find&app=3&showArea=true&iabcdefg=130442880&uabcdefg=0&juabcdefg=01984snkkf2rrk
                    md.TotalPlayed = item.Tag.ToString();
                }
                catch (Exception)
                {

                    md.TotalPlayed = "";
                }

                try
                {
                    md.UpdateInfo = item.UpdateInfo;
                }
                catch (Exception)
                {
                    md.UpdateInfo = item.UpdateInfo;
                }

                listResult.Add(md);
                //调试运行。正常运行请注释掉
                //break;
            }



            e.Result = listResult;


        }

    }
}
