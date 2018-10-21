using SureVersion.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureVersion.Interfases
{
    public interface IXmlBaseQuery
    {
        XmlUtil XMLUtil { get; set; }
        string XmlTableName { get; }
        string RootXmlTableName { get; }
    }
}
