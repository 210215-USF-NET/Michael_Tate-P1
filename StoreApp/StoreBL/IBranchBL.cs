﻿using System;
using StoreDL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreModels;

namespace StoreBL
{
    public interface IBranchBL
    {
        List<LibraryBranch> GetAll();

        List<Patron> GetPatrons(int branchId);

        List<LibraryAsset> GetAssets(int branchId);

        List<string> GetBranchHours(int branchId);

        LibraryBranch Get(int branchId);

        void Add(LibraryBranch newBranch);

        bool IsBranch(int branchId);
    }
}