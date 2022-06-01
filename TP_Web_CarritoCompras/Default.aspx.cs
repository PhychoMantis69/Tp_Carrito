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
        //public List <Articulo> listaFiltrada{ get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            //listaFiltrada = new List<Articulo>();
            //listado = new List<Articulo>();
            listado = articulo.listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text;
            //listaFiltrada = listado.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()));
            Session.Add("nombreArticulo", filtro);
            Response.Redirect("Busqueda.aspx", false);
        }
    }
}