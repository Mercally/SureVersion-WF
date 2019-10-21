using System;
using System.Windows.Forms;
using SureVersion.Util;
using SureVersion.Entities;
using SureVersion.Xml;
using SureVersion.Interfases;
using System.Linq;

namespace SureVersion.Forms
{
    public partial class Proyects : Form
    {
        private IXmlBase<Proyect> XmlProyect { get; set; }

        public Proyects()
        {
            InitializeComponent();

            XmlProyect = new XmlProyect(new XmlUtil(GridProyects));

            XmlProyect.UpdateDataGrid();
        }

        private void BtnCloseProyects_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            FormUtil.CleanForm(GroupNewProyect);

            BtnEliminar.Visible = !string.IsNullOrEmpty(TxtIdProyecto.Text);

            FormUtil.SetFocusFirstInput(GroupNewProyect);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este elemento?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string Id = TxtIdProyecto.Text;

                XmlProyect.Remove(Id);

                CleanForm();
            }
        }

        private Proyect GetFormProyect()
        {
            if (string.IsNullOrWhiteSpace(TxtNombreNuevo.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de proyecto.", "No válido.");
                return null;
            }

            Proyect Proyect = new Proyect(
                string.IsNullOrEmpty(TxtIdProyecto.Text) ? Guid.NewGuid().ToString() : TxtIdProyecto.Text,
                TxtNombreNuevo.Text,
                TxtClienteNuevo.Text,
                TxtResponsable.Text
            );

            return Proyect;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var Proyect = GetFormProyect();

            if (Proyect != null)
            {
                if (string.IsNullOrEmpty(TxtIdProyecto.Text))
                    XmlProyect.Add(Proyect);
                else
                    XmlProyect.Edit(Proyect);

                CleanForm();
            }
        }

        private void GridProyects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != -1)
                return;

            string Id = GridProyects.Rows[e.RowIndex].Cells["Id"].Value?.ToString();

            if (string.IsNullOrEmpty(Id))
                return;

            if (MessageBox.Show("¿Desea editar este elemento?", "Editar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Proyect Proyect = XmlProyect.GetById(Id);

                if (Proyect != null)
                {
                    TxtIdProyecto.Text = Id;
                    TxtClienteNuevo.Text = Proyect.Customer;
                    TxtNombreNuevo.Text = Proyect.Name;
                    TxtResponsable.Text = Proyect.TechnicalLeader;

                    FormUtil.SetFocusFirstInput(GroupNewProyect);
                }
            }

            BtnEliminar.Visible = !string.IsNullOrEmpty(TxtIdProyecto.Text);
        }
    }
}
