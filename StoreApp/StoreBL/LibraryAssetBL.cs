using Microsoft.EntityFrameworkCore;
using StoreDL;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBL
{
    public class LibraryAssetBL : ILibraryAssetBL
    {
        private ILibraryAssetRepoDB _repo;

        public LibraryAssetBL(ILibraryAssetRepoDB repo)
        {
            _repo = repo;
        }

        public LibraryAsset AddAsset(LibraryAsset newAsset)
        {
            return _repo.AddAsset(newAsset);
        }

        public List<LibraryAsset> GetAll()
        {
            return _repo.GetAll();
        }

        public string GetAuthorOrDirector(int id)
        {
            return _repo.GetAuthorOrDirector(id);
        }

        public LibraryAsset GetByID(int id)
        {
            return _repo.GetByID(id);
        }

        public LibraryBranch GetCurrrentLocation(int id)
        {
            return _repo.GetCurrrentLocation(id);
        }

        public string GetDeweyIndex(int id)
        {
            return _repo.GetDeweyIndex(id);
        }

        public string GetIsbn(int id)
        {
            return _repo.GetIsbn(id);
        }

        public string GetTitle(int id)
        {
            return _repo.GetTitle(id);
        }

        public string GetType(int id)
        {
            return _repo.GetType(id);
        }
    }
}