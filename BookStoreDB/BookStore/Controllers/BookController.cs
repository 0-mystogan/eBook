using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
