namespace ProyectoP2_CatalogoV1.Views;

public partial class AllUsersPage : ContentPage
{
	public AllUsersPage()
	{
		InitializeComponent();

        BindingContext = Model.AllUser();
	}

    protected override void OnAppearing()
    {
        ((Model.AllUser)BindingContext).LoadUser();
    }

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(NewUserPage));
    }

    private async void usersCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            var users = (Models.User)e.CurrentSelection[0];

            await Shell.Current.GoToAsync($"{nameof(NewUserPage)}?{nameof(NewUserPage.ItemId)}={users.Filename}");

            userCollection.SelectedItem = null;
        }
    }
} 