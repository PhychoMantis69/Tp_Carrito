using System;
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
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datosCategoria = new AccesoDatos();
            try
            {
                datosCategoria.setConsulta("Select Id, Descripcion From CATEGORIAS");
                datosCategoria.ejecutarLectura();

                while (datosCategoria.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.ID = (int)datosCategoria.Lector["Id"];
                    if(!(datosCategoria.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datosCategoria.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datosCategoria.cerrarConexion();
            }
        }
    }
}
