namespace MauiAppEventos;

public partial class CalculoEvento : ContentPage
{
	public CalculoEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            App.Current.MainPage = new Protegida(); ;
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "ok");
        }

    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            App.Current.MainPage = new login(); ;
        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "ok");
        }
    }
}