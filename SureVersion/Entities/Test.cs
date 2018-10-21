using SureVersion.Util;
using System;
using System.Windows.Forms;

namespace SureVersion.Entities
{
    public class Test
    {
        private Test() { }

        public Test(string pId, string pProyectName, string pName, string pUrl, string pMethod, string pData, string pEnverioment, bool pIsVersion)
        {
            Id = string.IsNullOrEmpty(pId) ? Guid.NewGuid() : new Guid(pId);
            ProyectName = string.IsNullOrEmpty(pProyectName) ? "N/A" : pProyectName;
            Name = pName;
            Url = pUrl;
            Method = pMethod;
            Data = pData;
            Enverioment = pEnverioment;
            IsVersion = pIsVersion;
        }

        public Guid Id { get; set; }
        public string ProyectName { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Method { get; set; }
        public string Data { get; set; }
        public string Enverioment { get; set; }
        public bool IsVersion { get; set; }

        public object[] ToArrayObject()
        {
            return new object[]
            {
                this.Id,
                this.ProyectName,
                this.Name,
                this.Url,
                this.Method,
                string.Empty,
                this.Enverioment,
                this.IsVersion
            };
        }

        public static Test GetTest(DataGridViewRow dataGridViewRow)
        {
            try
            {
                return new Test(
                null, // New Id
                dataGridViewRow.Cells["ProyectName"].Value.ToString(),
                dataGridViewRow.Cells["Name"].Value.ToString(),
                dataGridViewRow.Cells["Url"].Value.ToString(),
                dataGridViewRow.Cells["Method"].Value.ToString(),
                "",
                dataGridViewRow.Cells["Enverioment"].Value.ToString(),
                ValidationUtil.ToBoolean(dataGridViewRow.Cells["IsVersion"].Value)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
