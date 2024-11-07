using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using GestioneVisitatori.Views;
using GestioneVisitatori.Models;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GestioneVisitatori
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //JSON restcontroller del dettaglio evento 
        private readonly string _urlUsers = "http://localhost:8080/api/events/all";
        private readonly HttpClient _httpClient = new HttpClient();
        public static int id = 0;

        public MainPage()
        {
            this.InitializeComponent();
            _ = GetPlaceholderEvent();

        }

        private async Task GetPlaceholderEvent()
        {
            var eventi = await _httpClient.GetFromJsonAsync<List<Evento>>(_urlUsers);
            EventList.ItemsSource = eventi;
        }

        private void ButtonBaseLogin_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void ButtonBaseRegister_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Register));
        }

        private void ButtonBaseGoToEvent_OnClick(object sender, RoutedEventArgs e)
        {

        }


        private void EventoSelezionato(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = EventList.SelectedItem;

            if (selectedItem != null)
            {
                var selectedEvent = (Evento)selectedItem;
                id = selectedEvent.IdEvento;

            }

            // Opzionalmente, deseleziona l'elemento per consentire una nuova selezione
            EventList.SelectedItem = null;
            Frame.Navigate(typeof(Event), id);

        }
    }
}
