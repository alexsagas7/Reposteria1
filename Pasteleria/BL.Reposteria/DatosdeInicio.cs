using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Reposteria
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Chocolate";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Frutas";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Quesso";
            contexto.Categorias.Add(categoria3);

          
            var tipo1 = new Tipo();
            tipo1.Descripcion = "Pasteles";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Budines";
            contexto.Tipos.Add(tipo2);

          
            base.Seed(contexto);
        }
    }
}