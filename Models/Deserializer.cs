using Newtonsoft.Json;
using System.Net;
using System.Reflection;

namespace WeatherApplication.Models
{
    public class Deserializer
    {
        public Root Deserialize(string city)
        {
            string url = $"https://api.weatherbit.io/v2.0/forecast/daily?city={city}&key=aadfe33b770e47258c4334deb8eb6a2b";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.UseDefaultCredentials = true;
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
            myDeserializedClass.imgName = new List<string>();

            ImageHelper(myDeserializedClass);

            return myDeserializedClass;
        }

        private void ImageHelper(Root myDeserializedClass)
        {
            for (int i = 0; i < myDeserializedClass.data.Count; i++)
            {
                switch (myDeserializedClass.data[i].weather.code)
                {
                    case 200:
                    case 201:
                    case 202:
                        myDeserializedClass.imgName.Add("img/png/t01d.png");
                        break;

                    case 230:
                    case 231:
                    case 232:
                    case 233:
                        myDeserializedClass.imgName.Add("img/png/t04d.png");
                        break;

                    case 300:
                    case 301:
                    case 302:
                        myDeserializedClass.imgName.Add("img/png/d01d.png");
                        break;

                    case 500:
                    case 501:
                    case 511:
                    case 520:
                    case 522:
                    case 900:
                        myDeserializedClass.imgName.Add("img/png/r01d.png");
                        break;

                    case 502:
                        myDeserializedClass.imgName.Add("img/png/r03d.png");
                        break;

                    case 521:
                        myDeserializedClass.imgName.Add("img/png/r05d.png");
                        break;

                    case 600:
                    case 610:
                    case 621:
                        myDeserializedClass.imgName.Add("img/png/s01d.png");
                        break;

                    case 601:
                    case 602:
                    case 622:
                    case 623:
                        myDeserializedClass.imgName.Add("img/png/s02d.png");
                        break;

                    case 611:
                    case 612:
                        myDeserializedClass.imgName.Add("img/png/s05d.png");
                        break;

                    case 700:
                    case 711:
                    case 721:
                    case 731:
                    case 741:
                    case 751:
                        myDeserializedClass.imgName.Add("img/png/a01d.png");
                        break;

                    case 800:
                        myDeserializedClass.imgName.Add("img/png/c01d.png");
                        break;

                    case 801:
                    case 802:
                        myDeserializedClass.imgName.Add("img/png/c02d.png");
                        break;

                    case 803:
                        myDeserializedClass.imgName.Add("img/png/c03d.png");
                        break;

                    case 804:
                        myDeserializedClass.imgName.Add("img/png/c04d.png");
                        break;
                }
            }
        }
    }
}
