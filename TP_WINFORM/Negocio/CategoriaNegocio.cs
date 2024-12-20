﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Categoria> listaCategoria = new List<Categoria>();
            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Reader.Read()) 
                {
                    Categoria auxiliar = new Categoria();
                    if (!(datos.Reader["Id"] is DBNull))
                        auxiliar.Id = (int)datos.Reader["Id"];
                    if (!(datos.Reader["Descripcion"] is DBNull))
                        auxiliar.Descripcion = (string)datos.Reader["Descripcion"];
                    listaCategoria.Add(auxiliar);
                }
                return listaCategoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
