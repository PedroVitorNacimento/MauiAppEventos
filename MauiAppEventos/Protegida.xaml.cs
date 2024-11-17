using MauiAppEventos.Models;

namespace MauiAppEventos;

public partial class Protegida : ContentPage
{
	App propriedadesdoApp;
	public Protegida()
	{
		InitializeComponent();
		propriedadesdoApp = (App)Application.Current;
		pck_evento.ItemsSource = propriedadesdoApp.lista_eventos;
		dtpck_evento.MinimumDate = DateTime.Now;
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			confirmacao c = new confirmacao
			{
				EventoSelecionado = (Eventos)pck_evento.SelectedItem,
				QtdConvidados = Convert.ToInt32(stp_convidados.Value)
			};
            App.Current.MainPage = new CalculoEvento()
			{
				BindingContext = c
			};
		}catch (Exception ex)
		{
			DisplayAlert("ops", ex.Message, "ok");
		}
    }
}