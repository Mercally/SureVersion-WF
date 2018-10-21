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
    public class XmlProyect : IXmlBase<Proyect>
    {
        public XmlProyect(XmlUtil pXMLUtil)
        {
            XMLUtil = pXMLUtil;
        }

        public XmlUtil XMLUtil { get; set; }

        public string XmlTableName { get { return ConstantsUtil.ProyectXmlTableName; } }

        public string RootXmlTableName { get { return ConstantsUtil.RootXmlTableName; } }

        public void Add(Proyect pObj)
        {
            try
            {
                XMLUtil.XMLDocument.Element(RootXmlTableName)
                    .AddFirst(new XElement(XmlTableName,
                        new XAttribute("Id", pObj.Id),
                        new XElement("Name", pObj.Name),
                        new XElement("Customer", pObj.Customer),
                        new XElement("TechnicalLeader", pObj.TechnicalLeader)
                    ));

                XMLUtil.Save(XmlTableName);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        public void Edit(Proyect pObj)
        {
            try
            {
                XMLUtil.XMLDocument.Element(RootXmlTableName)
                        .Elements(XmlTableName)
                        .Where(x => x.Attribute("Id").Value == pObj.Id.ToString())
                        .FirstOrDefault()
                        .AddBeforeSelf(new XElement(XmlTableName,
                                new XAttribute("Id", pObj.Id),
                                new XElement("Name", pObj.Name),
                                new XElement("Customer", pObj.Customer),
                                new XElement("TechnicalLeader", pObj.TechnicalLeader)
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

        public Proyect GetById(string Id)
        {
            try
            {
                XElement XItem = XMLUtil.XMLDocument.Element(RootXmlTableName)
                            .Elements(XmlTableName)
                            .Where(x => x.Attribute("Id").Value == Id)
                            .FirstOrDefault();

                return new Proyect(
                    XItem.Attribute("Id").Value,
                    XItem.Element("Name").Value,
                    XItem.Element("Customer").Value,
                    XItem.Element("TechnicalLeader").Value
                    );
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return null;
            }
        }

        public void Remove(string Id)
        {
            try
            {
                XMLUtil.XMLDocument.Element(RootXmlTableName)
                       .Elements(XmlTableName)
                       .Where(x => x.Attribute("Id").Value == Id)
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

        public List<Proyect> GetProyects()
        {
            List<Proyect> Proyects = new List<Proyect>();

            try
            {
                IEnumerable<XElement> XItems = XMLUtil.XMLDocument
                    .Element(RootXmlTableName)
                    .Elements(XmlTableName);

                foreach (var XItem in XItems)
                {
                    if (string.IsNullOrEmpty(XItem.Attribute("Id").Value))
                        continue;

                    Proyects.Add(
                        new Proyect(
                            XItem.Attribute("Id").Value,
                            XItem.Element("Name").Value,
                            XItem.Element("Customer").Value,
                            XItem.Element("TechnicalLeader").Value
                            )
                        );
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return Proyects;
        }

        public List<KeyValuePair<string, string>> GetListProyects()
        {
            List<KeyValuePair<string, string>> Proyects = new List<KeyValuePair<string, string>>();

            try
            {
                IEnumerable<XElement> XItems = XMLUtil.XMLDocument
                    .Element(RootXmlTableName)
                    .Elements(XmlTableName);

                foreach (var XItem in XItems)
                {
                    if (string.IsNullOrEmpty(XItem.Attribute("Id").Value))
                        continue;

                    string Name = XItem.Element("Name").Value;

                    Proyects.Add(new KeyValuePair<string, string>(Name, Name));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            return Proyects;
        }
    }
}
