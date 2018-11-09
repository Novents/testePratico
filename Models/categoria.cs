using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestePratico.Models
{
    public class Categoria
    {
        public int categoriaID { get; set; }
        [Display(Name = "Categoria: ")]
        public string no_categoria { get; set; }
    }
}