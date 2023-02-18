using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zaliczenie_.net.Models;

namespace zaliczenie_.net.Controllers
{
    public class SearchCotroller : Controller
    {
        private LibraryContext _context;

        public SearchCotroller(LibraryContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Search(string searchString)
        {
            if (_context.Books == null)
            {
                return Problem("Entity set 'MvcMovieContext.Movie'  is null.");
            }

            var searchedBooks = from m in _context.Books
                                select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                searchedBooks = searchedBooks.Where(s => s.Tittle!.Contains(searchString));
            }
            return View(await searchedBooks.ToListAsync());
        }
    }

}
