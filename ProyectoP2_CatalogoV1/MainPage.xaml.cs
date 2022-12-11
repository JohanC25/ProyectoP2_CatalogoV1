namespace ProyectoP2_CatalogoV1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private async void Btn_CrearUser_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new NewUserPage());
    }

    private async void Btn_IniciarSesion_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ProductosPage());
    }
}

