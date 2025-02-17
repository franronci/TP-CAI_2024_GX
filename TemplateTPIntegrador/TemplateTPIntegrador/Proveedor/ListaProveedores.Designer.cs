﻿
namespace TemplateTPIntegrador.Proveedor
{
    partial class ListaProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BuscarProveedor_Label = new System.Windows.Forms.Label();
            this.BuscarPorCUIT_Label = new System.Windows.Forms.Label();
            this.ProveedoresBuscador = new System.Windows.Forms.TextBox();
            this.CUITBuscador = new System.Windows.Forms.TextBox();
            this.ProveedoresLupa = new System.Windows.Forms.PictureBox();
            this.CUITLupa = new System.Windows.Forms.PictureBox();
            this.Proveedores = new System.Windows.Forms.DataGridView();
            this.BotonAltaProveedores = new System.Windows.Forms.Button();
            this.Boton_BorrarFiltro = new System.Windows.Forms.Button();
            this.Boton_Modificar = new System.Windows.Forms.Button();
            this.Boton_Eliminar = new System.Windows.Forms.Button();
            this.Boton_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUITLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarProveedor_Label
            // 
            this.BuscarProveedor_Label.AutoSize = true;
            this.BuscarProveedor_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProveedor_Label.Location = new System.Drawing.Point(12, 30);
            this.BuscarProveedor_Label.Name = "BuscarProveedor_Label";
            this.BuscarProveedor_Label.Size = new System.Drawing.Size(206, 29);
            this.BuscarProveedor_Label.TabIndex = 0;
            this.BuscarProveedor_Label.Text = "Buscar Proveedor";
            // 
            // BuscarPorCUIT_Label
            // 
            this.BuscarPorCUIT_Label.AutoSize = true;
            this.BuscarPorCUIT_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPorCUIT_Label.Location = new System.Drawing.Point(450, 30);
            this.BuscarPorCUIT_Label.Name = "BuscarPorCUIT_Label";
            this.BuscarPorCUIT_Label.Size = new System.Drawing.Size(191, 29);
            this.BuscarPorCUIT_Label.TabIndex = 1;
            this.BuscarPorCUIT_Label.Text = "Buscar por CUIT";
            // 
            // ProveedoresBuscador
            // 
            this.ProveedoresBuscador.Location = new System.Drawing.Point(224, 39);
            this.ProveedoresBuscador.Name = "ProveedoresBuscador";
            this.ProveedoresBuscador.Size = new System.Drawing.Size(144, 20);
            this.ProveedoresBuscador.TabIndex = 2;
            // 
            // CUITBuscador
            // 
            this.CUITBuscador.Location = new System.Drawing.Point(647, 39);
            this.CUITBuscador.Name = "CUITBuscador";
            this.CUITBuscador.Size = new System.Drawing.Size(144, 20);
            this.CUITBuscador.TabIndex = 3;
            this.CUITBuscador.TextChanged += new System.EventHandler(this.CUITBuscador_TextChanged);
            // 
            // ProveedoresLupa
            // 
            this.ProveedoresLupa.BackColor = System.Drawing.Color.White;
            this.ProveedoresLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProveedoresLupa.Image = global::TemplateTPIntegrador.Properties.Resources._64673;
            this.ProveedoresLupa.Location = new System.Drawing.Point(383, 31);
            this.ProveedoresLupa.Name = "ProveedoresLupa";
            this.ProveedoresLupa.Size = new System.Drawing.Size(33, 29);
            this.ProveedoresLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProveedoresLupa.TabIndex = 4;
            this.ProveedoresLupa.TabStop = false;
            this.ProveedoresLupa.Click += new System.EventHandler(this.ProveedoresLupa_Click_1);
            // 
            // CUITLupa
            // 
            this.CUITLupa.BackColor = System.Drawing.Color.White;
            this.CUITLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CUITLupa.Image = global::TemplateTPIntegrador.Properties.Resources._64673;
            this.CUITLupa.Location = new System.Drawing.Point(797, 31);
            this.CUITLupa.Name = "CUITLupa";
            this.CUITLupa.Size = new System.Drawing.Size(33, 29);
            this.CUITLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CUITLupa.TabIndex = 5;
            this.CUITLupa.TabStop = false;
            this.CUITLupa.Click += new System.EventHandler(this.CUITLupa_Click_1);
            // 
            // Proveedores
            // 
            this.Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Proveedores.Location = new System.Drawing.Point(17, 84);
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(969, 408);
            this.Proveedores.TabIndex = 6;
            // 
            // BotonAltaProveedores
            // 
            this.BotonAltaProveedores.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BotonAltaProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAltaProveedores.Location = new System.Drawing.Point(896, 24);
            this.BotonAltaProveedores.Name = "BotonAltaProveedores";
            this.BotonAltaProveedores.Size = new System.Drawing.Size(90, 36);
            this.BotonAltaProveedores.TabIndex = 7;
            this.BotonAltaProveedores.Text = "Crear";
            this.BotonAltaProveedores.UseVisualStyleBackColor = false;
            this.BotonAltaProveedores.Click += new System.EventHandler(this.BotonAltaProveedores_Click_1);
            // 
            // Boton_BorrarFiltro
            // 
            this.Boton_BorrarFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_BorrarFiltro.Location = new System.Drawing.Point(17, 513);
            this.Boton_BorrarFiltro.Name = "Boton_BorrarFiltro";
            this.Boton_BorrarFiltro.Size = new System.Drawing.Size(128, 37);
            this.Boton_BorrarFiltro.TabIndex = 8;
            this.Boton_BorrarFiltro.Text = "Borrar Filtro";
            this.Boton_BorrarFiltro.UseVisualStyleBackColor = true;
            this.Boton_BorrarFiltro.Click += new System.EventHandler(this.Boton_BorrarFiltro_Click_1);
            // 
            // Boton_Modificar
            // 
            this.Boton_Modificar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Boton_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Modificar.Location = new System.Drawing.Point(354, 513);
            this.Boton_Modificar.Name = "Boton_Modificar";
            this.Boton_Modificar.Size = new System.Drawing.Size(128, 37);
            this.Boton_Modificar.TabIndex = 9;
            this.Boton_Modificar.Text = "Modificar";
            this.Boton_Modificar.UseVisualStyleBackColor = false;
            this.Boton_Modificar.Click += new System.EventHandler(this.Boton_Modificar_Click_1);
            // 
            // Boton_Eliminar
            // 
            this.Boton_Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Boton_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Boton_Eliminar.Location = new System.Drawing.Point(497, 513);
            this.Boton_Eliminar.Name = "Boton_Eliminar";
            this.Boton_Eliminar.Size = new System.Drawing.Size(128, 37);
            this.Boton_Eliminar.TabIndex = 10;
            this.Boton_Eliminar.Text = "Eliminar";
            this.Boton_Eliminar.UseVisualStyleBackColor = false;
            this.Boton_Eliminar.Click += new System.EventHandler(this.Boton_Eliminar_Click_1);
            // 
            // Boton_Salir
            // 
            this.Boton_Salir.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Boton_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_Salir.Location = new System.Drawing.Point(858, 513);
            this.Boton_Salir.Name = "Boton_Salir";
            this.Boton_Salir.Size = new System.Drawing.Size(128, 37);
            this.Boton_Salir.TabIndex = 11;
            this.Boton_Salir.Text = "Salir";
            this.Boton_Salir.UseVisualStyleBackColor = false;
            this.Boton_Salir.Click += new System.EventHandler(this.Boton_Salir_Click_1);
            // 
            // ListaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 579);
            this.Controls.Add(this.Boton_Salir);
            this.Controls.Add(this.Boton_Eliminar);
            this.Controls.Add(this.Boton_Modificar);
            this.Controls.Add(this.Boton_BorrarFiltro);
            this.Controls.Add(this.BotonAltaProveedores);
            this.Controls.Add(this.Proveedores);
            this.Controls.Add(this.CUITLupa);
            this.Controls.Add(this.ProveedoresLupa);
            this.Controls.Add(this.CUITBuscador);
            this.Controls.Add(this.ProveedoresBuscador);
            this.Controls.Add(this.BuscarPorCUIT_Label);
            this.Controls.Add(this.BuscarProveedor_Label);
            this.Name = "ListaProveedores";
            this.Text = "ListaProveedores";
            this.Load += new System.EventHandler(this.ListaProveedores_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUITLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuscarProveedor_Label;
        private System.Windows.Forms.Label BuscarPorCUIT_Label;
        private System.Windows.Forms.TextBox ProveedoresBuscador;
        private System.Windows.Forms.TextBox CUITBuscador;
        private System.Windows.Forms.PictureBox ProveedoresLupa;
        private System.Windows.Forms.PictureBox CUITLupa;
        private System.Windows.Forms.DataGridView Proveedores;
        private System.Windows.Forms.Button BotonAltaProveedores;
        private System.Windows.Forms.Button Boton_BorrarFiltro;
        private System.Windows.Forms.Button Boton_Modificar;
        private System.Windows.Forms.Button Boton_Eliminar;
        private System.Windows.Forms.Button Boton_Salir;
    }
}