using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TP_Web_CarritoCompras
{
    public partial class _Default : Page
    {
        public List<Articulo> listado{ get; set; }

        public List<Articulo> listaFiltrada;

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            //listaFiltrada = new List<Articulo>();
            //listado = new List<Articulo>();
            listado = articulo.listar();
            Session.Add("ListaDeArticulos", listado);
            listaFiltrada = new List<Articulo>();
            Session.Add("ListaFiltrada", listaFiltrada);

           
            
            if(Request.QueryString["id"] != null)
            {
                string ID = Request.QueryString["ID"].ToString();
                // Response.Redirect("ArticulosEnCarrito.aspx?ID= " + ID, false);
                //Session.Add("ID", ID);
                listaFiltrada = (List<Articulo>)Session["ListaFiltrada"];
                listado = (List<Articulo>)Session["ListaDeArticulos"];
                listaFiltrada.Add(listado.Find(x => x.ID == int.Parse(ID)));
                Session.Add("ListaFiltrada", listaFiltrada);
            }
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            //listaFiltrada = listado.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            Session.Add("nombreArticulo", filtro);
            Response.Redirect("Busqueda.aspx", false);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Session.Add()

            //Response.Redirect("ArticulosEnCarrito.aspx?ID=" + pupi, false);

            Response.Redirect("ArticulosEnCarrito.aspx" , false);
        }

        protected void Carrito_Click(object sender, EventArgs e)
        {
            Response.Redirect("ArticulosEnCarrito.aspx", false);
        }
    }
}