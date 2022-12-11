using Microsoft.Maui;
using Microsoft.Maui.Controls;
using System.ComponentModel.DataAnnotations;

namespace ProyectoP2_CatalogoV1;


public partial class NewUserPage : ContentPage
{
    Editor editor;
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "users.txt");

    public NewUserPage()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }

    }

    private async void Btn_Regresar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }

    private async void Btn_RegistrarUser_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
        await Navigation.PushModalAsync(new MainPage());
    }
}