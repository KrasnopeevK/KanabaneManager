using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace StressTest
{
    public class Requester
    {
        private HttpClient _client;
        private string URL;

        public Requester(string url)
        {
            URL = url;
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("authorization",
                "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiMiIsImh0dHA6Ly9zY2hlbWFzLm1pY3Jvc29mdC5jb20vd3MvMjAwOC8wNi9pZGVudGl0eS9jbGFpbXMvcm9sZSI6IkFkbWluIiwibmJmIjoxNTkyNDQxNTgzLCJleHAiOjE1OTcyNDE1ODMsImlzcyI6Ik1LV2ViQXBpIiwiYXVkIjoiQmxhem9yV0FTTUNsaWVudCJ9.aSRO9IaH4wiJ6pO11omX44fvdGFNo2L_vxYmjJQTLiA");
        }

        public async Task<(long, int)> StartTest()
        {
            var fails = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            
            var outcome = await _client.GetAsync(URL);
            if (outcome.StatusCode != HttpStatusCode.OK)
                fails += 1;
            
            sw.Stop();
            var executionTime = sw.ElapsedMilliseconds;
            return (executionTime, fails);
        }
    }
}