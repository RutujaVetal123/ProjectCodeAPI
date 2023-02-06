using ProjectCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Repository
{
    public interface IAuthor
    {
        public string SaveAuthor(Author author);
        public string UpdateAuthor(Author author);
        public string DeleteAuthor(int authorId);
        List<Author> GetAllAuthors();
        Author GetAuthorByID(int authorId);
    }
}
