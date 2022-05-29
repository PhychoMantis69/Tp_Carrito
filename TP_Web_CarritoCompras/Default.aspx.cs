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
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulo = new ArticuloNegocio();
            listado = new List<Articulo>();
            listado = articulo.listar();
        }
    }
}