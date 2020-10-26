﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infraestructure
{
    public class ConnectionHelper
    {
        const string JhonDBPROWAY = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\source\repos\DreamHotel\dbt\dbHotel.mdf;Integrated Security=True;Connect Timeout=30";

        const string JhonDBcasa = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\repositories\DreamHotel\dbt\dbHotel.mdf;Integrated Security=True;Connect Timeout=30";
        
        const string JoanaDBcasa = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\entra21\Documents\DataBHotel.mdf;Integrated Security=True;Connect Timeout=30";
        
        public static string GetConnectionString()
        {
            return JhonDBPROWAY;
        }
    }
}
