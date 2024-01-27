using Blazored.LocalStorage;
using Flurl.Http;
using hgrkapp.DTO;
using hgrkapp.Helper;
using hgrkapp.Repository.IServices;
using hgrkapp.Routes;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using hgrkapp.Pages;

namespace hgrkapp.Repository.Services
{
    public class AuthenticationService : IAuthenticationService

    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthenticationService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }



        public async Task<LoginResult> Login(User user)
        {
            try
            {

                var response = await routes_const.Login
                     .PostJsonAsync(user)
                     .ReceiveJson<LoginResult>();
                if (response!=null)
                {
                    await _localStorage.SetItemAsync("authToken", response!.token);
                    ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(user.Username!);
                    _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", response.token);
                    return response;
                }

                LoginResult login = new LoginResult();
                login.Successful = false;
                return login;


            }
            catch (FlurlHttpException ex)
            {
                // Gérer les erreurs, par exemple, retourner null ou une chaîne d'erreur.
                LoginResult login = new LoginResult();
                login.Successful = false;
                return login;
            }
        }
        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<RegisterResponse> Register(User user)
        {
            try
            {

                var response = await routes_const.Register
                     .PostJsonAsync(user)
                     .ReceiveJson<RegisterResponse>();

                return response;
            }
            catch (FlurlHttpException ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error during POST request: {ex.Message}");

                // Additional details
                if (ex.Call.Response != null)
                {
                    Console.WriteLine($"Status Code: {ex.Call.Response.StatusCode}");
                    //Console.WriteLine($"Response Content: {await ex.Call.Response.Content.ReadAsStringAsync()}");
                }

                throw; // Re-throw the exception
            }
        }
    }
}
