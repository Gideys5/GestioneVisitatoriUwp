﻿using System;
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
    public sealed partial class Login : Page
    {
        public Login()
        {
            this.InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Codice per eseguire il login, ad esempio verificando l'email e la password
        }

        private void RegisterLink_Click(object sender, RoutedEventArgs e)
        {
            // Navigazione alla pagina di registrazione
            Frame.Navigate(typeof(Register));
        }

        private void BackToHome_Click(object sender, RoutedEventArgs e)
        {
            // Navigazione alla pagina home
            Frame.Navigate(typeof(MainPage));

        }

    }
}
