using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JayAPI.Models
{
    public class Parceiro
    {
        public int id { get; set; }

        [MaxLength(200)]
        public string razaoSocial { get; set; }

        [MaxLength(200)]
        public string nomeFantasia { get; set; }


        [MaxLength(17)]
        public string cnpj { get; set; }

        [MaxLength(20)]
        public string ie { get; set; }
        public bool pessoaJuridica { get; set; }


        public Endereco endereco { get; set; }
        public Endereco enderecoCobranca { get; set; }
        public Endereco enderecoEntrega { get; set; }

    }
}
