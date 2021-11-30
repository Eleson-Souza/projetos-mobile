using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace tp03_mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Login();
        }

        public async void Login()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("http://localhost:61337/api/Logins1");
            var login = JsonConvert.DeserializeObject<List<Login>>(response);

            ListLogin.ItemsSource = login;
        }
    }
}
