using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models.Interfaces
{
    interface IEngine
    {
        string getSearchUrl();

        List<SearchResult> getResultsFromHtml(object html);
    }
}
