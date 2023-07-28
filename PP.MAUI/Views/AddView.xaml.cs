using PP.MAUI.ViewModels;

namespace PP.MAUI.Views;

public partial class AddView : ContentPage
{
	public AddView()
	{
		InitializeComponent();
        BindingContext = new ClientViewModel();
    }

    private void AddClientClicked(object sender, EventArgs e)
    {
        (BindingContext as ClientViewModel).Add();
        Shell.Current.GoToAsync("//Clients");
    }


}
