using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_Phase1PortalAT.FlowTest.Utilities.Datas
{
    internal class AddWarehouseData
    {
        public static string[,] Warehouses = new string[,]
        {
            {
                "Pudukkottai Warehouse", "Pudukkottai Warehouse", "10.322328285716925", "78.67931085899907", "Pudukkottai", "Tamilnadu", "Pudukkottai Branch",
                 "9123456789", @"C:\Users\Yogeswari-PC\Pictures\ch.jpg"
            },
            //{
            //    "Karaikkudi Warehouse", "Karaikkudi Warehouse", "10.322328285716925", "78.67931085899907", "Pudukkottai", "Tamilnadu", "Pudukkottai Branch",
            //     "9123456789", @"C:\Users\Yogeswari-PC\Pictures\ch.jpg"
            //}
        };

        public static string[,] Vendors = new string[,]
        {
            {
                "Thirumayam", "Thirumayam", "Pudukkottai Branch", "thirumayam@gmail.com", "+91 9123452789",
                "Akash_Thirumayam Vendor", "contactthirumayam@gmail.com", "+91 9120456789", 
            },
        };
    }
}
