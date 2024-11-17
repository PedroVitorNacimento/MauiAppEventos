namespace MauiAppEventos;

public partial class login : ContentPage
{

	public login()
	{
		InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			List<DadosUsuario>lista_usuarios=new List<DadosUsuario>()

			{ 
				new DadosUsuario()
				{
					Usuarios = "Pedro",
					Senha="1234"
				},
				new DadosUsuario()
				{
					Usuarios = "Maria",
					Senha ="4321"
				}
			};

			DadosUsuario dados_digitados = new DadosUsuario()
			{
				Usuarios = txt_usuarios.Text,
				Senha = txt_senhas.Text
			};
			//linq 
			if(lista_usuarios.Any(i=>dados_digitados.Usuarios == i.Usuarios && dados_digitados.Senha == i.Senha))
			{
				SecureStorage.Default.SetAsync("Usuario logado", dados_digitados.Usuarios);
				App.Current.MainPage = new Protegida();
			}
			else
			{
				throw new Exception("usuario ou senha incorreto");
			}
		}
		catch (Exception ex) 
		{
			DisplayAlert("ops", ex.Message, "fechar");
		}
    }
}