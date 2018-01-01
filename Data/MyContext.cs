using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Exam.entities;


namespace Data
{
   public  class MyContext:DbContext
    {
     public MyContext() : base("ExamDB")
        {

           
        }   

        public DbSet<Compte> Comptes { get; set; }

        
    }
}
