using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
//.
namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            //SqlDataReader lector;
            AccesoDatos datos = new AccesoDatos();

            try
            {
                //conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                //comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "Select a.ID, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion Marca," +
                //    " c.Descripcion Categoria, a.ImagenUrl, a.Precio From ARTICULOS a Inner Join MARCAS m on a.IdMarca = m.Id" +
                //    " Inner Join CATEGORIAS c on a.IdCategoria = c.Id";
                datos.setConsulta("Select a.ID, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion Marca, " +
                    "c.Descripcion Categoria, a.ImagenUrl, a.Precio, m.Id as IdMarca, c.Id as IdCategoria From ARTICULOS a " +
                    "Inner Join MARCAS m on a.IdMarca = m.Id Inner Join CATEGORIAS c on a.IdCategoria = c.Id");
                datos.ejecutarLectura();
                //comando.Connection = conexion;
                
                //conexion.Open();
                //lector = comando.ExecuteReader();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)datos.Lector["ID"];
                    if(!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if(!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if(!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion= (string)datos.Lector["Descripcion"];
                    if(!(datos.Lector["Marca"] is DBNull))
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    if(!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion= (string)datos.Lector["Categoria"];
                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    if(!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["IdMarca"] is DBNull))
                        aux.Marca.ID = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.Categoria.ID = (int)datos.Lector["IdCategoria"];

                    lista.Add(aux);

                }

                //conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                //Prueba
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("Insert Into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio)" +
                    " Values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.setParametros("@Codigo", articulo.Codigo);
                datos.setParametros("@Nombre", articulo.Nombre);
                datos.setParametros("@Descripcion", articulo.Descripcion);
                datos.setParametros("@IdMarca", articulo.Marca.ID);
                datos.setParametros("@IdCategoria", articulo.Categoria.ID);
                datos.setParametros("@ImagenUrl", articulo.ImagenUrl);
                datos.setParametros("@Precio", articulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("Update ARTICULOS Set Codigo = @Codigo, Nombre = @Nombre, " +
                    "Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria," +
                    " ImagenUrl = @ImagenUrl, Precio = @Precio Where Id = @Id");
                datos.setParametros("@Codigo", articulo.Codigo);
                datos.setParametros("@Nombre", articulo.Nombre);
                datos.setParametros("@Descripcion", articulo.Descripcion);
                datos.setParametros("@IdMarca", articulo.Marca.ID);
                datos.setParametros("@IdCategoria", articulo.Categoria.ID);
                datos.setParametros("@ImagenUrl", articulo.ImagenUrl);
                datos.setParametros("@Precio", articulo.Precio);
                datos.setParametros("@Id", articulo.ID);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "Select a.ID, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion Marca, " +
                    "c.Descripcion Categoria, a.ImagenUrl, a.Precio, m.Id as IdMarca, c.Id as IdCategoria From ARTICULOS a " +
                    "Inner Join MARCAS m on a.IdMarca = m.Id Inner Join CATEGORIAS c on a.IdCategoria = c.Id " +
                    "Where ";
                switch (campo)
                {
                    case "Código":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += "a.Codigo like '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "a.Codigo like '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "a.Codigo like '%" + filtro + "%'";
                                break;

                            default:
                                consulta += "a.Codigo like '%%'";
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Empieza con":
                                consulta += "a.Nombre like '" + filtro + "%'";
                                break;

                            case "Termina con":
                                consulta += "a.Nombre like '%" + filtro + "'";
                                break;

                            case "Contiene":
                                consulta += "a.Nombre like '%" + filtro + "%'";
                                break;

                            default:
                                consulta += "a.Nombre like '%%'";
                                break;
                        }
                        break;

                    case "Precio":
                        switch (criterio)
                        {
                            case "Menor a":
                                consulta += "a.Precio < " + filtro;
                                break;

                            case "Mayor a":
                                consulta += "a.Precio > " + filtro;
                                break;

                            case "Igual a":
                                consulta += "a.Precio = " + filtro;
                                break;
                            default:
                                consulta = "Select a.ID, a.Codigo, a.Nombre, a.Descripcion, m.Descripcion Marca, " +
                                "c.Descripcion Categoria, a.ImagenUrl, a.Precio, m.Id as IdMarca, c.Id as IdCategoria From ARTICULOS a " +
                                "Inner Join MARCAS m on a.IdMarca = m.Id Inner Join CATEGORIAS c on a.IdCategoria = c.Id " +
                                "Where a.Activo = 1";
                                break;
                        }
                        break;
                }
                datos.setConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.ID = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull)) 
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];
                    if (!(datos.Lector["IdMarca"] is DBNull))
                        aux.Marca.ID = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.Categoria.ID = (int)datos.Lector["IdCategoria"];

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
                datos.cerrarConexion();
            }
        }

        public void eliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("Delete From ARTICULOS where id = @Id");
                datos.setParametros("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
