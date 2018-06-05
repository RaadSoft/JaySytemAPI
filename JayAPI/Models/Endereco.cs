using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JayAPI.Models
{
    public class Endereco
    {
        public int id { get; set; }
        [MaxLength(9)]
        public string cep { get; set; }
        [MaxLength(200)]
        public string endereco { get; set; }
        [MaxLength(10)]
        public string numero { get; set; }
        [MaxLength(100)]
        public string complemento { get; set; }
        [MaxLength(200)]
        public string bairro { get; set; }
        [MaxLength(200)]
        public string cidade { get; set; }
        [MaxLength(2)]
        public string uf { get; set; }
    }
}
