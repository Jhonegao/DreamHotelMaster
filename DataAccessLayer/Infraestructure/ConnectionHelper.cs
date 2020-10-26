using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infraestructure
{
    class ConnectionHelper
    {
        public static string GetConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\DataBHotel.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
