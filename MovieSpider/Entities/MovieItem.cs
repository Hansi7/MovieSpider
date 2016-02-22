using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieSpider
{
    public class MovieItem
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _mainActor;

        public string MainActor
        {
            get { return _mainActor; }
            set { _mainActor = value; }
        }

        private string _CoverFile;

        public string CoverFile
        {
            get { return _CoverFile; }
            set { _CoverFile = value; }
        }

        private object _tag;

        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        private string _detailURL;

        public string DetailURL
        {
            get { return _detailURL; }
            set { _detailURL = value; }
        }

        private string _updateinfo;

        public string UpdateInfo
        {
            get { return _updateinfo; }
            set { _updateinfo = value; }
        }

        public override string ToString()
        {
            return this.Title + "\t" + this.MainActor + "\t" + this.DetailURL + "\t" + this.CoverFile;
        }
    }

}
