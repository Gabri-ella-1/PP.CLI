using PP.MAUI.ViewModels;

namespace PP.MAUI.Views;

public partial class ClientView : ContentPage
{
    public ClientView()
    {
        InitializeComponent();
        //BindingContext = new ClientViewModel();
    }

    private void SearchClicked(object sender, EventArgs e)
    {
        (BindingContext as ClientViewViewModel).Search();
        //(BindingContext as ClientViewViewModel).RefreshClientList();
    }



    private void DeleteClicked(object sender, EventArgs e)
    {
        //(BindingContext as ClientViewModel).Delete();
        (BindingContext as ClientViewViewModel).RefreshClientList();
    }

    private void AddClicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync("//Add");
    }

    private void OnArrived(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as ClientViewViewModel).RefreshClientList();
    }

    private void EditClicked(System.Object sender, System.EventArgs e)
    {
       // Shell.Current.GoToAsync("//Edit");
    }

    private void ProjectClicked(System.Object sender, System.EventArgs e)
    {
        //Shell.Current.GoToAsync("//Project");

    }

    private void GoBackClicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");

    }

}