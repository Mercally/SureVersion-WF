using SureVersion.Entities;
using SureVersion.Interfases;
using SureVersion.Util;
using SureVersion.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SureVersion.Forms
{
    public partial class Tests : Form
    {
        private XmlTest XMLTest { get; set; }
        private XmlProyect XMLProyect { get; set; }

        public Tests()
        {
            InitializeComponent();

            XMLTest = new XmlTest(new XmlUtil(DataGridTests));

            XMLProyect = new XmlProyect(new XmlUtil());

            XMLTest.UpdateDataGrid();

            UpdateListProyects();

            UpdateListEnverioments();

            UpdateListMethod();
        }

        private void UpdateListProyects()
        {
            FormUtil.Update_List(CmbxProyects, XMLProyect.GetListProyects());
        }

        private void UpdateListEnverioments()
        {
            FormUtil.Update_List(CmbxEnverioments, ConstantsUtil.Enverioments);
        }

        private void UpdateListMethod()
        {
            FormUtil.Update_List(CmbxVerb, ConstantsUtil.HttpMethods);
            CmbxVerb.SelectedIndex = 1;
        }

        private Test GetFormTest()
        {
            Test Proyect = null;

            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.", "No válido.");
                return null;
            }

            if (CmbxProyects.SelectedValue == null)
            {
                MessageBox.Show("Aun no ha seleccionado un proyecto.", "No válido.");
                return Proyect;
            }

            if (CmbxEnverioments.SelectedValue == null)
            {
                MessageBox.Show("Aun no ha seleccionado un ambiente.", "No válido.");
                return Proyect;
            }

            if (string.IsNullOrWhiteSpace(TxtUrl.Text))
            {
                MessageBox.Show("Debe ingresar un URL.", "No válido.");
                return Proyect;
            }

            if (CmbxVerb.SelectedValue == null)
            {
                MessageBox.Show("Aun no ha seleccionado un verbo http.", "No válido.");
                return Proyect;
            }

            Proyect = new Test(
                string.IsNullOrEmpty(TxtIdTest.Text) ? Guid.NewGuid().ToString() : TxtIdTest.Text,
                CmbxProyects.SelectedValue.ToString(),
                TxtName.Text,
                TxtUrl.Text,
                CmbxVerb.SelectedValue.ToString(),
                "",
                CmbxEnverioments.SelectedValue.ToString(),
                CheckVersion.Checked
            );

            return Proyect;
        }

        private void CleanForm()
        {
            FormUtil.CleanForm(GroupPrueba);

            BtnEliminar.Visible = !string.IsNullOrEmpty(TxtIdTest.Text);

            CmbxVerb.SelectedIndex = 1;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var Test = GetFormTest();

            if (Test != null)
            {
                if (string.IsNullOrEmpty(TxtIdTest.Text))
                {
                    XMLTest.Add(Test);
                }
                else
                {
                    XMLTest.Edit(Test);
                }
                CleanForm();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este elemento?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Id = TxtIdTest.Text;

                XMLTest.Remove(Id);

                CleanForm();
            }
        }

        private void BtnRefreshProyects_Click(object sender, EventArgs e)
        {
            UpdateListProyects();
        }

        private void DataGridTests_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != -1)
                return;

            string Id = DataGridTests.Rows[e.RowIndex].Cells["Id"].Value?.ToString();

            if (string.IsNullOrEmpty(Id))
                return;

            if (MessageBox.Show("¿Desea editar este elemento?", "Editar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Test Test = XMLTest.GetById(Id);

                if (Test != null)
                {
                    TxtIdTest.Text = Id;
                    TxtName.Text = Test.Name;
                    TxtUrl.Text = Test.Url;
                    CmbxEnverioments.SelectedValue = Test.Enverioment;
                    CmbxProyects.SelectedValue = Test.ProyectName.ToString();
                    CmbxVerb.SelectedValue = Test.Method;
                    CheckVersion.Checked = Test.IsVersion;
                }
            }

            BtnEliminar.Visible = !string.IsNullOrEmpty(TxtIdTest.Text);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Items[0].Enabled = DataGridTests.SelectedRows.Count > 0;
        }

        private void clonarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataGridTests.SelectedRows.Count > 0)
            {
                var Rows = DataGridTests.SelectedRows;

                for (int i = 0; i < Rows.Count; i++)
                {
                    XMLTest.Add(Test.GetTest(Rows[i]));
                }
            }
        }
    }
}
