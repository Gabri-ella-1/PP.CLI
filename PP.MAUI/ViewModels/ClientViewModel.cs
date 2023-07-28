using PP.Library.Models;
using PP.Library.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace PP.MAUI.ViewModels
{
    public class ClientViewModel : INotifyPropertyChanged

    {
        public Client SelectedClient { get; set; }


        public ObservableCollection<Client> Clients
        {
            get
            {
                return new ObservableCollection<Client>(ClientService.Current.Clients);
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /*
        public string Query { get; set; }

        public void Search()
        {
            NotifyPropertyChanged("Clients");
        }
        */
        public void Delete()
        {

            if (SelectedClient != null)
            {/*
                    Console.WriteLine("DELETED");
                    ClientService.Current.Delete(SelectedClient.Id);
                    Console.WriteLine(SelectedClient.Id);
                    NotifyPropertyChanged(nameof(Clients));
                    //SelectedClient = null;
                    // NotifyPropertyChanged(nameof(Clients));*/
                ClientService.Current.Delete(SelectedClient.Id);
                SelectedClient = null;
                NotifyPropertyChanged(nameof(Clients));
                NotifyPropertyChanged(nameof(SelectedClient));
            }

            // NotifyPropertyChanged(nameof(Clients));


        }

        //public Client SelectedClient { get; set; }





    }





}