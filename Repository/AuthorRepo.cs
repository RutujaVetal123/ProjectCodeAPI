using Microsoft.EntityFrameworkCore;
using ProjectCode.Data;
using ProjectCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectCode.Repository
{
    public class AuthorRepo : IAuthor
    {
        private ProjectCodeDbContext _projectCodeDb;

        public AuthorRepo(ProjectCodeDbContext projectCodeDb)
        {
            _projectCodeDb = projectCodeDb;
        }
        public string DeleteAuthor(int authorId)
        {
            string msg = "";
            Author delete = _projectCodeDb.Author.Find(authorId);//storing the details of the Author in the obj 
            try
            {
                if (delete != null)
                {
                    _projectCodeDb.Author.Remove(delete);
                    _projectCodeDb.SaveChanges();
                    msg = "Deleted";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return msg;
        }

        public List<Author> GetAllAuthors()
        {
            List<Author> author = _projectCodeDb.Author.ToList();
            return author;
        }

        public Author GetAuthorByID(int authorId)
        {
            try
            {
                Author author = _projectCodeDb.Author.Find(authorId);
                return author;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string SaveAuthor(Author author)
        {
            try
            {
                _projectCodeDb.Author.Add(author);
                _projectCodeDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return "Saved";
        }

        public string UpdateAuthor(Author author)
        {
            try
            {
                _projectCodeDb.Entry(author).State = EntityState.Modified;
                _projectCodeDb.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return "Updated";
        }
    }
}
