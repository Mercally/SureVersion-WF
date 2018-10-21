namespace SureVersion.Forms
{
    partial class Proyects
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
            this.LblTitleForm = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.GroupNewProyect = new System.Windows.Forms.GroupBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtIdProyecto = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtResponsable = new System.Windows.Forms.TextBox();
            this.TxtClienteNuevo = new System.Windows.Forms.TextBox();
            this.LblClienteNuevo = new System.Windows.Forms.Label();
            this.TxtNombreNuevo = new System.Windows.Forms.TextBox();
            this.LblNombreNuevo = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.PanelNew = new System.Windows.Forms.Panel();
            this.PanelGrid = new System.Windows.Forms.Panel();
            this.GridProyects = new System.Windows.Forms.DataGridView();
            this.GroupNewProyect.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.PanelNew.SuspendLayout();
            this.PanelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProyects)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitleForm
            // 
            this.LblTitleForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitleForm.AutoSize = true;
            this.LblTitleForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleForm.Location = new System.Drawing.Point(813, 5);
            this.LblTitleForm.Name = "LblTitleForm";
            this.LblTitleForm.Size = new System.Drawing.Size(122, 25);
            this.LblTitleForm.TabIndex = 0;
            this.LblTitleForm.Text = "PROYECTOS";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Tomato;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnClose.Location = new System.Drawing.Point(941, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 27);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnCloseProyects_Click);
            // 
            // GroupNewProyect
            // 
            this.GroupNewProyect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupNewProyect.Controls.Add(this.BtnEliminar);
            this.GroupNewProyect.Controls.Add(this.TxtIdProyecto);
            this.GroupNewProyect.Controls.Add(this.BtnNuevo);
            this.GroupNewProyect.Controls.Add(this.BtnAgregar);
            this.GroupNewProyect.Controls.Add(this.label1);
            this.GroupNewProyect.Controls.Add(this.TxtResponsable);
            this.GroupNewProyect.Controls.Add(this.TxtClienteNuevo);
            this.GroupNewProyect.Controls.Add(this.LblClienteNuevo);
            this.GroupNewProyect.Controls.Add(this.TxtNombreNuevo);
            this.GroupNewProyect.Controls.Add(this.LblNombreNuevo);
            this.GroupNewProyect.Location = new System.Drawing.Point(0, 5);
            this.GroupNewProyect.Name = "GroupNewProyect";
            this.GroupNewProyect.Size = new System.Drawing.Size(984, 146);
            this.GroupNewProyect.TabIndex = 2;
            this.GroupNewProyect.TabStop = false;
            this.GroupNewProyect.Text = "Proyecto";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(900, 117);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 6;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Visible = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtIdProyecto
            // 
            this.TxtIdProyecto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtIdProyecto.Location = new System.Drawing.Point(822, 107);
            this.TxtIdProyecto.Name = "TxtIdProyecto";
            this.TxtIdProyecto.Size = new System.Drawing.Size(153, 20);
            this.TxtIdProyecto.TabIndex = 4;
            this.TxtIdProyecto.Visible = false;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(91, 117);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 5;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(10, 117);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Guardar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Responsable:";
            // 
            // TxtResponsable
            // 
            this.TxtResponsable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtResponsable.Location = new System.Drawing.Point(91, 81);
            this.TxtResponsable.Name = "TxtResponsable";
            this.TxtResponsable.Size = new System.Drawing.Size(884, 20);
            this.TxtResponsable.TabIndex = 3;
            // 
            // TxtClienteNuevo
            // 
            this.TxtClienteNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtClienteNuevo.Location = new System.Drawing.Point(67, 55);
            this.TxtClienteNuevo.Name = "TxtClienteNuevo";
            this.TxtClienteNuevo.Size = new System.Drawing.Size(908, 20);
            this.TxtClienteNuevo.TabIndex = 2;
            // 
            // LblClienteNuevo
            // 
            this.LblClienteNuevo.AutoSize = true;
            this.LblClienteNuevo.Location = new System.Drawing.Point(13, 55);
            this.LblClienteNuevo.Name = "LblClienteNuevo";
            this.LblClienteNuevo.Size = new System.Drawing.Size(42, 13);
            this.LblClienteNuevo.TabIndex = 0;
            this.LblClienteNuevo.Text = "Cliente:";
            // 
            // TxtNombreNuevo
            // 
            this.TxtNombreNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNombreNuevo.Location = new System.Drawing.Point(67, 29);
            this.TxtNombreNuevo.Name = "TxtNombreNuevo";
            this.TxtNombreNuevo.Size = new System.Drawing.Size(908, 20);
            this.TxtNombreNuevo.TabIndex = 1;
            // 
            // LblNombreNuevo
            // 
            this.LblNombreNuevo.AutoSize = true;
            this.LblNombreNuevo.Location = new System.Drawing.Point(13, 29);
            this.LblNombreNuevo.Name = "LblNombreNuevo";
            this.LblNombreNuevo.Size = new System.Drawing.Size(47, 13);
            this.LblNombreNuevo.TabIndex = 0;
            this.LblNombreNuevo.Text = "Nombre:";
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.LblTitleForm);
            this.TitleBar.Controls.Add(this.BtnClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(984, 37);
            this.TitleBar.TabIndex = 3;
            // 
            // PanelNew
            // 
            this.PanelNew.Controls.Add(this.GroupNewProyect);
            this.PanelNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNew.Location = new System.Drawing.Point(0, 37);
            this.PanelNew.Name = "PanelNew";
            this.PanelNew.Size = new System.Drawing.Size(984, 155);
            this.PanelNew.TabIndex = 4;
            // 
            // PanelGrid
            // 
            this.PanelGrid.Controls.Add(this.GridProyects);
            this.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGrid.Location = new System.Drawing.Point(0, 192);
            this.PanelGrid.Name = "PanelGrid";
            this.PanelGrid.Size = new System.Drawing.Size(984, 319);
            this.PanelGrid.TabIndex = 5;
            // 
            // GridProyects
            // 
            this.GridProyects.AllowUserToAddRows = false;
            this.GridProyects.AllowUserToDeleteRows = false;
            this.GridProyects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProyects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProyects.Location = new System.Drawing.Point(0, 0);
            this.GridProyects.Name = "GridProyects";
            this.GridProyects.ReadOnly = true;
            this.GridProyects.Size = new System.Drawing.Size(984, 319);
            this.GridProyects.TabIndex = 0;
            this.GridProyects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridProyects_CellMouseDoubleClick);
            // 
            // Proyects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.PanelGrid);
            this.Controls.Add(this.PanelNew);
            this.Controls.Add(this.TitleBar);
            this.Name = "Proyects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyects";
            this.GroupNewProyect.ResumeLayout(false);
            this.GroupNewProyect.PerformLayout();
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.PanelNew.ResumeLayout(false);
            this.PanelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProyects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitleForm;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.GroupBox GroupNewProyect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtResponsable;
        private System.Windows.Forms.TextBox TxtClienteNuevo;
        private System.Windows.Forms.Label LblClienteNuevo;
        private System.Windows.Forms.TextBox TxtNombreNuevo;
        private System.Windows.Forms.Label LblNombreNuevo;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel PanelNew;
        private System.Windows.Forms.Panel PanelGrid;
        private System.Windows.Forms.DataGridView GridProyects;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TxtIdProyecto;
        private System.Windows.Forms.Button BtnEliminar;
    }
}