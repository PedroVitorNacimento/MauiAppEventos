
using MauiAppEventos.Models;

namespace MauiAppEventos
{
    public partial class App : Application
    {
        public List<Eventos> lista_eventos = new List<Eventos>
        {
            new Eventos()
            {
                descricao = "Café da manhã",
                valor_pessoa = 35.0
            },

            new Eventos()
            {
                descricao = "Almoço",
                valor_pessoa = 70.00
            },

            new Eventos()
            {
                descricao = "Jantar",
                valor_pessoa = 90.00
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new login();
       
        }
        protected override Window CreateWindow(IActivationState activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;
                return window;
        }
    }//fecha classe
}//fecha namespace
