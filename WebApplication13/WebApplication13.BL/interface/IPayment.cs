using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL
{
    public interface IPayment
{
        public void create(Payment pay);
        public void update(Payment pay);

        public void delete(int id);

        public IEnumerable<Payment> GetAll();

        public Payment  Getbyid(int id);

        public IEnumerable<Payment> filter(Func<Payment, bool> filter = null);

        public int gettotal();
     
    }


}
