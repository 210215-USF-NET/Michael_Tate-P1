using Microsoft.EntityFrameworkCore;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDL
{
    public class LibraryAssetRepoDB : ILibraryAssetRepoDB
    {
        private StoreDBContext _context;

        public LibraryAssetRepoDB(StoreDBContext context)
        {
            _context = context;
        }

        public LibraryAsset AddAsset(LibraryAsset newAsset)
        {
            _context.Add(newAsset);
            _context.SaveChanges();
            return newAsset;
        }

        public List<LibraryAsset> GetAll()
        {
            return _context.LibraryAssets
                .Include(asset => asset.Status)
                .Include(asset => asset.Location)
                .ToList();
        }

        public LibraryAsset GetByID(int id)
        {
            return
                GetAll()
                .FirstOrDefault(asset => asset.Id == id);
        }

        public LibraryBranch GetCurrrentLocation(int id)
        {
            return GetByID(id).Location;

            //return _context.LibraryAssets.FirstOrDefault(asset => asset.Id == id).Location;
        }

        public string GetDeweyIndex(int id)
        {
            if (_context.Books.Any(book => book.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(book => book.Id == id).DeweyIndex;
            }
            else return "";
        }

        public string GetIsbn(int id)
        {
            if (_context.Books.Any(x => x.Id == id))
            {
                return _context.Books
                    .FirstOrDefault(x => x.Id == id).ISBN;
            }
            else return "";
        }

        public string GetTitle(int id)
        {
            return _context.LibraryAssets
                .FirstOrDefault(x => x.Id == id)
                .Title;
        }

        public string GetType(int id)
        {
            var book = _context.LibraryAssets
                .OfType<Book>()
                .Where(book => book.Id == id);

            return book.Any() ? "Book" : "Video";
        }

        public string GetAuthorOrDirector(int id)
        {
            var isBook = _context.LibraryAssets.OfType<Book>()
                .Where(asset => asset.Id == id).Any();

            var isVideo = _context.LibraryAssets.OfType<Video>()
                .Where(asset => asset.Id == id).Any();

            return isBook ?
                _context.Books.FirstOrDefault(book => book.Id == id).Author :
                _context.Videos.FirstOrDefault(video => video.Id == id).Director
                ?? "Unknown";
        }
    }
}