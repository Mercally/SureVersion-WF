using SureVersion.Util;

namespace SureVersion.Interfases
{
    public interface IXmlBase<T>
    {
        XmlUtil XMLUtil { get; set; }
        string XmlTableName { get; }
        string RootXmlTableName { get; }

        T GetById(string pId);
        void Add(T pObj);
        void Edit(T pObj);
        void Remove(string pId);
        void UpdateDataGrid();
    }
}
