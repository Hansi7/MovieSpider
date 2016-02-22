using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieSpider;

namespace UnitTestMovieSpider
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string url = "http://www.youku.com/v_olist/c_96_g__a_%E7%BE%8E%E5%9B%BD_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_1_p_1.html";
            Youku youku = new Youku(url);

            youku.SetCurrentPageNumber(2);

            Assert.AreEqual(youku.CurrentPageURL.ToString(), "http://www.youku.com/v_olist/c_96_g__a_%E7%BE%8E%E5%9B%BD_sg__mt__lg__q__s_1_r_0_u_0_pt_0_av_0_ag_0_sg__pr__h__d_1_p_2.html");

        }
    }
}
