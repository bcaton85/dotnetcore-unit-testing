using dotnet_webapi.Interfaces;
using System.Collections.Generic;

namespace dotnet_webapi.Services {
    public class Inventory : IInventory {

        // Hard coded for demonstration purposes
        public Dictionary<string, double> products = new Dictionary<string, double>(){
            {"Shoes",21},
            {"Tesla Model S",3.44},
            {"Toothbrush",5.00},
            {"Towel",13.00},
            {"Lamp",10.00},
        };

        public Inventory(){}

        public double GetCartTotal(string[] items){

            double total = 0;

            for(int i = 0; i<items.Length; i++){
                total += products[items[i]];
            }

            return total;
        }
    }
}