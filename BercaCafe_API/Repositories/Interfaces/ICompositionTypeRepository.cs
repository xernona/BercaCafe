﻿using APIDapper.Models;
using BercaCafe_API.Models;
using BercaCafe_API.ViewModels;
using System.Collections.Generic;

namespace BercaCafe_API.Repositories.Interfaces
{
    public interface ICompositionTypeRepository
    {
        IEnumerable<CompositionTypeVm> Get();
        CompositionTypeVm Get(int CompTypeID);
        int Insert(CompositionTypeVm compositionTypeVm);
        int Update(CompositionTypeVm compositionTypeVm);
        int Delete(CompositionTypeVm compositionTypeVm);
        public int SubstractCompositionType(UpdateCompTypeVM compType);
    }
}

