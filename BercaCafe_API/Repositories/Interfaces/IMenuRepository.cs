using BercaCafe_API.Models;
using BercaCafe_API.ViewModels;
using System.Collections.Generic;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface IMenuRepository
    {
        IEnumerable<MenuVM> GetAllMenus();
        MenuVM GetMenuById(int id);
    }
}
