﻿using Practice.BookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice.BookStore.Repository
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel bookModel);
        List<BookModel> GetAllBooks();
        BookModel GetBookById(int id);
        List<BookModel> SearchBook(string title, string authorName);
    }
}