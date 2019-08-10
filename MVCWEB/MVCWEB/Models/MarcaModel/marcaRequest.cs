using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWEB.Models.MarcaModel
{
    public class CategoriaRequest
    {
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "La Marca ingresada exede la longitud establecida")]
        [Display(Name = "Nombre de Marca")]
        public string NombreMarca
        {
            get; set;
        }
    }

    public class EditMarca
    {
        public int idMarca { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "La Marca ingresada exede la longitud establecida")]
        [Display(Name = "Nombre de Marca")]
        public string NombreMarca
        {
            get; set;
        }
    }
}