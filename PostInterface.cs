using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmadarMobileUplouder
{
    public interface IPostInterface
    {
        //Properties declaration
        string Token { get; set; }
        bool HasAccessToken { get; }

        string domain_name { get; set; }
        string company_code { get; set; }
        string companyUrl { get; set; }
        string path_type { get; set; }
        string path { get; set; }
       

       
    }
}
