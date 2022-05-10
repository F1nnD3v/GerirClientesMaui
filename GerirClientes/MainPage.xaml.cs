namespace GerirClientes;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        lblErro.Opacity = 1;
	}

    private void tboxPassword_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (lblErro.Opacity == 1)
        {
            lblErro.Opacity = 0;
        }
    }

    private void tboxUserName_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (lblErro.Opacity == 1)
        {
            lblErro.Opacity = 0;
        }
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        string username, password;
        username = tboxUserName.Text;
        password = "Admin123";
        //password = tboxPassword.Text;

        if (username == "" || password == "")
        {
            lblErro.Text = "Um ou mais campos por preencher!";
            lblErro.Opacity = 1;
        }
        else if (username != "Admin" || password != "Admin123")
        {
            lblErro.Text = "Username ou Password incorretos!";
            lblErro.Opacity = 1;
        }
        else
        {
            tboxUserName.Text = "";
            await Navigation.PushAsync(new GestaoClientes());
        }
    }
}