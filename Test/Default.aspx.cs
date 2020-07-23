using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Test.Models;

namespace Test
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btnSearch_ClickAsync(object sender, EventArgs e)
        {
            string searchTerm = SearchText.Value;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                rptResultTable.DataSource = null;
                rptResultTable.DataBind();
                return;
            }

            List<ResultDisplayObject> resultList = new List<ResultDisplayObject>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8090/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpResponseMessage response = await client.GetAsync("api/search?word=" + searchTerm);
                if (response.IsSuccessStatusCode)
                {
                    resultList = await response.Content.ReadAsAsync<List<ResultDisplayObject>>();
                    rptResultTable.DataSource = resultList;
                    rptResultTable.DataBind();
                    
                }
                else
                {
                    ResultDisplayObject errorResult = new ResultDisplayObject() { Title = "ERROR", SearchEngine = "ERROR" };
                    resultList.Add(errorResult);
                    rptResultTable.DataSource = resultList;
                    rptResultTable.DataBind();
                    Console.WriteLine("Internal server Error");
                }
            }
        }
    }
}