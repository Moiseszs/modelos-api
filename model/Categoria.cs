using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace db_share.model
{
    public class Categoria 
    {
        public Categoria()
        {
            Modelos = new List<Modelo>();
        }


        public int Id {get; set;}

        public string Nome {get; set;}

        public virtual ICollection<Modelo>? Modelos {get; set;}

    }
}