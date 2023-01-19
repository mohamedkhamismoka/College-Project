using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication13.BL
{
    public interface Mailsender
{
        async Task sendmail(string mailfrom, string body)
        {

        }
       
}
}
