using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMS_Phase1PortalAT.FlowTest.Utilities.Datas
{
    public class ProductMappingData
    {
        public static string[,] products = new string[,]
        {
            { //Slot number, Product Name, Purchase Limit Per User, Purchase Limit Reset Per User Time, Purchase Limit Reset Per Transaction, Stock Limit
  
                "7","Tulip","0","0","Every-2-Month","2"
            },
            {
               "8","Honey Bee Toy","","0","Every-Fortnight","2"
            },
            {
                "9","Elephant Toy","0","0","Every-Day","2"
            },
            {
                "10","Tops","0","0","Every-Week","2"
            },
            //{
            //    "11","Lavender","0","0","Every-Month","10"
            //},
            //{
            //    "12","Strawberry Keychain","0","0","Every-Week","10"
            //},
            //{
            //    "13","Avocado Amigurumi","0","0","Every-Day","10"
            //},
            //{
            //    "14","Bunny","0","0","Every-Day","10"
            //},
            //{
            //    "15","Handbag","0","0","Every-Week","15"

            //},
            //{
            //    "16","Rose","0","0","Every-Week","20"

            //},
            //{
            //    "17","Penguin","0","0","Every-Week","10"

            //},
            //{
            //    "18","Sunflower","0","0","Every-Week","20"

            //},
            //{
            //    "19","Sweaters","0","0","Every-Week","10"
            //},
            //{
            //    "20","Shawls","0","0","Every-Day","7"
            //},
            //{
            //    "21","Daisy","0","0","Every-Week","15"
            //},
            //{
            //    "22","Mr Bean Teddy","0","0","Every-Day","5"
            //},

        };

        //public static Dictionary<string, string> Datas = new Dictionary<string, string>
        //    {
        //        { "name", "Tulip" },
        //    };
    }

    internal class RaiseRefillRequestData
        {
            public static Dictionary<string, string> refillDatas = new Dictionary<string, string>
            {
                { "warehouseName", "Pudukkottai Warehouse - PUD0000114" },
            };
        }


    internal class ReturnRequestData
    {
        public static Dictionary<string, string> refillDatas = new Dictionary<string, string>
            {
                { "warehouseName", "Pudukkottai Warehouse - PUD0000114" },
            };
    }


    internal class LocationData
    {
        public static string[,] location = new string[,]
        {
            { //City, State, Plus Code
  
                "Perungudi","Tamilnadu","X69V+7J Chennai"
            },

        };

    }

    internal class ParametersData
    {
        public static string[,] parameters = new string[,]
        {
            { //three parameters
  
                "HVR_TEMP","APP_VERSION","FW_DETAILS"
            },

        };

    }


    internal class PlanogramData
    {
        public static string[,] slotCounts = new string[,]
        {
            { //Total Row Count, Total Column Count, Total Row Count, Total Column Count
  
                "3","3","5","4"
            },

        };

    }

    internal class FunctionsData
    {
        public static string[,] functions = new string[,]
        {
            { //Four Functions
  
                "Restart Machine","Cloud Communication Logging","VMC Communication Logging","BLE Communication Logging 1"
            },

        };

    }

    internal class machineInfoData
    {
        public static string[,] machineDetails = new string[,]
        {
            { //Four Functions
  
                "Chennai","Tambaram to Anna Nagar"
            },

        };

    }

    internal class machinePOData
    {
        public static string[,] machineMapping = new string[,]
        {
            {
                 "2026", "Jan", "31", "2030", "Jan", "31"
            },
        };
    }

}