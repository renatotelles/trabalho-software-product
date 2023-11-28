
namespace Vendas.Models
{
    public class FormaDePagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Prazo { get; set; }
        public double Taxa { get; set; }
        public DateTime DataCriacao { get; set; }

        public FormaDePagamento()
        {
                
        }

        public FormaDePagamento(int id, string nome, int prazo, double taxa)
        {
            Id = id;
            Nome = nome;    
            Prazo = prazo;
            Taxa = taxa;

        }
    }
}
