namespace PP.MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void ClientsClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("//Clients");
    }
}


