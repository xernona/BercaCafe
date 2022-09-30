using APIDapper.Models;
using BercaCafe_API.Models;
using BercaCafe_API.ViewModels;
using System.Collections.Generic;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface IRefillRepository
    {
        RefillVm Get(int CompTypeID);
        int Decr(int MaterialsID);
        int Refill(int CompTypeID, int Quantity);
    }
}
