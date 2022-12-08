namespace ProyectoP2_CatalogoV1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void Btn_CrearUser_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new NewUserPage());
    }
}

