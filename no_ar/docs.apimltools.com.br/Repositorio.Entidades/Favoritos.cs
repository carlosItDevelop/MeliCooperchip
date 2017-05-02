using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades {
    public class Favoritos {

        [Key]
        public int FavoritosId { get; set; }


        public string Source { get; set; }

        [Required]      
        public string Tag { get; set; }

        [Required]
        public string Link { get; set; }


    }
}
