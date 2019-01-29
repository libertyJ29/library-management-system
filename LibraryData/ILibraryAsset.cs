using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryData
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();
        LibraryAsset GetById(int Id);

        void Add(LibraryAsset newAsset);
        String GetAuthorOrDirector(int Id);
        String GetDeweyIndex(int Id);
        String GetType(int Id);
        String GetTitle(int Id);
        String GetIsbn(int Id);

        LibraryBranch GetCurrentLocation(int Id);
    }
}
