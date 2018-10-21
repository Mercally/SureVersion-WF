using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SureVersion.Entities
{
    public enum HttpStatusCodeEnum
    {
        OK=200,
        Created=201,
        Accepted=202,
        NotModified=304,
        BadRequest=400,
        Unauthorized=401,
        Forbidden=403,
        NotFound=404,
        MethodNotAllowed=405,
        RequestTimeout=408,
        InternalServerError=500,
        NotImplemented=501,
        BadGateway=502,
        ServiceUnavailable=503
    }
}
