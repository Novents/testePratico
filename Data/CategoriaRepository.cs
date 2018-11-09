using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestePratico.Data
{
    public class CategoriaRepository : DbContext
    {
        public IEnumerable<SelectListItem> GetCategorias()
        {
            using (var context = new TestePraticoContext())
            {
                List<SelectListItem> categorias = context.Categorias.AsNoTracking()
                    .OrderBy(n => n.no_categoria)
                        .Select(n =>
                        new SelectListItem
                        {
                            Value = n.categoriaID.ToString(),
                            Text = n.no_categoria
                        }).ToList();
                var tipoCategoria = new SelectListItem()
                {
                    Value = null,
                    Text = "--- Selecione uma Categoria ---"
                };
                categorias.Insert(0, tipoCategoria);
                return new SelectList(categorias, "Value", "Text");
            }
        }

    }
}