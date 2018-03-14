using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseandoAp.Domain
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required (ErrorMessage ="El campo {0} es requerido")]
        [MaxLength (50,ErrorMessage ="El campo {0} solo puede contener {1} caracteres")]
        [Index ("Category_Descripcion_Index",IsUnique =true)]
        public string Descripcion { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
