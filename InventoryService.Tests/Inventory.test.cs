using System;
using Xunit;
using dotnet_webapi.Services;

namespace InventoryService.Tests
{
    public class InventoryTest
    {
        private readonly Inventory _inventory;

        public InventoryTest(){
            _inventory = new Inventory();
        }

        [Fact]
        public void Test1()
        {
            double total = _inventory.GetCartTotal( new string[]{"Toothbrush","Towel","Lamp"} );
            Assert.Equal(total, 28.00);
        }
    }
}
