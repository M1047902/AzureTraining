using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Net.Http;
using System.Net.Http.Headers;
//using System.Net.Http.Formatting;

namespace BussinessLayer
{
    public class HotelRating : IHotelRating
    {
        private static string baseUrl = "";
        public List<Hotel> GetAllHotels()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56482");

            // Add an Accept header for JSON format.
            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);

            HttpResponseMessage response = client.GetAsync("api/Values/GetAllHotels").Result;
            string stringData = response.Content.ReadAsStringAsync().Result;
            List<Hotel> data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Hotel>>(stringData);
            if (response.IsSuccessStatusCode)
            {
                var hotels = response.Content.ReadAsAsync<IEnumerable<Hotel>>().Result;


                //forchange i made
                return hotels.ToList();
            }
            else
            {
                return null;

            }
        }

        public async Task GetHotels()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:55587/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/Department/1");
                if (response.IsSuccessStatusCode)
                {
                    // Hotel hotel = await response.Content.ReadAsAsync<IEnumerable<Hotel>();

                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }

        public List<MenuItem> GetAllMenu()
        {
            throw new NotImplementedException();
        }

        public List<string> GetCities()
        {
            throw new NotImplementedException();
        }
    }
}
