using SureVersion.Entities;
using SureVersion.Interfases;
using SureVersion.Util;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SureVersion.Xml
{
    public class XmlTest : IXmlBase<Test>
    {
        public XmlTest(XmlUtil pXMLUtil)
        {
            XMLUtil = pXMLUtil;
        }

        public XmlUtil XMLUtil { get;  set; }

        public string XmlTableName { get { return ConstantsUtil.TestXmlTableName; } }

        public string RootXmlTableName { get { return ConstantsUtil.RootXmlTableName; } }

        public void Add(Test pObj)
        {
            try
            {
                XMLUtil.XMLDocument.Element(RootXmlTableName)
                    .AddFirst(new XElement(XmlTableName,
                        new XAttribute("Id", pObj.Id),
                        new XElement("ProyectName", pObj.ProyectName),
                        new XElement("Name", pObj.Name),
                        new XElement("Url", pObj.Url),
                        new XElement("Method", pObj.Method),
                        new XElement("Data", pObj.Data),
                        new XElement("Enverioment", pObj.Enverioment),
                        new XElement("IsVersion", pObj.IsVersion)
                    ));

                XMLUtil.Save(XmlTableName);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void Edit(Test pObj)
        {
            try
            {
                XMLUtil.XMLDocument.Element(RootXmlTableName)
                    .Elements(XmlTableName)
                    .Where(x => x.Attribute("Id").Value == pObj.Id.ToString())
                    .FirstOrDefault()
                    .AddBeforeSelf(new XElement(XmlTableName,
                            new XAttribute("Id", pObj.Id),
                            new XElement("ProyectName", pObj.ProyectName),
                            new XElement("Name", pObj.Name),
                            new XElement("Url", pObj.Url),
                            new XElement("Method", pObj.Method),
                            new XElement("Data", pObj.Data),
                            new XElement("Enverioment", pObj.Enverioment),
                            new XElement("IsVersion", pObj.IsVersion)
                        ));

                XMLUtil.Save(XmlTableName);

                XMLUtil.XMLDocument.Element(RootXmlTableName)
                    .Elements(XmlTableName)
                    .Where(x => x.Attribute("Id").Value == pObj.Id.ToString())
                    .LastOrDefault()
                    .Remove();

                XMLUtil.Save(XmlTableName);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public Test GetById(string pId)
        {
            try
            {
                XElement XItem = XMLUtil.XMLDocument.Element(RootXmlTableName)
                            .Elements(XmlTableName)
                            .Where(x => x.Attribute("Id").Value == pId)
                            .FirstOrDefault();

                return new Test(
                    XItem.Attribute("Id").Value,
                    XItem.Element("ProyectName").Value,
                    XItem.Element("Name").Value,
                    XItem.Element("Url").Value,
                    XItem.Element("Method").Value,
                    XItem.Element("Data").Value,
                    XItem.Element("Enverioment").Value,
                    Convert.ToBoolean(XItem.Element("IsVersion").Value)
                    );
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
        }

        public void Remove(string pId)
        {
            try
            {
                XMLUtil.XMLDocument.Element(RootXmlTableName)
                       .Elements(XmlTableName)
                       .Where(x => x.Attribute("Id").Value == pId)
                       .LastOrDefault()
                       .Remove();

                XMLUtil.Save(XmlTableName);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void UpdateDataGrid()
        {
            XMLUtil.UpdateDataGrid(XmlTableName);
        }
    }
}
