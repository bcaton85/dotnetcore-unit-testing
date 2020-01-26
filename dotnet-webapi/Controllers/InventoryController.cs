using Microsoft.AspNetCore.Mvc;
using dotnet_webapi.Interfaces;
using dotnet_webapi.Models;

namespace dotnet_webapi.Controllers {
    public class InventoryController : Controller {

        private IInventory _inventory;

        public InventoryController(IInventory inventory){
            _inventory = inventory;
        }

        public double GetCartTotal([FromBody] InventoryRequest inventoryRequest){

            return _inventory.GetCartTotal(inventoryRequest.items);
        }

    }
}