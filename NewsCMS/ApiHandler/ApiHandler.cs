using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace NewsCMS.ApiHandler
{
    public class ApiHandler: IApiHandler
    {
       
        public string GetAPI(string Url)
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(Url);
            httpRequest.Method = "GET";
            httpRequest.ContentType = "application/json";
            var response = (HttpWebResponse)httpRequest.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                //var model = JsonConvert.DeserializeObject<T>(result);
                response.Close();
                return result;
            }
        }

        public string PostWithModel(dynamic dynamicModel, string Url)
        {
            var httpRequest = (HttpWebRequest)WebRequest.Create(Url);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";
            string JsonData = JsonConvert.SerializeObject(dynamicModel);
            byte[] byteArray = Encoding.UTF8.GetBytes(JsonData);
            httpRequest.ContentLength = byteArray.Length;
            Stream dataStream = httpRequest.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            var response = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                //T model = JsonConvert.DeserializeObject<T>(result);
                response.Close();
                return result;
            }
        }
    }
}
