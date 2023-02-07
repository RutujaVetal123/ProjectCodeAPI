using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectCode.Models;
using ProjectCode.Services;

namespace ProjectCode.Controllers
{
    public class AuthorController : Controller
    {
        private AuthorService _authorService;
        public AuthorController(AuthorService author)
        {
            _authorService = author;
        }
        [HttpPost("SaveAuthor")]
        public IActionResult SaveAuthor(Author author)
        {
            return Ok(_authorService.SaveAuthor(author));
        }

        [HttpDelete("DeleteAuthor")]
        public IActionResult DeleteAuthor(int AuthorID)
        {
            return Ok(_authorService.DeleteAuthor(AuthorID));
        }

        [HttpPut("UpdateAuthor")]
        public IActionResult UpdateAuthor(Author author)
        {
            return Ok(_authorService.UpdateAuthor(author));
        }

        [HttpGet("GetAuthorByID")]
        public IActionResult GetAuthorByID(int AuthorID)
        {
            return Ok(_authorService.GetAuthorByID(AuthorID));
        }

        [HttpGet("GetAllAuthors()")]
        public List<Author> GetAllAuthors()
        {
            return _authorService.GetAllAuthors();
        }
    }
}
