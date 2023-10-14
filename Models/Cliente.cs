using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace Vendas.Models
{

    [Table("Cliente")]
    public class Cliente
    {

        //[Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public DateTime DataCriacao { get; set; }
        

        public Cliente()
        {
                
        }

        public Cliente(int id, string nome, string endereco, string ciadde, string uf)
        {
            Nome= nome;
            Endereco= endereco;
            Cidade= ciadde;
            Uf= uf;            
               
        }


    }
}
