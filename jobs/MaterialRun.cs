using GTANetworkAPI;
using MyCustomGamemode.database;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System;

namespace MyCustomGamemode.jobs
{
    public class MatRun : Script
    {

        public int id { get; set; }
        public string name { get; set; }
        public int payment { get; private set; }
        public int matamount { get; set; }
        public double pposX { get; set; }
        public double pposY { get; set; }
        public double pposZ { get; set; }
        public double dposX { get; set; }
        public double dposY { get; set; }
        public double dposZ { get; set; }

        public MatRun()
        {
        }


        public void setPayment(int payment, bool updateDatabase = false)
        {
            this.payment = payment;
            // Update Database in background.
            if (updateDatabase)
            {

            }
        }

      
    }

    
}