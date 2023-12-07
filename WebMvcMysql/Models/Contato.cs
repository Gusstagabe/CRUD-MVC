using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMvcMysql.Models
{

    public class Contato
    {

        public int Id { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public String Celular { get; set; }
    }
}
