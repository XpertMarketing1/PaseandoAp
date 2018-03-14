using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaseandoAp.Domain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public int CategoryID { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido.")]
        [MaxLength(50,ErrorMessage ="El campo {0} solo puede contener {1} caracteres")]
        [Index ("Product_Descripction_Index", IsUnique =true)]
        public string Description { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DisplayFormat(DataFormatString ="{0:C2}", ApplyFormatInEditMode =false)]
        public decimal Precio { get; set; }

        [Display (Name ="Is Active")]
        public bool IsActive { get; set; }

        public bool Stock { get; set; }

        [Display (Name =Ultim)]
        public DateTime UltimaCompra { get; set; }

        [DataType(DataType.MultilineText)]
        public string Comentarios { get; set; }

        public virtual Category Category { get; set; }
    }
}
