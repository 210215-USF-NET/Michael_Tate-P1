using System;
using StoreDL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreModels;

namespace StoreDL
{
    public interface IBranchRepoDB
    {
        List<LibraryBranch> GetAll();

        //List<Patron> GetPatrons(int branchId);

        List<LibraryBranch> GetAssets(int branchId);

        List<string> GetBranchHours(int branchId);

        LibraryBranch Get(int branchId);

        void Add(LibraryBranch newBranch);

        bool IsBranch(int branchId);
    }
}