using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using GestioneVisitatori.Models;
using HttpClient = System.Net.Http.HttpClient;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GestioneVisitatori.Views
{

    public sealed partial class Event : Page
    {
        private string _urlUsers = $"http://localhost:8080/api/events/{MainPage.id}";
        private readonly HttpClient _httpClient = new HttpClient();


        public Event()
        {
            this.InitializeComponent();

            _ = GetPlaceholderEvent();

        }


        private async Task GetPlaceholderEvent()
        {
            var eventi = await _httpClient.GetFromJsonAsync<Evento>(_urlUsers);
        }

        private void Home_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void DecreaseQuantity_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void IncreaseQuantity_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
