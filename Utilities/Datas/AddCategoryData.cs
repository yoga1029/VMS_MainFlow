using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_Phase1PortalAT.FlowTest.Utilities.Datas
{
    internal class AddCategoryData
    {
        // Field order: searchName, category name, branch name, brand name, Image
        public static string[,] Categories = new string[,]
        {

            {
                "Crochet", "Crochet", "Pudukkottai Branch", "Yarn Tales", @"C:\Users\Yogeswari-PC\Pictures\ch.jpg"
            }

        };
    }
}

//    internal class AddCategoryData
//    {
//        public static Dictionary<string, string> addCategorySuccess = new Dictionary<string, string>
//        {
//            {"searchName", "Crochet" },
//            { "name", "Crochet" },
//            { "branch", "Pudukkottai Branch" },
//            { "brand", "Yarn Tales" },
//            { "fileUpload", @"C:\Users\Yogeswari-PC\Pictures\ch.jpg" }
//        };
//    }
//}
