using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DataLayerB;
using DataLayerB.Models;

namespace Tema2_BD
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ProiectBDContext();

            var query = from b in db.Students
                        orderby b.Nume
                        select b;

            foreach (var s in query)
            {
                Console.WriteLine(s.Nume.ToString());
            }
            


        }
    }
}
