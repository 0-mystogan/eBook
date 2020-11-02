using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using BookStore.Dal.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var books = await _bookRepository.GetTopTen();
            return Ok(books);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var book = await _bookRepository.GetById(id);
            return Ok(book);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> SearchByName(string name)
        {
            var books = await _bookRepository.SearchByName(name);
            return Ok(books);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] BookDto book)
        {
            var newBook = await _bookRepository.Add(book);
            return Ok(newBook);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            var deleteBook = await _bookRepository.Remove(id); 
            return Ok(deleteBook);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] BookDto book)
        {
            await _bookRepository.Update(book);
            return Ok();
        }

        [HttpPost, DisableRequestSizeLimit]
        public IActionResult Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
