using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinForms_ABM
{
    public partial class FormInicio : Form
    {
        private List<Articulo> listaArticulos;
        private Articulo articulo = null;
        public FormInicio()
        {
            InitializeComponent();
            this.articulo = articulo;
            //Text = "Modificar Artículo";
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            actualizar();
            cbxCampo.Items.Add("Código");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Precio");
            
            cargarAgregar();
           //pbAtras.Load("https://w7.pngwing.com/pngs/398/861/png-transparent-flickr-logo-computer-icons-button-back-angle-text-logo.png");
        }

        private void cargarAgregar()
        {
            MarcaNegocio marca = new MarcaNegocio();

            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marca.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoria.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                /*if (articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxImagenUrl.Text = articulo.ImagenUrl;
                    cbxMarca.SelectedValue = articulo.Marca.ID;
                    cbxCategoria.SelectedValue = articulo.Categoria.ID;
                    tbxPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.ImagenUrl);
                }*/
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarEditar()
        {
            try
            {
                if (articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxImagenUrl.Text = articulo.ImagenUrl;
                    cbxMarca.SelectedValue = articulo.Marca.ID;
                    cbxCategoria.SelectedValue = articulo.Categoria.ID;
                    tbxPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.ImagenUrl);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        /*private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDatos.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                cargarImagen(articuloSeleccionado.ImagenUrl);
            }
        }*/

        private void cargarImagen(string url)
        {
            try
            {
                pbImagenAdd.Load(url);

            }
            catch (Exception)
            {
                pbImagenAdd.Load("https://www.agora-gallery.com/advice/wp-content/uploads/2015/10/image-placeholder.png");
            }
        }

        private void actualizar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvDatos.DataSource = listaArticulos;
                //dgvDatosFiltrados.DataSource = listaArticulos;
                ocultarColumnas();
                //dgvDatos.Columns["Codigo"].Width = 40;
                //cargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvDatos.Columns["ImagenUrl"].Visible = false;
            dgvDatos.Columns["Id"].Visible = false;
        }

        private void limpiarCampos()
        {
            tbxBusqueda.Text = null;
            pbImagenAdd.Image = null;
            tbxCodigo.Text = null;
            tbxNombre.Text = null;
            tbxPrecio.Text = null;
            cbxMarca.SelectedIndex = 0;
            cbxCategoria.SelectedIndex = 0;
            tbxImagenUrl.Text = null;
            tbxDescripcion.Text = null;
            cbxCampo.SelectedIndex = 0;
            cbxCriterio.SelectedIndex = 0;
            tbxFiltro.Text = null;
            lblDetalleCodigo.Text = null;
            lblNombreArticulo.Text = null;
            lblDetalleMarca.Text = null;
            lblDetalleCategoria.Text = null;
            lblDetallePrecio.Text = null;
            lblDA.Text = null;
        }

        private bool validarSeleccion(DataGridView dgv)
        {
            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //frmAltaArticulo alta = new frmAltaArticulo();
            //alta.ShowDialog();
            limpiarCampos();
            tpCatalogo.SelectedIndex = 1;
            //actualizar();
            //tpCatalogo.SelectedIndex = 0;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Articulo seleccionado;
            //articulo = new Articulo();
            if (!validarSeleccion(dgvDatos))
            {
                return;
            }
            articulo = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
            //frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            //modificar.ShowDialog();
            cargarEditar();
            tpCatalogo.SelectedIndex = 1;
            //cargarAgregar();
            //actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articulo;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    articulo = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(articulo.ID);
                    actualizar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        private void tbxBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbxBusqueda.Text;
            if (filtro.Length > 2)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) ||
                x.Marca.Descripcion.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private bool validarFiltro()
        {
            if(cbxCampo.SelectedIndex == 2 && cbxCriterio.SelectedIndex >= 0 && !soloNumeroDecimales(tbxFiltro.Text))
            {
                MessageBox.Show("Error, introduzca valores numéricos", "Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(cbxCampo.SelectedIndex < 0 && cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione las opciones: \n- Campo\n- Criterio", "Búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el campo a filtrar", "Búsqueda", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio a filtrar", "Búsqueda", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (!validarFiltro())
                    return;
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = tbxFiltro.Text;
                //listaArticulos = negocio.listar();
                //dgvDatosFiltrados.DataSource = listaArticulos;
                if (filtro == "")
                    dgvDatosFiltrados.DataSource = listaArticulos;
                else
                    dgvDatosFiltrados.DataSource = negocio.filtrar(campo, criterio, filtro);
                dgvDatosFiltrados.Columns["Id"].Visible = false;
                dgvDatosFiltrados.Columns["ImagenUrl"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if (opcion == "Código" || opcion == "Nombre")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Empieza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
            else if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Igual a");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Articulo articulo = new Articulo();
            ArticuloNegocio datos = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                

                //Validaciones 

                //Esto valida que se ingrese un campo obligatoriamente en Codigo
                if (string.IsNullOrEmpty(tbxCodigo.Text))
                {
                    MessageBox.Show("Debe cargar el campo de Codigo");
                    return;
                }

                //Esto valida que se ingrese un campo obligatoriamente en Nombre
                if (string.IsNullOrEmpty(tbxNombre.Text))
                {
                    MessageBox.Show("Debe cargar el campo de Nombre");
                    return;
                }

                //Esto valida que se ingrese un campo obligatoriamente en Precio
                if (string.IsNullOrEmpty(tbxPrecio.Text))
                {
                    MessageBox.Show("Debe cargar el campo de Precio");
                    return;
                }

                //Esto valida que se ingrese un campo obligatoriamente en Descripcion
                if (string.IsNullOrEmpty(tbxDescripcion.Text))
                {
                    MessageBox.Show("Debe cargar el campo de Descripcion");
                    return;
                }

                //Esto valida que el dato que se ingresa en el campo precio, sea obligatoriamente un numero
                if (!soloNumeroDecimales(tbxPrecio.Text))
                {
                    MessageBox.Show("El dato ingresado en el campo precio, no es un numero");
                    return;
                }


                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.ImagenUrl = tbxImagenUrl.Text;
                //pbImagenAdd.Visible = true;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Precio = Convert.ToDecimal(tbxPrecio.Text);

                if (articulo.ID == 0)
                {
                    datos.agregarArticulo(articulo);
                    MessageBox.Show("El artículo se ha agregado exitosamente");

                }
                else
                {
                    datos.modificarArticulo(articulo);
                    MessageBox.Show("El articulo se ha modificado exitosamente");

                }
                //Close();
                tpCatalogo.SelectedIndex = 0;
                actualizar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tpCatalogo.SelectedIndex = 0;
        }

        private void tbxImagenUrl_Leave(object sender, EventArgs e)
        {
            //bImagenAdd.Visible = true;
            //pbImagenAdd = new PictureBox();
            cargarImagen(tbxImagenUrl.Text);
        }


        //Validaciones

        //Esto valida si una cadena no contiene un numero
        private bool soloNumero(string cadena)
        {

            foreach (char item in cadena)
            {

                if(!(char.IsNumber(item)))
                    return false;   
            }
            return true;
        }


        //Esto valida si una cadena contiene numeros decimales
        private bool soloNumeroDecimales(string cadena)
        {

            foreach (char item in cadena)
            {

                if (!(char.IsNumber(item)) && !(item == ',') && !(item == '.'))
                    return false;
            }
            return true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //cbxCampo.SelectedIndex = null;
            tbxFiltro.Text = null;
            dgvDatosFiltrados.DataSource = null;
            tpCatalogo.SelectedIndex = 0;
        }


        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            tpCatalogo.SelectedIndex = 3;
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            try
            {
                if (!validarSeleccion(dgvDatos))
                {
                    return;
                }
                articulo = (Articulo)dgvDatos.CurrentRow.DataBoundItem;
                tpCatalogo.SelectedIndex = 2;
                lblDetalleCodigo.Text = articulo.Codigo;
                lblNombreArticulo.Text = articulo.Nombre;
                lblDetalleMarca.Text = articulo.Marca.Descripcion;
                lblDetalleCategoria.Text = articulo.Categoria.Descripcion;
                lblDetallePrecio.Text = articulo.Precio.ToString();
                lblDA.Text = articulo.Descripcion;
                cargarImagenDetalles(articulo.ImagenUrl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagenDetalles(string url)
        {
            try
            {
                pbImagenDetalles.Load(url);

            }
            catch (Exception)
            {
                pbImagenDetalles.Load("https://www.agora-gallery.com/advice/wp-content/uploads/2015/10/image-placeholder.png");
            }
        }

        private void lblDetallesAtras_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            tpCatalogo.SelectedIndex = 0;
        }





        /*private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = tbxFiltro.Text;
                //listaArticulos = negocio.listar();
                //dgvDatosFiltrados.DataSource = listaArticulos;
                if (filtro == "")
                    dgvDatosFiltrados.DataSource = listaArticulos;
                else
                    dgvDatosFiltrados.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }*/
    }
}
