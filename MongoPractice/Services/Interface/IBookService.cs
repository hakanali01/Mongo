using MongoPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoPractice.Services
{
    interface IBookService 
    {
        public List<Book> Get();

        public Book Get(string id);

        public Book Create(Book book);

        public void Update(string id, Book bookIn);

        public void Remove(Book bookIn);

        public void Remove(string id);
    }
}
