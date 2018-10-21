using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureVersion.Entities
{
    public class HttpResult
    {
        public object Content { get; set; }
        public System.Net.HttpStatusCode StatusCode { get; set; }

        public T GetContent<T>()
        {
            try
            {
                object Obj = Convert.ChangeType(Content, typeof(T));

                if (Obj != null)
                {
                    return (T)Obj;
                }

                return default(T);
            }
            catch (Exception)
            {
                return default(T);
            }
        }
    }
}
