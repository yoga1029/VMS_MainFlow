using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_Phase1PortalAT.FlowTest.Utilities.Datas
{
    internal class AddBrandData
    {
        // Field order: searchName, brand name, branch, Image
        public static string[,] Brands = new string[,]
        {

            {
                "Yarn Tales", "Yarn Tales", "Pudukkottai Branch", @"C:\Users\Yogeswari-PC\Pictures\ch.jpg"
            }

        };
    }
}



//     internal class AddBrandData
//     {
//        public static Dictionary<string, string> addBrandSuccess = new Dictionary<string, string>
//        {
//            {"searchName", "Yarn Tales"},
//            { "name", "Yarn Tales" },
//            { "fileUpload", @"C:\Users\Yogeswari-PC\Pictures\ch.jpg" },
//            {"branch", " Pudukkottai Branch " }
//        };
//    }
//}


