
namespace WinForms_ABM
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tpBusquedaAvanzada = new System.Windows.Forms.TabPage();
            this.btnAtras = new System.Windows.Forms.Button();
            this.dgvDatosFiltrados = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tpDetalles = new System.Windows.Forms.TabPage();
            this.lblDA = new System.Windows.Forms.Label();
            this.lblDetallesAtras = new System.Windows.Forms.Button();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.lblDetalleCategoria = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblPrecioArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaArticulo = new System.Windows.Forms.Label();
            this.lblMarcaArticulo = new System.Windows.Forms.Label();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.pbImagenDetalles = new System.Windows.Forms.PictureBox();
            this.tpAgregar_Editar = new System.Windows.Forms.TabPage();
            this.pbImagenAdd = new System.Windows.Forms.PictureBox();
            this.lblImagenUrl = new System.Windows.Forms.Label();
            this.tbxImagenUrl = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tcCatalogo = new System.Windows.Forms.TabPage();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.tbxBusqueda = new System.Windows.Forms.TextBox();
            this.lblListaArticulos = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tpCatalogo = new System.Windows.Forms.TabControl();
            this.panelTitulo.SuspendLayout();
            this.tpBusquedaAvanzada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosFiltrados)).BeginInit();
            this.tpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenDetalles)).BeginInit();
            this.tpAgregar_Editar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenAdd)).BeginInit();
            this.tcCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tpCatalogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(748, 50);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitulo.Location = new System.Drawing.Point(229, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(323, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CATALOGO DE PRODUCTOS";
            // 
            // tpBusquedaAvanzada
            // 
            this.tpBusquedaAvanzada.Controls.Add(this.btnAtras);
            this.tpBusquedaAvanzada.Controls.Add(this.dgvDatosFiltrados);
            this.tpBusquedaAvanzada.Controls.Add(this.btnBuscar);
            this.tpBusquedaAvanzada.Controls.Add(this.tbxFiltro);
            this.tpBusquedaAvanzada.Controls.Add(this.cbxCriterio);
            this.tpBusquedaAvanzada.Controls.Add(this.lblCampo);
            this.tpBusquedaAvanzada.Controls.Add(this.lblCriterio);
            this.tpBusquedaAvanzada.Controls.Add(this.cbxCampo);
            this.tpBusquedaAvanzada.Controls.Add(this.lblFiltro);
            this.tpBusquedaAvanzada.Location = new System.Drawing.Point(4, 22);
            this.tpBusquedaAvanzada.Name = "tpBusquedaAvanzada";
            this.tpBusquedaAvanzada.Size = new System.Drawing.Size(740, 456);
            this.tpBusquedaAvanzada.TabIndex = 3;
            this.tpBusquedaAvanzada.Text = "Busqueda Avanzada";
            this.tpBusquedaAvanzada.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.Location = new System.Drawing.Point(8, 430);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // dgvDatosFiltrados
            // 
            this.dgvDatosFiltrados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosFiltrados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatosFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosFiltrados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatosFiltrados.Location = new System.Drawing.Point(58, 78);
            this.dgvDatosFiltrados.Name = "dgvDatosFiltrados";
            this.dgvDatosFiltrados.ReadOnly = true;
            this.dgvDatosFiltrados.RowHeadersWidth = 10;
            this.dgvDatosFiltrados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosFiltrados.Size = new System.Drawing.Size(630, 341);
            this.dgvDatosFiltrados.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(613, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFiltro.Location = new System.Drawing.Point(417, 51);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(193, 20);
            this.tbxFiltro.TabIndex = 2;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(258, 51);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(109, 21);
            this.cbxCriterio.TabIndex = 1;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(55, 54);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(40, 13);
            this.lblCampo.TabIndex = 15;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(213, 54);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(39, 13);
            this.lblCriterio.TabIndex = 16;
            this.lblCriterio.Text = "Criterio";
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(101, 51);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(106, 21);
            this.cbxCampo.TabIndex = 0;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(382, 54);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 17;
            this.lblFiltro.Text = "Filtro";
            // 
            // tpDetalles
            // 
            this.tpDetalles.Controls.Add(this.lblDA);
            this.tpDetalles.Controls.Add(this.lblDetallesAtras);
            this.tpDetalles.Controls.Add(this.lblDetallePrecio);
            this.tpDetalles.Controls.Add(this.lblDetalleCategoria);
            this.tpDetalles.Controls.Add(this.lblDetalleMarca);
            this.tpDetalles.Controls.Add(this.lblDetalleCodigo);
            this.tpDetalles.Controls.Add(this.lblDescripcionArticulo);
            this.tpDetalles.Controls.Add(this.lblPrecioArticulo);
            this.tpDetalles.Controls.Add(this.lblCategoriaArticulo);
            this.tpDetalles.Controls.Add(this.lblMarcaArticulo);
            this.tpDetalles.Controls.Add(this.lblCodigoArticulo);
            this.tpDetalles.Controls.Add(this.lblNombreArticulo);
            this.tpDetalles.Controls.Add(this.pbImagenDetalles);
            this.tpDetalles.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpDetalles.Location = new System.Drawing.Point(4, 22);
            this.tpDetalles.Name = "tpDetalles";
            this.tpDetalles.Size = new System.Drawing.Size(740, 456);
            this.tpDetalles.TabIndex = 2;
            this.tpDetalles.Text = "Detalles";
            this.tpDetalles.UseVisualStyleBackColor = true;
            // 
            // lblDA
            // 
            this.lblDA.AutoSize = true;
            this.lblDA.Location = new System.Drawing.Point(87, 281);
            this.lblDA.Name = "lblDA";
            this.lblDA.Size = new System.Drawing.Size(38, 13);
            this.lblDA.TabIndex = 36;
            this.lblDA.Text = "label1";
            // 
            // lblDetallesAtras
            // 
            this.lblDetallesAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesAtras.Location = new System.Drawing.Point(8, 365);
            this.lblDetallesAtras.Name = "lblDetallesAtras";
            this.lblDetallesAtras.Size = new System.Drawing.Size(75, 23);
            this.lblDetallesAtras.TabIndex = 0;
            this.lblDetallesAtras.Text = "Atrás";
            this.lblDetallesAtras.UseVisualStyleBackColor = true;
            this.lblDetallesAtras.Click += new System.EventHandler(this.lblDetallesAtras_Click);
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Location = new System.Drawing.Point(302, 235);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(38, 13);
            this.lblDetallePrecio.TabIndex = 18;
            this.lblDetallePrecio.Text = "label4";
            // 
            // lblDetalleCategoria
            // 
            this.lblDetalleCategoria.AutoSize = true;
            this.lblDetalleCategoria.Location = new System.Drawing.Point(302, 193);
            this.lblDetalleCategoria.Name = "lblDetalleCategoria";
            this.lblDetalleCategoria.Size = new System.Drawing.Size(38, 13);
            this.lblDetalleCategoria.TabIndex = 17;
            this.lblDetalleCategoria.Text = "label3";
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Location = new System.Drawing.Point(302, 154);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(38, 13);
            this.lblDetalleMarca.TabIndex = 16;
            this.lblDetalleMarca.Text = "label2";
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(302, 115);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(38, 13);
            this.lblDetalleCodigo.TabIndex = 15;
            this.lblDetalleCodigo.Text = "label1";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(18, 281);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(73, 13);
            this.lblDescripcionArticulo.TabIndex = 14;
            this.lblDescripcionArticulo.Text = "Descripción: ";
            // 
            // lblPrecioArticulo
            // 
            this.lblPrecioArticulo.AutoSize = true;
            this.lblPrecioArticulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioArticulo.Location = new System.Drawing.Point(233, 235);
            this.lblPrecioArticulo.Name = "lblPrecioArticulo";
            this.lblPrecioArticulo.Size = new System.Drawing.Size(45, 13);
            this.lblPrecioArticulo.TabIndex = 13;
            this.lblPrecioArticulo.Text = "Precio: ";
            // 
            // lblCategoriaArticulo
            // 
            this.lblCategoriaArticulo.AutoSize = true;
            this.lblCategoriaArticulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaArticulo.Location = new System.Drawing.Point(233, 193);
            this.lblCategoriaArticulo.Name = "lblCategoriaArticulo";
            this.lblCategoriaArticulo.Size = new System.Drawing.Size(63, 13);
            this.lblCategoriaArticulo.TabIndex = 12;
            this.lblCategoriaArticulo.Text = "Categoria: ";
            // 
            // lblMarcaArticulo
            // 
            this.lblMarcaArticulo.AutoSize = true;
            this.lblMarcaArticulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaArticulo.Location = new System.Drawing.Point(233, 154);
            this.lblMarcaArticulo.Name = "lblMarcaArticulo";
            this.lblMarcaArticulo.Size = new System.Drawing.Size(45, 13);
            this.lblMarcaArticulo.TabIndex = 11;
            this.lblMarcaArticulo.Text = "Marca: ";
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.Location = new System.Drawing.Point(233, 115);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(51, 13);
            this.lblCodigoArticulo.TabIndex = 10;
            this.lblCodigoArticulo.Text = "Codigo: ";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArticulo.Location = new System.Drawing.Point(0, 36);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(112, 47);
            this.lblNombreArticulo.TabIndex = 9;
            this.lblNombreArticulo.Text = "label1";
            // 
            // pbImagenDetalles
            // 
            this.pbImagenDetalles.Location = new System.Drawing.Point(8, 86);
            this.pbImagenDetalles.Name = "pbImagenDetalles";
            this.pbImagenDetalles.Size = new System.Drawing.Size(219, 173);
            this.pbImagenDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenDetalles.TabIndex = 8;
            this.pbImagenDetalles.TabStop = false;
            // 
            // tpAgregar_Editar
            // 
            this.tpAgregar_Editar.Controls.Add(this.pbImagenAdd);
            this.tpAgregar_Editar.Controls.Add(this.lblImagenUrl);
            this.tpAgregar_Editar.Controls.Add(this.tbxImagenUrl);
            this.tpAgregar_Editar.Controls.Add(this.tbxPrecio);
            this.tpAgregar_Editar.Controls.Add(this.tbxDescripcion);
            this.tpAgregar_Editar.Controls.Add(this.tbxNombre);
            this.tpAgregar_Editar.Controls.Add(this.tbxCodigo);
            this.tpAgregar_Editar.Controls.Add(this.cbxCategoria);
            this.tpAgregar_Editar.Controls.Add(this.cbxMarca);
            this.tpAgregar_Editar.Controls.Add(this.btnSalir);
            this.tpAgregar_Editar.Controls.Add(this.btnAdd);
            this.tpAgregar_Editar.Controls.Add(this.lblPrecio);
            this.tpAgregar_Editar.Controls.Add(this.lblCategoria);
            this.tpAgregar_Editar.Controls.Add(this.lblMarca);
            this.tpAgregar_Editar.Controls.Add(this.lblDescripcion);
            this.tpAgregar_Editar.Controls.Add(this.lblNombre);
            this.tpAgregar_Editar.Controls.Add(this.lblCodigo);
            this.tpAgregar_Editar.Location = new System.Drawing.Point(4, 22);
            this.tpAgregar_Editar.Name = "tpAgregar_Editar";
            this.tpAgregar_Editar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAgregar_Editar.Size = new System.Drawing.Size(740, 456);
            this.tpAgregar_Editar.TabIndex = 1;
            this.tpAgregar_Editar.Text = "Agregar/Editar";
            this.tpAgregar_Editar.UseVisualStyleBackColor = true;
            // 
            // pbImagenAdd
            // 
            this.pbImagenAdd.Location = new System.Drawing.Point(8, 47);
            this.pbImagenAdd.Name = "pbImagenAdd";
            this.pbImagenAdd.Size = new System.Drawing.Size(265, 213);
            this.pbImagenAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenAdd.TabIndex = 34;
            this.pbImagenAdd.TabStop = false;
            // 
            // lblImagenUrl
            // 
            this.lblImagenUrl.AutoSize = true;
            this.lblImagenUrl.Location = new System.Drawing.Point(564, 96);
            this.lblImagenUrl.Name = "lblImagenUrl";
            this.lblImagenUrl.Size = new System.Drawing.Size(58, 13);
            this.lblImagenUrl.TabIndex = 33;
            this.lblImagenUrl.Text = "Imagen Url";
            // 
            // tbxImagenUrl
            // 
            this.tbxImagenUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxImagenUrl.Location = new System.Drawing.Point(565, 113);
            this.tbxImagenUrl.Name = "tbxImagenUrl";
            this.tbxImagenUrl.Size = new System.Drawing.Size(167, 20);
            this.tbxImagenUrl.TabIndex = 5;
            this.tbxImagenUrl.Leave += new System.EventHandler(this.tbxImagenUrl_Leave);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPrecio.Location = new System.Drawing.Point(565, 63);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(167, 20);
            this.tbxPrecio.TabIndex = 2;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDescripcion.Location = new System.Drawing.Point(288, 168);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(444, 20);
            this.tbxDescripcion.TabIndex = 6;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(427, 63);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(121, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(288, 63);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(121, 20);
            this.tbxCodigo.TabIndex = 0;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(427, 112);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 4;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(288, 112);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 21);
            this.cbxMarca.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(473, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(334, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Aceptar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(564, 47);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 29;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(424, 96);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 27;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(287, 96);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 24;
            this.lblMarca.Text = "Marca";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(287, 152);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 22;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(424, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(287, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // tcCatalogo
            // 
            this.tcCatalogo.BackColor = System.Drawing.Color.Transparent;
            this.tcCatalogo.Controls.Add(this.btnBusquedaAvanzada);
            this.tcCatalogo.Controls.Add(this.btnDetalles);
            this.tcCatalogo.Controls.Add(this.tbxBusqueda);
            this.tcCatalogo.Controls.Add(this.lblListaArticulos);
            this.tcCatalogo.Controls.Add(this.dgvDatos);
            this.tcCatalogo.Controls.Add(this.btnEditar);
            this.tcCatalogo.Controls.Add(this.btnEliminar);
            this.tcCatalogo.Controls.Add(this.btnAgregar);
            this.tcCatalogo.Location = new System.Drawing.Point(4, 22);
            this.tcCatalogo.Name = "tcCatalogo";
            this.tcCatalogo.Padding = new System.Windows.Forms.Padding(3);
            this.tcCatalogo.Size = new System.Drawing.Size(740, 456);
            this.tcCatalogo.TabIndex = 0;
            this.tcCatalogo.Text = "Lista Articulos";
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBusquedaAvanzada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(110)))), ((int)(((byte)(207)))));
            this.btnBusquedaAvanzada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(108)))));
            this.btnBusquedaAvanzada.FlatAppearance.BorderSize = 0;
            this.btnBusquedaAvanzada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(89)))), ((int)(((byte)(225)))));
            this.btnBusquedaAvanzada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(219)))));
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAvanzada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(104, 424);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(122, 26);
            this.btnBusquedaAvanzada.TabIndex = 5;
            this.btnBusquedaAvanzada.Text = "Búsqueda Avanzada";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.btnDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(180)))), ((int)(((byte)(50)))));
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(160)))), ((int)(((byte)(34)))));
            this.btnDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(190)))), ((int)(((byte)(86)))));
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDetalles.Location = new System.Drawing.Point(8, 424);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(90, 26);
            this.btnDetalles.TabIndex = 4;
            this.btnDetalles.Text = "Detalles";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // tbxBusqueda
            // 
            this.tbxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBusqueda.Location = new System.Drawing.Point(6, 56);
            this.tbxBusqueda.Name = "tbxBusqueda";
            this.tbxBusqueda.Size = new System.Drawing.Size(630, 20);
            this.tbxBusqueda.TabIndex = 0;
            this.tbxBusqueda.TextChanged += new System.EventHandler(this.tbxBusqueda_TextChanged);
            // 
            // lblListaArticulos
            // 
            this.lblListaArticulos.AutoSize = true;
            this.lblListaArticulos.Location = new System.Drawing.Point(8, 40);
            this.lblListaArticulos.Name = "lblListaArticulos";
            this.lblListaArticulos.Size = new System.Drawing.Size(86, 13);
            this.lblListaArticulos.TabIndex = 2;
            this.lblListaArticulos.Text = "Lista de articulos";
            // 
            // dgvDatos
            // 
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatos.Location = new System.Drawing.Point(8, 88);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 10;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(630, 330);
            this.dgvDatos.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(172)))), ((int)(((byte)(238)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(195)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(644, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(90, 26);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(644, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 26);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(108)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(178)))), ((int)(((byte)(108)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(178)))), ((int)(((byte)(108)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(644, 88);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 26);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tpCatalogo
            // 
            this.tpCatalogo.Controls.Add(this.tcCatalogo);
            this.tpCatalogo.Controls.Add(this.tpAgregar_Editar);
            this.tpCatalogo.Controls.Add(this.tpDetalles);
            this.tpCatalogo.Controls.Add(this.tpBusquedaAvanzada);
            this.tpCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpCatalogo.Location = new System.Drawing.Point(0, 0);
            this.tpCatalogo.Name = "tpCatalogo";
            this.tpCatalogo.SelectedIndex = 0;
            this.tpCatalogo.Size = new System.Drawing.Size(748, 482);
            this.tpCatalogo.TabIndex = 15;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 482);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.tpCatalogo);
            this.MinimumSize = new System.Drawing.Size(764, 511);
            this.Name = "FormInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.tpBusquedaAvanzada.ResumeLayout(false);
            this.tpBusquedaAvanzada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosFiltrados)).EndInit();
            this.tpDetalles.ResumeLayout(false);
            this.tpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenDetalles)).EndInit();
            this.tpAgregar_Editar.ResumeLayout(false);
            this.tpAgregar_Editar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenAdd)).EndInit();
            this.tcCatalogo.ResumeLayout(false);
            this.tcCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tpCatalogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tpBusquedaAvanzada;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.DataGridView dgvDatosFiltrados;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TabPage tpDetalles;
        private System.Windows.Forms.Button lblDetallesAtras;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Label lblDetalleCategoria;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblPrecioArticulo;
        private System.Windows.Forms.Label lblCategoriaArticulo;
        private System.Windows.Forms.Label lblMarcaArticulo;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.PictureBox pbImagenDetalles;
        private System.Windows.Forms.TabPage tpAgregar_Editar;
        private System.Windows.Forms.PictureBox pbImagenAdd;
        private System.Windows.Forms.Label lblImagenUrl;
        private System.Windows.Forms.TextBox tbxImagenUrl;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TabPage tcCatalogo;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.TextBox tbxBusqueda;
        private System.Windows.Forms.Label lblListaArticulos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabControl tpCatalogo;
        private System.Windows.Forms.Label lblDA;
    }
}

