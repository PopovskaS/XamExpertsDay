using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XamExpertsDay.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace XamExpertsDay.Services
{
    public class MockDataStore : IDataStore<Session>
    {
        public static HttpClient httpClient = new HttpClient()
        {
            BaseAddress = new Uri("https://sessionize.com/")
        };

        List<Session> ListOfSessions;

        public MockDataStore()
        {
            ListOfSessions = new List<Session>();
        }

        public async Task<bool> AddItemAsync(Session item)
        {
            ListOfSessions.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<Session> GetItemAsync(string id)
        {
            return await Task.FromResult(ListOfSessions.FirstOrDefault(s => s.id == id));
        }

        public async Task<IEnumerable<Session>> GetItemsAsync(bool forceRefresh = false)
        {
            Agenda agendaObj = null;
            try
            {
                var response = await httpClient.GetAsync("api/v2/9gjm92bz/view/Sessions");
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var result = response.Content.ReadAsStringAsync().Result;

                    agendaObj = JsonConvert.DeserializeObject<List<Agenda>>(result).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                //Log Event
            }

            //add null check on null elements
            return agendaObj?.sessions;
        }
    }
}