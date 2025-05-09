using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Lab10_task21.DataBase;

namespace Lab10_task21.DataBase
{
    public class HttpClientHandlerInsecure : HttpClientHandler
    {
        public HttpClientHandlerInsecure()
        {
            ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true;
        }
    }

    public class RestService
    {
        private readonly HttpClient _httpClient = new HttpClient(new HttpClientHandlerInsecure())
        {
            BaseAddress = new Uri("https://localhost:7119/"),
        };


        public async Task<List<Dish>> GetDishAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Dish>>("Dishes");
        }


        public async Task<Dish> GetDishAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Dish>($"Dishes/{id}");
        }


        public async Task<Dish> CreateDishAsync(Dish dish)
        {
            using (HttpResponseMessage response = await _httpClient.PostAsJsonAsync("Dishes", dish))
            {
                return await response.Content.ReadFromJsonAsync<Dish>();
            }
        }


        public async Task<Dish> UpdateDishAsync(Dish dish)
        {
            using (HttpResponseMessage response = await _httpClient.PutAsJsonAsync($"Dishes/{dish.Id}", dish))
            {
                return await response.Content.ReadFromJsonAsync<Dish>();
            }
        }


        public async Task DeleteStudentAsync(int id)
        {
            using (HttpResponseMessage response = await _httpClient.DeleteAsync($"Students/{id}"))
            {
                await response.Content.ReadFromJsonAsync<Dish>();
            }
        }
    }
}

