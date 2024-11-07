using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GestioneVisitatori.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        public Register()
        {
            this.InitializeComponent();
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Codice per registrare l'utente, es. validazione email, password, ecc.
        }

        private void LoginLink_Click(object sender, RoutedEventArgs e)
        {
            // Navigazione alla pagina di login
            Frame.Navigate(typeof(Login));
        }

        private void BackToHome_Click(object sender, RoutedEventArgs e)
        {
            // Navigazione alla pagina home
            Frame.Navigate(typeof(MainPage));

        }

    }
}
