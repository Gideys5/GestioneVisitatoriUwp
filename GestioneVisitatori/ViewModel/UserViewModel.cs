using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GestioneVisitatori.Models;

namespace GestioneVisitatori.ViewModel
{
    internal class UserViewModel : INotifyPropertyChanged
    {
        public User Use = new User();
        public static ObservableCollection<User> ListaPersone { get; set; } = [];

        private User _selectedPersona;
        //public bool CanUpdatePersona => SelectedPersona != null;
        // da mettere nel bottone Aggiorna nello xaml : IsEnabled="{Binding CanUpdatePersona}"


        public User ObjectPersona
        {
            get => Use;
            set
            {
                Use = value;
                OnPropertyChanged(nameof(name));
                OnPropertyChanged(nameof(surname));
                OnPropertyChanged(nameof(birthDay));
                OnPropertyChanged(nameof(email));
                OnPropertyChanged(nameof(password));

            }
        }




        public string name
        {
            get => Use.Name;
            set
            {
                Use.Name = value;
                OnPropertyChanged(nameof(name));
            }
        }
        public string surname
        {
            get => Use.Surname;
            set
            {
                Use.Surname = value;
                OnPropertyChanged(nameof(surname));
            }
        }
        public DateTimeOffset birthDay
        {
            get => Use.BirthDay;
            set
            {
                Use.BirthDay = value.Date;
                OnPropertyChanged(nameof(birthDay));
            }
        }
        public string email
        {
            get => Use.Email;
            set
            {
                Use.Email = value;
                OnPropertyChanged(nameof(email));
            }
        }
        public string password
        {
            get => Use.Password;
            set
            {
                Use.Password = value;
                OnPropertyChanged(nameof(password));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
    
}
