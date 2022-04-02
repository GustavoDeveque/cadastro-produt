using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
    [Table("produto", Schema = "public")]
    public class DtoProduto
    {
        [Key]

        public int id_produto {get;set;}
        public string nome_produto { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
    }
}
