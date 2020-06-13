using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using KanbaneManager.Shared.Entities;

namespace KanbaneManager.BlazorApp.Services
{
    public class CrudService<T> where T : class, IIdentifier
    {
        private HttpClient _client;
        private string _query;

        public CrudService(string query, string token)
        {
            _query = query;
            _client = new HttpClient
            {
                BaseAddress = new Uri(Program.URL)
            };
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        //GET all
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _client.GetFromJsonAsync<IEnumerable<T>>(_query);
        }

        //GET by id
        public async Task<T> GetById(string id)
        {
            return await _client.GetFromJsonAsync<T>(_query + $"/{id}");
        }

        //DELETE by id
        public async Task<bool> Remove(string id)
        {
            var outcome = await _client.DeleteAsync(_query + $"/{id}");
            return outcome.StatusCode == HttpStatusCode.OK;
        }

        //PUT by id
        public async Task<bool> Update(T obj)
        {
            var outcome = await _client.PutAsJsonAsync(_query + $"/{obj.Id}", obj);
            return outcome.StatusCode == HttpStatusCode.OK;
        }


        //POST
        public async Task<bool> Add(T obj)
        {
            var outcome = await _client.PostAsJsonAsync(_query, obj);
            return outcome.StatusCode == HttpStatusCode.OK;
        }
    }
}