using BITCOIN_SIMULATOR_TAB_.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BITCOIN_SIMULATOR_TAB_.ViewModel
{
    class UpbitAPI
    {
        static string BASE_URL = "https://api.upbit.com/v1/candles/days?market={0}&to=2021-05-{1}%2009%3A00%3A00&count=1&convertingPriceUnit=KRW";

        public static UpbitData GetUpbitData(string coinName, string date)
        {
            UpbitData result = new UpbitData();

            string url = string.Format(BASE_URL, coinName, date);

            HttpClient client = new HttpClient();
            var response = client.GetAsync(url);
            string resultString = response.Result.Content.ReadAsStringAsync().Result;
            client.Dispose();
            resultString = resultString.Replace("[", "");
            resultString = resultString.Replace("]", "");

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            result = JsonConvert.DeserializeObject<UpbitData>(resultString, settings);

            return result;
        }
    }
}
