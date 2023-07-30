using PP.MAUI.ViewModels;

namespace PP.MAUI.Views;

[QueryProperty(nameof(ClientId), "clientId")]

public partial class AddView : ContentPage
{
    public int ClientId { get; set; }

	public AddView()
	{
		InitializeComponent();
        //BindingContext = new ClientViewModel();
    }

    private void AddClientClicked(object sender, EventArgs e)
    {
       (BindingContext as ClientViewModel).AddorUpdate(ClientId);
        Shell.Current.GoToAsync("//Clients");
    }

     private void CancelClicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync("//Clients");
    }

    private void OnArriving(object sender, NavigatedToEventArgs e)
    {
        BindingContext = new ClientViewModel(ClientId);
        //(BindingContext as ClientViewModel).RefreshProjects();
    }

}
