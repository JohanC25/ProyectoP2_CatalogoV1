namespace ProyectoP2_CatalogoV1.Views;

public partial class ProductosPage : ContentPage
{
	public ProductosPage()
	{
		InitializeComponent();
	}

    private async void Btn_LogOut_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }
}