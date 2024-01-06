using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace db_share.model
{
    public class Modelo
    {
        public int Id {get; set;}

        public string Titulo {get; set;}

        public string ImagemURL {get; set;}

        
        [JsonIgnore]
        public virtual Categoria Categoria {get; set;}

        
        public int CategoriaId {get; set;}
    }
}