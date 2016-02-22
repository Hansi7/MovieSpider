using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieSpider
{
    public class MovieDetail:MovieItem
    {
        private string _yearAbout;

        public string YearAbout
        {
            get { return _yearAbout; }
            set { _yearAbout = value; }
        }

        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private string _director;

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }

        private string _Mtype;

        public string MType
        {
            get { return _Mtype; }
            set { _Mtype = value; }
        }

        private string _totalPlayed;

        public string TotalPlayed
        {
            get { return _totalPlayed; }
            set { _totalPlayed = value; }
        }

        private string _youkuPublishDate;

        public string YoukuPublishDate
        {
            get { return _youkuPublishDate; }
            set { _youkuPublishDate = value; }
        }



        public override string ToString()
        {
            return this.Title + "\t" + this.Director + "\t" + this.DetailURL + "\t" + this.Location + "\t" + this.MainActor + "\t" + this.MType + "\t" + this.YearAbout + "\t" + this.YoukuPublishDate + "\t" + this.TotalPlayed + "\t" + this.Tag.ToString() +"\t" + this.UpdateInfo;
        }

    }
}
