using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public enum SearchEngine
    {
        Google = 0,
        Bing
    }
    public class ResultGroup
    {
        public ResultGroup(SearchEngine searchEngine, List<SearchResult> results)
        {
            this.searchEngine = searchEngine;
            this.results = results;
        }

        public SearchEngine searchEngine { get; set; }
        public List<SearchResult> results { get; set; }
    }
}