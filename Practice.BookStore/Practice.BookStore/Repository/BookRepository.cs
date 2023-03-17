using Microsoft.EntityFrameworkCore;
using Practice.BookStore.Data;
using Practice.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.BookStore.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }

        public async Task<int> AddNewBook(BookModel bookModel)
        {
            var newBook = new Books()
            {
                Title = bookModel.Title,
                Author = bookModel.Author,
                LanguageId = bookModel.LanguageId
            };
            await _context.Books.AddAsync(newBook);
            await _context.SaveChangesAsync();

            return newBook.Id;

        }

        public List<BookModel> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allBooks = _context.Books.ToList();
            if (allBooks.Any() == true)
            {
                foreach (var book in allBooks)
                {
                    books.Add(new BookModel()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Author = book.Author,
                    });
                }

            }
            return books;
        }

        public BookModel GetBookById(int id)
        {
            return _context.Books.Where(x => x.Id == id).Select(book => new BookModel()
            {
                Title = book.Title,
                Author = book.Author,
                LanguageId = book.Language.Id,
                Language = book.Language.Name
            }
                ).FirstOrDefault();

        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return null;

        }


    }
}
