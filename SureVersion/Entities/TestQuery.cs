using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SureVersion.Entities
{
    public class TestQuery
    {
        public TestQuery() { }

        public TestQuery(string pName, string pUrl, string pMethod, string pEnverioment, string pIsVersion, string pExecuteResult = "N/A")
        {
            Name = pName;
            Url = pUrl;
            Method = pMethod;
            ExecuteResult = pExecuteResult;
            Enverioment = pEnverioment;
            IsVersion = pIsVersion;
        }

        public string Name { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }
        public string Enverioment { get; set; }
        public string ExecuteResult { get; set; }
        public HttpResult HttpResult { get; set; }
        public string IsVersion { get; set; }
        public bool _IsVersion
        {
            get
            {
                try
                {
                    string oIsVersion = IsVersion?.Trim().ToLower();

                    if (oIsVersion == "true")
                    {
                        return true;
                    }

                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public object[] ToArrayObject()
        {
            return new object[]
            {
                this.Name,
                this.Url,
                this.Method,
                this.Enverioment,
                this.ExecuteResult,
                this.IsVersion,
                this.HttpResult?.StatusCode.GetHashCode(),
                this.HttpResult?.StatusCode.ToString()
            };
        }

        public void ExecuteTest()
        {
            HttpResult Result = new HttpResult();
            HttpResponseMessage HttpResponse = null;
            using (HttpClient Client = new HttpClient())
            {
                try
                {
                    Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    switch (Method)
                    {
                        case "POST":
                            // HttpResponse = await client.PostAsJsonAsync(Url, Data);
                            break;
                        case "PUT":
                            // HttpResponse = await client.PutAsJsonAsync(Url, Data);
                            break;
                        case "DELETE":
                            // HttpResponse = await client.DeleteAsync(Url);
                            break;
                        case "GET":
                        default:
                            HttpResponse = Client.GetAsync(Url).Result;
                            break;
                    }

                    Result.StatusCode = HttpResponse.StatusCode;

                    if (_IsVersion)
                    {
                        Result.Content = HttpResponse.Content.ReadAsAsync<Settings>().Result;
                    }
                    else
                    {
                        Result.Content = HttpResponse.RequestMessage;
                    }
                }
                catch (Exception Ex)
                {
                    if (HttpResponse != null)
                        Result.StatusCode = HttpResponse.StatusCode;

                    Result.Content = Ex.Message;
                }

                this.HttpResult = Result;
            }
        }
    }
}