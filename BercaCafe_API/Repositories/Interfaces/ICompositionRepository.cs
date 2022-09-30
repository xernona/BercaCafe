using BercaCafe_API.ViewModels;
using System.Collections.Generic;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface ICompositionRepository
    {
        IEnumerable<CompositionVm> Get();
        CompositionVm Get(int CompID);
        int Insert(CompositionVm compositionVm);
        int Update(CompositionVm compositionVm);
        IEnumerable<CompositionVm> GetByMenu(int menuID);

    }
}
