using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_Web_CarritoCompras
{
    public partial class ArticulosEnCarrito : System.Web.UI.Page
    {

        public List<Dominio.Articulo> ListaArticulos { get; set; }

        public List<Dominio.Articulo> articulosEnCarrito { get; set; }   

        
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            ListaArticulos = (List<Dominio.Articulo>)Session["ListaDeArticulos"];
            int ID;

            ID = Convert.ToInt32(Session["ID"]);    
            //int.TryParse(Request.QueryString["ID"], out ID); 
            
            articulosEnCarrito = new List<Dominio.Articulo>();
            articulosEnCarrito.Add(ListaArticulos.Find(x => x.ID == ID));

            GridView1.DataSource = articulosEnCarrito;
            GridView1.DataBind();
            */

            GridView1.DataSource = Session["ListaFiltrada"];
            GridView1.DataBind();

        }
    }
}