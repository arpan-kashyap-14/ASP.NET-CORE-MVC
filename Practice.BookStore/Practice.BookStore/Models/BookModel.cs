using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Practice.BookStore.Helper;

namespace Practice.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [MyCustomValidationAttribute]
        public string Title { get; set; }

        [Required(ErrorMessage ="Please Enter the Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please Enter the Language")]
        public int LanguageId { get; set; }

        public string Language { get; set; }

    }
}
