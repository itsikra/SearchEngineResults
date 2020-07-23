using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class SearchResult
    {
        public SearchResult(string resultStr, DateTime time)
        {
            this.resultStr = resultStr;
            this.time = time;
        }

        public String resultStr { get; set; }
        public DateTime time { get; set; }
    }
}