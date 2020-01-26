using System.Threading.Tasks;

namespace dotnet_webapi.Interfaces
{
    public interface IInventory
    {
        double GetCartTotal(string[] items);
    }
}