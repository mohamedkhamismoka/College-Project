using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication13.BL
{
    public interface Mailsender
{
        void sendmail(string mailfrom,string mailto, string pass, string title, string body);
       
}
}
