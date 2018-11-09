using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using TestePratico.Data;

namespace TestePratico.Models
{
    public class Estabelecimento
    {
        public int estabelecimentoID { get; set; }

        [Display(Name = "Razão Social: ")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string razao_social { get; set; }

        [Display(Name = "Fantasia: ")]
        public string fantasia { get; set; }

        [Display(Name = "CNPJ: ")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string cnpj { get; set; }

        [Display(Name = "E-mail: ")]
        public string email { get; set; }

        [Display(Name = "Endereço: ")]
        public string endereco { get; set; }

        [Display(Name = "Cidade: ")]
        public string cidade { get; set; }

        [Display(Name = "Estado: ")]
        public string estado { get; set; }

        [Display(Name = "Telefone: ")]
        public string telefone { get; set; }

        [Display(Name = "Data Cadastro: ")]
        public DateTime data_cadastro { get; set; }

        public int categoriaID { get; set; }

        [Display(Name = "Categoria: ")]
        public IEnumerable<SelectListItem> categoria { get; set; }

        [Display(Name = "Status: ")]
        public bool status { get; set; }

        [Display(Name = "Agência: ")]
        public string agencia { get; set; }

        [Display(Name = "Conta: ")]
        public string conta { get; set; }

        public Estabelecimento()
        {
            categoria = new CategoriaRepository().GetCategorias();
        }

    }
}