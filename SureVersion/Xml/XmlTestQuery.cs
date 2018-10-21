using SureVersion.Entities;
using SureVersion.Interfases;
using SureVersion.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SureVersion.Xml
{
    public class XmlTestQuery : IXmlBaseQuery
    {
        public XmlTestQuery(XmlUtil pXMLUtil, DataGridView pDataGridViewComponent)
        {
            XMLUtil = pXMLUtil;
            DataGridViewComponent = pDataGridViewComponent;

            CreateGrid();
        }

        public XmlUtil XMLUtil { get; set; }
        public string XmlTableName { get { return ConstantsUtil.TestXmlTableName; } }
        public string RootXmlTableName { get { return ConstantsUtil.RootXmlTableName; } }
        public DataGridView DataGridViewComponent { get; }

        public void CreateGrid()
        {
            DataGridViewComponent.ColumnCount = 6;
            DataGridViewComponent.Columns[0].Name = "Name";
            DataGridViewComponent.Columns[1].Name = "Url";
            DataGridViewComponent.Columns[2].Name = "Method";
            DataGridViewComponent.Columns[3].Name = "Enverioment";
            DataGridViewComponent.Columns[4].Name = "Execute";
            DataGridViewComponent.Columns[4].Visible = false;
            DataGridViewComponent.Columns[5].Name = "IsVersion";
        }

        public void CleanGrid()
        {
            DataGridViewComponent.Rows.Clear();
        }

        public void UpdateGrid(IEnumerable<TestQuery> QueryResult)
        {
            CleanGrid();

            foreach (var Result in QueryResult)
            {
                DataGridViewComponent.Rows.Add(Result.ToArrayObject());   
            }
        }

        public List<TestQuery> GetData()
        {
            List<TestQuery> ListTestQuery = new List<TestQuery>();

            try
            {
                for (int i = 0; i < DataGridViewComponent.Rows.Count; i++)
                {
                    ListTestQuery.Add(
                    new TestQuery(
                        DataGridViewComponent.Rows[i].Cells["Name"].Value.ToString(),
                        DataGridViewComponent.Rows[i].Cells["Url"].Value.ToString(),
                        DataGridViewComponent.Rows[i].Cells["Method"].Value.ToString(),
                        DataGridViewComponent.Rows[i].Cells["Enverioment"].Value.ToString(),
                        DataGridViewComponent.Rows[i].Cells["IsVersion"].Value.ToString()
                    ));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return ListTestQuery;
        }

        public void All()
        {
            List<TestQuery> ListTestQuery = new List<TestQuery>();

            try
            {
                IEnumerable<XElement> XItems = XMLUtil.XMLDocument.Element(RootXmlTableName)
                            .Elements(XmlTableName);

                foreach (var XItem in XItems)
                {
                    ListTestQuery.Add(
                    new TestQuery(
                        XItem.Element("Name").Value,
                        XItem.Element("Url").Value,
                        XItem.Element("Method").Value,
                        XItem.Element("Enverioment").Value,
                        XItem.Element("IsVersion").Value
                    ));
                }

                UpdateGrid(ListTestQuery);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void ByProyect(string pProyectName)
        {
            List<TestQuery> LisTestQuery = new List<TestQuery>();

            try
            {
                IEnumerable<XElement> XItems = XMLUtil.XMLDocument.Element(RootXmlTableName)
                            .Elements(XmlTableName)
                            .Where(x => x.Element("ProyectName").Value == pProyectName);

                foreach (var XItem in XItems)
                {
                    LisTestQuery.Add(
                    new TestQuery(
                        XItem.Element("Name").Value,
                        XItem.Element("Url").Value,
                        XItem.Element("Method").Value,
                        XItem.Element("Enverioment").Value,
                        XItem.Element("IsVersion").Value
                    ));
                }

                UpdateGrid(LisTestQuery);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void ByEnverioment(string pEnverioment)
        {
            List<TestQuery> LisTestQuery = new List<TestQuery>();

            try
            {
                IEnumerable<XElement> XItems = XMLUtil.XMLDocument.Element(RootXmlTableName)
                            .Elements(XmlTableName)
                            .Where(x => x.Element("Enverioment").Value == pEnverioment);

                foreach (var XItem in XItems)
                {
                    LisTestQuery.Add(
                    new TestQuery(
                        XItem.Element("Name").Value,
                        XItem.Element("Url").Value,
                        XItem.Element("Method").Value,
                        XItem.Element("Enverioment").Value,
                        XItem.Element("IsVersion").Value
                    ));
                }

                UpdateGrid(LisTestQuery);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void ByProyectAndEnverioment(string pProyectName, string pEnverioment)
        {
            List<TestQuery> LisTestQuery = new List<TestQuery>();

            try
            {
                IEnumerable<XElement> XItems = XMLUtil.XMLDocument.Element(RootXmlTableName)
                            .Elements(XmlTableName)
                            .Where(x =>
                            x.Element("ProyectName").Value == pProyectName &&
                            x.Element("Enverioment").Value == pEnverioment);

                foreach (var XItem in XItems)
                {
                    LisTestQuery.Add(
                    new TestQuery(
                        XItem.Element("Name").Value,
                        XItem.Element("Url").Value,
                        XItem.Element("Method").Value,
                        XItem.Element("Enverioment").Value,
                        XItem.Element("IsVersion").Value
                    ));
                }

                UpdateGrid(LisTestQuery);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}