namespace SureVersion.Forms
{
    partial class Home
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
            this.Panel0 = new System.Windows.Forms.Panel();
            this.LblStatusText = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.BtnExec = new System.Windows.Forms.Button();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnProyects = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BtnCloseForm = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.Panel0.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel0
            // 
            this.Panel0.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel0.Controls.Add(this.LblStatusText);
            this.Panel0.Controls.Add(this.LblStatus);
            this.Panel0.Controls.Add(this.BtnExec);
            this.Panel0.Controls.Add(this.BtnTest);
            this.Panel0.Controls.Add(this.BtnProyects);
            this.Panel0.Controls.Add(this.Panel1);
            this.Panel0.Controls.Add(this.BarraTitulo);
            this.Panel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel0.Location = new System.Drawing.Point(0, 0);
            this.Panel0.Name = "Panel0";
            this.Panel0.Size = new System.Drawing.Size(1000, 550);
            this.Panel0.TabIndex = 0;
            // 
            // LblStatusText
            // 
            this.LblStatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblStatusText.AutoSize = true;
            this.LblStatusText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblStatusText.Location = new System.Drawing.Point(42, 534);
            this.LblStatusText.Name = "LblStatusText";
            this.LblStatusText.Size = new System.Drawing.Size(24, 16);
            this.LblStatusText.TabIndex = 5;
            this.LblStatusText.Text = "OK";
            // 
            // LblStatus
            // 
            this.LblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblStatus.Location = new System.Drawing.Point(4, 533);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(43, 16);
            this.LblStatus.TabIndex = 4;
            this.LblStatus.Text = "Status:";
            // 
            // BtnExec
            // 
            this.BtnExec.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExec.Location = new System.Drawing.Point(157, 32);
            this.BtnExec.Name = "BtnExec";
            this.BtnExec.Size = new System.Drawing.Size(75, 30);
            this.BtnExec.TabIndex = 3;
            this.BtnExec.Text = "Execute";
            this.BtnExec.UseVisualStyleBackColor = true;
            this.BtnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTest.Location = new System.Drawing.Point(80, 32);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 30);
            this.BtnTest.TabIndex = 3;
            this.BtnTest.Text = "Tests";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnProyects
            // 
            this.BtnProyects.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProyects.Location = new System.Drawing.Point(3, 32);
            this.BtnProyects.Name = "BtnProyects";
            this.BtnProyects.Size = new System.Drawing.Size(75, 30);
            this.BtnProyects.TabIndex = 2;
            this.BtnProyects.Text = "Proyects";
            this.BtnProyects.UseVisualStyleBackColor = true;
            this.BtnProyects.Click += new System.EventHandler(this.BtnProyects_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Panel1.Location = new System.Drawing.Point(0, 65);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1000, 462);
            this.Panel1.TabIndex = 1;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.ControlText;
            this.BarraTitulo.Controls.Add(this.BtnCloseForm);
            this.BarraTitulo.Controls.Add(this.LblTitle);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1000, 30);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            // 
            // BtnCloseForm
            // 
            this.BtnCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseForm.BackColor = System.Drawing.Color.Tomato;
            this.BtnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCloseForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCloseForm.Location = new System.Drawing.Point(957, 2);
            this.BtnCloseForm.Name = "BtnCloseForm";
            this.BtnCloseForm.Size = new System.Drawing.Size(40, 27);
            this.BtnCloseForm.TabIndex = 3;
            this.BtnCloseForm.Text = "X";
            this.BtnCloseForm.UseVisualStyleBackColor = false;
            this.BtnCloseForm.Click += new System.EventHandler(this.BtnCloseForm_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTitle.Location = new System.Drawing.Point(3, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(112, 20);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "SureVersion 1.0";
            this.LblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblTitle_MouseMove);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.Panel0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Panel0.ResumeLayout(false);
            this.Panel0.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel0;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Button BtnProyects;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblStatusText;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnCloseForm;
        private System.Windows.Forms.Button BtnExec;
    }
}