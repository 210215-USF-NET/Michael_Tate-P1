using System;
using StoreDL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreModels;

namespace StoreBL
{
    public class BranchBL : IBranchBL
    {
        private IBranchRepoDB _repo;

        public BranchBL(IBranchRepoDB repo)
        {
            _repo = repo;
        }

        public void Add(LibraryBranch newBranch)
        {
            _repo.Add(newBranch);
        }

        public LibraryBranch Get(int branchId)
        {
            return _repo.Get(branchId);
        }

        public List<LibraryBranch> GetAll()
        {
            return _repo.GetAll();
        }

        public List<LibraryAsset> GetAssets(int branchId)
        {
            return _repo.GetAssets(branchId);
        }

        public List<string> GetBranchHours(int branchId)
        {
            return _repo.GetBranchHours(branchId);
        }

        public List<Patron> GetPatrons(int branchId)
        {
            return _repo.GetPatrons(branchId);
        }

        public bool IsBranch(int branchId)
        {
            return _repo.IsBranch(branchId);
        }
    }
}