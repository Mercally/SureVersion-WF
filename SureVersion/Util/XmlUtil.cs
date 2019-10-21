using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using SureVersion.Entities;

namespace SureVersion.Util
{
    public class XmlUtil
    {
        public XmlDataDocument XmlData { get; set; }
        private XDocument _XMLDocument { get; set; }
        public XDocument XMLDocument
        {
            get
            {
                LoadDocument();
                return _XMLDocument;
            }
        }
        private string FullPath { get; set; }
        public DataGridView DataGridView { get; set; }
        public bool ReloadDataGridView { get { return DataGridView != null; } }

        public XmlUtil()
        {
            LoadDocument();
        }

        public XmlUtil(DataGridView pDataGridView)
        {
            LoadDocument();

            this.DataGridView = pDataGridView;
        }

        public void LoadDocument()
        {
            FullPath = Path.Combine(Application.StartupPath, ConstantsUtil.XmlDocumentName);
            
            if (!File.Exists(FullPath))
            {
                new XDocument(
                    new XElement(ConstantsUtil.RootXmlTableName)
                    ).Save(ConstantsUtil.XmlDocumentName);
            }

            XmlData = new XmlDataDocument();

            XmlData.DataSet.ReadXml(FullPath);

            _XMLDocument = XDocument.Load(FullPath);
        }

        public bool UpdateDataGrid(string pXMLElement)
        {
            if (!ReloadDataGridView)
                return false;
            
            try
            {
                LoadDocument();

                DataGridView.DataSource = XmlData.DataSet;
                DataGridView.DataMember = pXMLElement;

                DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                for (int i = 0; i < DataGridView.Columns.Count; i++)
                {
                    if (ConstantsUtil.HideColums.Contains(DataGridView.Columns[i].Name))
                    {
                        DataGridView.Columns[i].Visible = false;
                    }
                }

                return true;
            }
            catch (ArgumentException ArEx)
            {
                MessageBox.Show(ArEx.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return false;
        }

        public void Save(string XmlTableName)
        {
            _XMLDocument.Save(FullPath);

            if (ReloadDataGridView)
                UpdateDataGrid(XmlTableName);
        }
    }
}
