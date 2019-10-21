namespace SureVersion.Forms
{
    partial class Exec
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
            this.TitleBar = new System.Windows.Forms.Panel();
            this.LblTitleForm = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupFiltro = new System.Windows.Forms.GroupBox();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnQuery = new System.Windows.Forms.Button();
            this.CmbxEnverioments = new System.Windows.Forms.ComboBox();
            this.CmbxProyects = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridPruebas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CheckSaveRecords = new System.Windows.Forms.CheckBox();
            this.BtnExecute = new System.Windows.Forms.Button();
            this.BtnRefreshProyects = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GroupFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPruebas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.LblTitleForm);
            this.TitleBar.Controls.Add(this.BtnClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(984, 37);
            this.TitleBar.TabIndex = 5;
            // 
            // LblTitleForm
            // 
            this.LblTitleForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitleForm.AutoSize = true;
            this.LblTitleForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleForm.Location = new System.Drawing.Point(819, 5);
            this.LblTitleForm.Name = "LblTitleForm";
            this.LblTitleForm.Size = new System.Drawing.Size(116, 25);
            this.LblTitleForm.TabIndex = 0;
            this.LblTitleForm.Text = "EJECUCION";
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
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 118);
            this.panel1.TabIndex = 6;
            // 
            // GroupFiltro
            // 
            this.GroupFiltro.Controls.Add(this.BtnRefreshProyects);
            this.GroupFiltro.Controls.Add(this.BtnClean);
            this.GroupFiltro.Controls.Add(this.BtnQuery);
            this.GroupFiltro.Controls.Add(this.CmbxEnverioments);
            this.GroupFiltro.Controls.Add(this.CmbxProyects);
            this.GroupFiltro.Controls.Add(this.label2);
            this.GroupFiltro.Controls.Add(this.label1);
            this.GroupFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupFiltro.Location = new System.Drawing.Point(0, 0);
            this.GroupFiltro.Name = "GroupFiltro";
            this.GroupFiltro.Size = new System.Drawing.Size(984, 118);
            this.GroupFiltro.TabIndex = 0;
            this.GroupFiltro.TabStop = false;
            this.GroupFiltro.Text = "Filtro";
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(93, 89);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 23);
            this.BtnClean.TabIndex = 6;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnQuery
            // 
            this.BtnQuery.Location = new System.Drawing.Point(12, 89);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(75, 23);
            this.BtnQuery.TabIndex = 5;
            this.BtnQuery.Text = "Consultar";
            this.BtnQuery.UseVisualStyleBackColor = true;
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // CmbxEnverioments
            // 
            this.CmbxEnverioments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbxEnverioments.FormattingEnabled = true;
            this.CmbxEnverioments.Location = new System.Drawing.Point(71, 55);
            this.CmbxEnverioments.Name = "CmbxEnverioments";
            this.CmbxEnverioments.Size = new System.Drawing.Size(864, 21);
            this.CmbxEnverioments.TabIndex = 4;
            // 
            // CmbxProyects
            // 
            this.CmbxProyects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbxProyects.FormattingEnabled = true;
            this.CmbxProyects.Location = new System.Drawing.Point(71, 27);
            this.CmbxProyects.Name = "CmbxProyects";
            this.CmbxProyects.Size = new System.Drawing.Size(791, 21);
            this.CmbxProyects.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ambiente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proyecto:";
            // 
            // DataGridPruebas
            // 
            this.DataGridPruebas.AllowUserToAddRows = false;
            this.DataGridPruebas.AllowUserToDeleteRows = false;
            this.DataGridPruebas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPruebas.Location = new System.Drawing.Point(0, 155);
            this.DataGridPruebas.Name = "DataGridPruebas";
            this.DataGridPruebas.ReadOnly = true;
            this.DataGridPruebas.Size = new System.Drawing.Size(984, 326);
            this.DataGridPruebas.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CheckSaveRecords);
            this.panel2.Controls.Add(this.BtnExecute);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 31);
            this.panel2.TabIndex = 8;
            // 
            // CheckSaveRecords
            // 
            this.CheckSaveRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckSaveRecords.AutoSize = true;
            this.CheckSaveRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckSaveRecords.Location = new System.Drawing.Point(773, 7);
            this.CheckSaveRecords.Name = "CheckSaveRecords";
            this.CheckSaveRecords.Size = new System.Drawing.Size(110, 17);
            this.CheckSaveRecords.TabIndex = 1;
            this.CheckSaveRecords.Text = "Guardar resultado";
            this.CheckSaveRecords.UseVisualStyleBackColor = true;
            // 
            // BtnExecute
            // 
            this.BtnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExecute.Location = new System.Drawing.Point(906, 3);
            this.BtnExecute.Name = "BtnExecute";
            this.BtnExecute.Size = new System.Drawing.Size(75, 23);
            this.BtnExecute.TabIndex = 0;
            this.BtnExecute.Text = "Ejecutar";
            this.BtnExecute.UseVisualStyleBackColor = true;
            this.BtnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
            // 
            // BtnRefreshProyects
            // 
            this.BtnRefreshProyects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefreshProyects.Location = new System.Drawing.Point(868, 25);
            this.BtnRefreshProyects.Name = "BtnRefreshProyects";
            this.BtnRefreshProyects.Size = new System.Drawing.Size(67, 23);
            this.BtnRefreshProyects.TabIndex = 9;
            this.BtnRefreshProyects.Text = "Recargar";
            this.BtnRefreshProyects.UseVisualStyleBackColor = true;
            this.BtnRefreshProyects.Click += new System.EventHandler(this.BtnRefreshProyects_Click);
            // 
            // Exec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridPruebas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleBar);
            this.Name = "Exec";
            this.Text = "Exec";
            this.Load += new System.EventHandler(this.Exec_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.GroupFiltro.ResumeLayout(false);
            this.GroupFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPruebas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label LblTitleForm;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GroupFiltro;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnQuery;
        private System.Windows.Forms.ComboBox CmbxEnverioments;
        private System.Windows.Forms.ComboBox CmbxProyects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridPruebas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox CheckSaveRecords;
        private System.Windows.Forms.Button BtnExecute;
        private System.Windows.Forms.Button BtnRefreshProyects;
    }
}