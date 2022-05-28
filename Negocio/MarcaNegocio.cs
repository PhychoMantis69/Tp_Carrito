using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datosMarca = new AccesoDatos();
            try
            {
                datosMarca.setConsulta("Select Id, Descripcion From MARCAS");
                datosMarca.ejecutarLectura();

                while (datosMarca.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.ID = (int)datosMarca.Lector["Id"];
                    if(!(datosMarca.Lector["Descripcion"] is DBNull))
                    aux.Descripcion = (string)datosMarca.Lector["Descripcion"];

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
                datosMarca.cerrarConexion();
            }
        }
    }
}
