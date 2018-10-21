using SureVersion.Entities;
using SureVersion.Util;
using SureVersion.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SureVersion.Forms
{
    public partial class Exec : Form
    {
        private XmlTest XMLTest { get; set; }
        private XmlProyect XMLProyect { get; set; }
        private XmlTestQuery XMLTestQuery { get; set; }

        public Exec()
        {
            InitializeComponent();

            XMLTest = new XmlTest(new XmlUtil());

            XMLProyect = new XmlProyect(new XmlUtil());

            XMLTestQuery = new XmlTestQuery(new XmlUtil(), DataGridPruebas);

            UpdateListProyects();

            UpdateListEnverioments();
        }

        private void UpdateListProyects()
        {
            FormUtil.Update_List(CmbxProyects, XMLProyect.GetListProyects());
        }

        private void UpdateListEnverioments()
        {
            FormUtil.Update_List(CmbxEnverioments, ConstantsUtil.Enverioments);
        }
        private void CleanForm()
        {
            FormUtil.CleanForm(GroupFiltro);
            XMLTestQuery.CleanGrid();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            if (CmbxProyects.SelectedValue == null && CmbxEnverioments.SelectedValue == null)
                XMLTestQuery.All();
            else if (CmbxProyects.SelectedValue == null && CmbxEnverioments.SelectedValue != null) 
                XMLTestQuery.ByEnverioment(CmbxEnverioments.SelectedValue.ToString());
            else if (CmbxProyects.SelectedValue != null && CmbxEnverioments.SelectedValue == null)
                XMLTestQuery.ByProyect(CmbxProyects.SelectedValue.ToString());
            else
                XMLTestQuery.ByProyectAndEnverioment(CmbxProyects.SelectedValue.ToString(), CmbxEnverioments.SelectedValue.ToString());
        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            var ListTestQuery = XMLTestQuery.GetData();

            foreach (var Test in ListTestQuery)
            {
                Test.ExecuteTest();
                if (Test._IsVersion && Test.HttpResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Test.ExecuteResult = Test.HttpResult.GetContent<Settings>().CurrentVersion;
                }
                else
                {
                    Test.ExecuteResult = Test.HttpResult.Content.ToString();
                }
            }

            Results FormResult = new Results(ListTestQuery);
            FormResult.Show();
        }

        private void Exec_Load(object sender, EventArgs e)
        {

        }
    }
}
