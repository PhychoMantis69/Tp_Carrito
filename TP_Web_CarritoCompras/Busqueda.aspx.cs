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
    public partial class Busqueda : System.Web.UI.Page
    {
        public string filtro { get; set; }
        public List<Articulo> listaFiltrada { get; set; }
        public List<Articulo> listadoArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            listaFiltrada = new List<Articulo>();
            ArticuloNegocio negocio = new ArticuloNegocio();
            //listadoArticulos = new List<Articulo>();
            listadoArticulos = negocio.listar();
            filtro = Session["nombreArticulo"] != null ? Session["nombreArticulo"].ToString() : "-";
            listaFiltrada = listadoArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
        }
    }
}