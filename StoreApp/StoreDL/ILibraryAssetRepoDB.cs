using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public interface ILibraryAssetRepoDB
    {
        List<LibraryAsset> GetAll();

        LibraryAsset GetByID(int id);

        LibraryAsset AddAsset(LibraryAsset newAsset);

        string GetAuthorOrDirector(int id);

        string GetDeweyIndex(int id);

        string GetType(int id);

        string GetTitle(int id);

        string GetIsbn(int id);

        LibraryBranch GetCurrrentLocation(int id);
    }
}