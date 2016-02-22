using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MovieSpider
{
    interface ISiteGetable
	{
        WebClient WC
        {
            get;
            set;
        }
    
        string SetPageNumber(int page);

        List<MovieItem> GetMovie();

        List<MovieDetail> GetDetail(List<MovieItem> listMovie);


	} 
}
