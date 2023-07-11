using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication13.DAL.Database;
using WebApplication13.DAL.Entities;

namespace WebApplication13.BL.Reposatory
;
    public class PaymentRepo : IPayment
    {
        private readonly DataBase db;

        public PaymentRepo(DataBase db)
        {
            this.db = db;
        }
        public int gettotal()
        {
            return db.payments.Select(a=>a.money).Sum();
        }
        public void create(Payment pay)
        {
         db.payments.Add(pay);
         db.SaveChanges();
        }

        public void delete(int id)
        {
            db.payments.Remove(db.payments.Find(id));
            db.SaveChanges();
        }

        public IEnumerable<Payment> filter(Func<Payment, bool> filter = null)
        {
            return db.payments.Where(filter);
        }

        public IEnumerable<Payment> GetAll()
        {
            return db.payments.Select(a => a);
        }

        public Payment Getbyid(int id)
        {
            return db.payments.Find(id);
        }

        public void update(Payment pay)
        {
            db.Entry(pay).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }

