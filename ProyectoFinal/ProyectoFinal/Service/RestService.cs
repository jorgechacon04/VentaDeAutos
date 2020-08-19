using Newtonsoft.Json;
using ProyectoFinal.Dto;
using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class RestService
    {
        //Direccion donde esta el servicio escrito en python hosteado
        private const string baseUrl = "http://173.230.132.251";

        private HttpClient httpClient;

        public RestService()
        {
            this.httpClient = new HttpClient();
        }

        public async Task<AuthUserDto> AuntenticateUser(AuthUser authUser)
        {

            var content = new StringContent(JsonConvert.SerializeObject(authUser), Encoding.UTF8, "application/json");

            string response = await httpClient.PostAsync(baseUrl + "/authenticate", content).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<AuthUserDto>(response);
        }

        public async Task<User> GetUserInfo()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenTransporter.Instance.Token);

            string response = await httpClient.GetAsync(baseUrl + "/user").Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<User>(response);
        }

        public async Task<UserDto> CreateUser(User user)
        {

            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            string response = await httpClient.PostAsync(baseUrl + "/user", content).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UserDto>(response);
        }

        public async Task<UserDto> UpdateUser(User user)
        {

            var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            string response = await httpClient.PutAsync(baseUrl + "/user", content).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<UserDto>(response);
        }

        public async Task<CarDto> RegisterCar(Car car)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenTransporter.Instance.Token);

            var content = new StringContent(JsonConvert.SerializeObject(car), Encoding.UTF8, "application/json");

            string response = await httpClient.PostAsync(baseUrl + "/car", content).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CarDto>(response);

        }

        public async Task<CarDto> UpdateCar(Car car)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenTransporter.Instance.Token);

            var content = new StringContent(JsonConvert.SerializeObject(car), Encoding.UTF8, "application/json");

            string response = await httpClient.PutAsync(baseUrl + "/car", content).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<CarDto>(response);

        }

        public async Task<List<CarDto>> GetCar(string id)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenTransporter.Instance.Token);

            string response = await httpClient.GetAsync(baseUrl + "/car?carID="+id).Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<CarDto>>(response);

        }

        public async Task<List<CarListDTO>> GetAllCars()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenTransporter.Instance.Token);

            string response = await httpClient.GetAsync(baseUrl + "/car").Result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<CarListDTO>>(response);

        }
    }
}
