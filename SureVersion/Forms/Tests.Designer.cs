namespace SureVersion.Forms
{
    partial class Tests
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
            this.components = new System.ComponentModel.Container();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.LblTitleForm = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblSlctProyect = new System.Windows.Forms.Label();
            this.CmbxProyects = new System.Windows.Forms.ComboBox();
            this.LblScope = new System.Windows.Forms.Label();
            this.CmbxEnverioments = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GroupPrueba = new System.Windows.Forms.GroupBox();
            this.CheckVersion = new System.Windows.Forms.CheckBox();
            this.BtnRefreshProyects = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TxtIdTest = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbxVerb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridTests = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clonarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleBar.SuspendLayout();
            this.GroupPrueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTests)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.TitleBar.TabIndex = 4;
            // 
            // LblTitleForm
            // 
            this.LblTitleForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitleForm.AutoSize = true;
            this.LblTitleForm.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleForm.Location = new System.Drawing.Point(839, 5);
            this.LblTitleForm.Name = "LblTitleForm";
            this.LblTitleForm.Size = new System.Drawing.Size(96, 25);
            this.LblTitleForm.TabIndex = 0;
            this.LblTitleForm.Text = "PRUEBAS";
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
            // LblSlctProyect
            // 
            this.LblSlctProyect.AutoSize = true;
            this.LblSlctProyect.Location = new System.Drawing.Point(12, 59);
            this.LblSlctProyect.Name = "LblSlctProyect";
            this.LblSlctProyect.Size = new System.Drawing.Size(56, 13);
            this.LblSlctProyect.TabIndex = 5;
            this.LblSlctProyect.Text = "Proyecto*:";
            // 
            // CmbxProyects
            // 
            this.CmbxProyects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbxProyects.FormattingEnabled = true;
            this.CmbxProyects.Location = new System.Drawing.Point(75, 56);
            this.CmbxProyects.Name = "CmbxProyects";
            this.CmbxProyects.Size = new System.Drawing.Size(824, 21);
            this.CmbxProyects.TabIndex = 2;
            // 
            // LblScope
            // 
            this.LblScope.AutoSize = true;
            this.LblScope.Location = new System.Drawing.Point(12, 88);
            this.LblScope.Name = "LblScope";
            this.LblScope.Size = new System.Drawing.Size(58, 13);
            this.LblScope.TabIndex = 7;
            this.LblScope.Text = "Ambiente*:";
            // 
            // CmbxEnverioments
            // 
            this.CmbxEnverioments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbxEnverioments.FormattingEnabled = true;
            this.CmbxEnverioments.Location = new System.Drawing.Point(75, 86);
            this.CmbxEnverioments.Name = "CmbxEnverioments";
            this.CmbxEnverioments.Size = new System.Drawing.Size(781, 21);
            this.CmbxEnverioments.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(15, 186);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(96, 186);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 7;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GroupPrueba
            // 
            this.GroupPrueba.Controls.Add(this.CheckVersion);
            this.GroupPrueba.Controls.Add(this.BtnRefreshProyects);
            this.GroupPrueba.Controls.Add(this.BtnEliminar);
            this.GroupPrueba.Controls.Add(this.TxtIdTest);
            this.GroupPrueba.Controls.Add(this.TxtName);
            this.GroupPrueba.Controls.Add(this.label3);
            this.GroupPrueba.Controls.Add(this.CmbxVerb);
            this.GroupPrueba.Controls.Add(this.label2);
            this.GroupPrueba.Controls.Add(this.TxtUrl);
            this.GroupPrueba.Controls.Add(this.label1);
            this.GroupPrueba.Controls.Add(this.BtnSave);
            this.GroupPrueba.Controls.Add(this.BtnNuevo);
            this.GroupPrueba.Controls.Add(this.LblSlctProyect);
            this.GroupPrueba.Controls.Add(this.CmbxProyects);
            this.GroupPrueba.Controls.Add(this.CmbxEnverioments);
            this.GroupPrueba.Controls.Add(this.LblScope);
            this.GroupPrueba.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupPrueba.Location = new System.Drawing.Point(0, 37);
            this.GroupPrueba.Name = "GroupPrueba";
            this.GroupPrueba.Size = new System.Drawing.Size(984, 216);
            this.GroupPrueba.TabIndex = 11;
            this.GroupPrueba.TabStop = false;
            this.GroupPrueba.Text = "Prueba";
            // 
            // CheckVersion
            // 
            this.CheckVersion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CheckVersion.AutoSize = true;
            this.CheckVersion.Location = new System.Drawing.Point(914, 88);
            this.CheckVersion.Name = "CheckVersion";
            this.CheckVersion.Size = new System.Drawing.Size(61, 17);
            this.CheckVersion.TabIndex = 18;
            this.CheckVersion.Text = "Version";
            this.CheckVersion.UseVisualStyleBackColor = true;
            // 
            // BtnRefreshProyects
            // 
            this.BtnRefreshProyects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefreshProyects.Location = new System.Drawing.Point(905, 55);
            this.BtnRefreshProyects.Name = "BtnRefreshProyects";
            this.BtnRefreshProyects.Size = new System.Drawing.Size(67, 23);
            this.BtnRefreshProyects.TabIndex = 8;
            this.BtnRefreshProyects.Text = "Recargar";
            this.BtnRefreshProyects.UseVisualStyleBackColor = true;
            this.BtnRefreshProyects.Click += new System.EventHandler(this.BtnRefreshProyects_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.Location = new System.Drawing.Point(900, 186);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // TxtIdTest
            // 
            this.TxtIdTest.Location = new System.Drawing.Point(861, 146);
            this.TxtIdTest.Name = "TxtIdTest";
            this.TxtIdTest.Size = new System.Drawing.Size(116, 20);
            this.TxtIdTest.TabIndex = 17;
            this.TxtIdTest.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtName.Location = new System.Drawing.Point(75, 30);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(900, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre*:";
            // 
            // CmbxVerb
            // 
            this.CmbxVerb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbxVerb.FormattingEnabled = true;
            this.CmbxVerb.Location = new System.Drawing.Point(88, 145);
            this.CmbxVerb.Name = "CmbxVerb";
            this.CmbxVerb.Size = new System.Drawing.Size(767, 21);
            this.CmbxVerb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Verbo HTTP*:";
            // 
            // TxtUrl
            // 
            this.TxtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUrl.Location = new System.Drawing.Point(75, 113);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(900, 20);
            this.TxtUrl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Url*:";
            // 
            // DataGridTests
            // 
            this.DataGridTests.AllowUserToAddRows = false;
            this.DataGridTests.AllowUserToDeleteRows = false;
            this.DataGridTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTests.ContextMenuStrip = this.contextMenuStrip1;
            this.DataGridTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridTests.Location = new System.Drawing.Point(0, 253);
            this.DataGridTests.Name = "DataGridTests";
            this.DataGridTests.ReadOnly = true;
            this.DataGridTests.Size = new System.Drawing.Size(984, 258);
            this.DataGridTests.TabIndex = 12;
            this.DataGridTests.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridTests_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clonarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // clonarToolStripMenuItem
            // 
            this.clonarToolStripMenuItem.Name = "clonarToolStripMenuItem";
            this.clonarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.clonarToolStripMenuItem.Text = "Clonar";
            this.clonarToolStripMenuItem.Click += new System.EventHandler(this.clonarToolStripMenuItem_Click);
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.DataGridTests);
            this.Controls.Add(this.GroupPrueba);
            this.Controls.Add(this.TitleBar);
            this.Name = "Tests";
            this.Text = "Tests";
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.GroupPrueba.ResumeLayout(false);
            this.GroupPrueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTests)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label LblTitleForm;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblSlctProyect;
        private System.Windows.Forms.ComboBox CmbxProyects;
        private System.Windows.Forms.Label LblScope;
        private System.Windows.Forms.ComboBox CmbxEnverioments;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GroupPrueba;
        private System.Windows.Forms.ComboBox CmbxVerb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.TextBox TxtIdTest;
        private System.Windows.Forms.DataGridView DataGridTests;
        private System.Windows.Forms.Button BtnRefreshProyects;
        private System.Windows.Forms.CheckBox CheckVersion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clonarToolStripMenuItem;
    }
}