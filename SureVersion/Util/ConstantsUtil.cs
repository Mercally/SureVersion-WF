using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace SureVersion.Util
{
    public class ConstantsUtil
    {
        public const string XmlDocumentName = "DataSureVersion.xml";
        public const string RootXmlTableName = "Proyects";
        public const string ProyectXmlTableName = "Proyect";
        public const string TestXmlTableName = "Test";
        public readonly static List<string> HideColums = new List<string>(){ "Id", "ProyectId", "TestId" };

        public readonly static List<KeyValuePair<string, string>> Enverioments = new List<KeyValuePair<string, string>>() {
            new KeyValuePair<string, string>("LOCAL", "LOCAL"),
            new KeyValuePair<string, string>("DEV", "DEV"),
            new KeyValuePair<string, string>("QA", "QA"),
            new KeyValuePair<string, string>("UAT", "UAT"),
            new KeyValuePair<string, string>("PROD", "PROD")
        };

        public readonly static List<KeyValuePair<string, string>> HttpMethods = new List<KeyValuePair<string, string>>() {
            new KeyValuePair<string, string>("GET", "GET")
            //new KeyValuePair<string, string>("POST", "POST"),
            //new KeyValuePair<string, string>("PUT", "PUT"),
            //new KeyValuePair<string, string>("DELETE", "DELETE"),
            //new KeyValuePair<string, string>("PATCH", "PATCH")
        };
    }
}
