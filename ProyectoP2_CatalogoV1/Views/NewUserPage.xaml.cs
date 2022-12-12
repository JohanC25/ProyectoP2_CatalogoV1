namespace ProyectoP2_CatalogoV1.Views;

[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class NewUserPage : ContentPage
{

    public NewUserPage()
    {
        InitializeComponent();

        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.users.txt";

        LoadUser(Path.Combine(appDataPath, randomFileName));
    }

    private async void Btn_RegistrarUser_Clicked(object sender, EventArgs e)
    {
        // Save the file.
        if (BindingContext is Model.User users)
            File.WriteAllText(users.Filename, NombreUsuario.Text + "\n" + Password.Text + "\n" + Telefono.Text + "\n");

        //await Shell.Current.GoToAsync("..");
        await Navigation.PushModalAsync(new MainPage());
    }

    private void LoadUser(string fileName)
    {
        Model.User userModel = new Model.User();
        userModel.Filename = fileName;

        if (File.Exists(fileName))

        {

            userModel.Date = File.GetCreationTime(fileName);
            userModel.Text = File.ReadAllText(fileName);
        }

        BindingContext = userModel;
    }

    public string ItemId
    {
        set { LoadUser(value); }
    }
    private async void Btn_Regresar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new MainPage());
    }
}