namespace PasswordVisibilityIssueEntry;

public partial class MainPage : ContentPage
{	
	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        this.entry.IsPassword = !this.entry.IsPassword;
    }
}

