using Practice.BookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice.BookStore.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}