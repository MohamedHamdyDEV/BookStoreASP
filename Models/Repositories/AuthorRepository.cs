using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    public class AuthorRepository : IBookstoreRepository<Author>

    {
        IList<Author> authors;
        public AuthorRepository()
        {
            authors = new List<Author>()
            {
                new Author {Id = 1, FullName="Mohamed Hamdy"},
                new Author {Id = 2, FullName="Ahmed Hamdy"},
                new Author {Id = 3, FullName="HOssam Hamdy"},
            };
        }
        public void Add(Author entity)
        {
           authors.Add(entity);
        }

        public void Delete(int id)
        {
            var author = Find(id);
        }

        public Author Find(int id)
        {
            var author =authors.SingleOrDefault(a => a.Id ==id);
            return author;
        }

        public IList<Author> List()
        {
            return authors;
        }

        public void Update(int id, Author newAuthor)
        {
           var author = Find(id);
           
            author.FullName = newAuthor.FullName;
        }
    }
}
