using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Exam.entities;


namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext ctx = new MyContext();
            ctx.Comptes.Add(new Compte {RIB = 2141, Solde = 120, DateOuverture = new DateTime()});
            System.Console.ReadKey();

        }
    }
}
