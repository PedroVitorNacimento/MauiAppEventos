namespace MauiAppEventos.Models
{
    public   class confirmacao
    {
        public Eventos EventoSelecionado { get; set; }
        public int QtdConvidados {  get; set; }

        public DateTime DataEvento {  get; set; }

        public double Valortotal 
        {
         get 
            {
                double total = EventoSelecionado.valor_pessoa * QtdConvidados;
                return total;
            }
        }
    }
}
