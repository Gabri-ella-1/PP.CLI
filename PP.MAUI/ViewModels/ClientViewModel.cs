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
    public class ClientViewModel 

    {
        //public Client SelectedClient { get; set; }
        public Client Model { get; set; }

        //public ObservableCollection<Client> Clients
        public string Display
        {
            get
            {
                //return new ObservableCollection<Client>(ClientService.Current.Clients);
                return Model.ToString() ?? string.Empty;
            }
        }


       

        public ICommand DeleteCommand { get; private set; }

        public void ExecuteDelete(int id)
        {

            ClientService.Current.Delete(id);
        }

        public ICommand EditCommand { get; private set; }

        public void ExecuteEdit(int id) {
            Shell.Current.GoToAsync($"//Add?clientId={id}");
        }


        public ClientViewModel(Client client)
        {
            Model = client;
            DeleteCommand = new Command(
                (c) => ExecuteDelete((c as ClientViewModel).Model.Id));

            EditCommand = new Command(
               (c) => ExecuteEdit((c as ClientViewModel).Model.Id));
        }

        public ClientViewModel(int clientId)
        {
            Model = ClientService.Current.Get(clientId);
            DeleteCommand = new Command(
                (c) => ExecuteDelete((c as ClientViewModel).Model.Id));

            EditCommand = new Command(
               (c) => ExecuteEdit((c as ClientViewModel).Model.Id));
        }


        public ClientViewModel()
        {
            Model = new Client();
            DeleteCommand = new Command(
                (c) => ExecuteDelete((c as ClientViewModel).Model.Id));

            EditCommand = new Command(
                (c) => ExecuteEdit((c as ClientViewModel).Model.Id));


        }

        public void Add()
        {
            ClientService.Current.Add(Model);
        }


      





    }





}