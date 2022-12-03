using Fluffy.Contracts;
using System.Collections.Generic;
using WebApplication3.Data;
using WebApplication3.Models;

namespace Fluffy.Services
{
    public class CatService : ICatService
    { 

        private FluffyDbContext dbContext;
        public CatService(FluffyDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        public void Add(ICatService cat)
        {
            throw new NotImplementedException();
        }

        public void Create(Cat cat)
        {
          this.dbContext.Add(cat);

            this.dbContext.SaveChanges();   
        }

        public List<Cat> GetAll()
        {
            //return new List<Cat>() { new Cat() { Age = 2, Name = "Tom", URL = @"https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.webmiastoto.com%2F%25D1%2581%25D0%25BF%25D0%25B0%25D1%2581%25D1%258F%25D0%25B2%25D0%25B0%25D0%25BD%25D0%25B5%25D1%2582%25D0%25BE-%25D0%25BD%25D0%25B0-%25D0%25B5%25D0%25B4%25D0%25BD%25D0%25B0-%25D1%2583%25D0%25BB%25D0%25B8%25D1%2587%25D0%25BD%25D0%25B0-%25D0%25BA%25D0%25BE%25D1%2582%25D0%25BA%25D0%25B0%2F&psig=AOvVaw0ul6ltBdglUqtmbQtKhjZU&ust=1668421645834000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCLC3vIz5qvsCFQAAAAAdAAAAABAE" } };
            //new Cat() { Age = 3, Name = "Linda", URL = @"https://www.google.com/imgres?imgurl=https%3A%2F%2Fspasime.org%2Fwp-content%2Fuploads%2F2015%2F04%2FAnimals___Cats_Cats_play_on_the_street_041945_-1.jpg&imgrefurl=https%3A%2F%2Fspasime.org%2F%25D1%2583%25D0%25BB%25D0%25B8%25D1%2587%25D0%25BD%25D0%25B0-%25D0%25B8%25D0%25BB%25D0%25B8-%25D0%25BF%25D0%25BE%25D1%2580%25D0%25BE%25D0%25B4%25D0%25B8%25D1%2581%25D1%2582%25D0%25B0-%25D0%25BA%25D0%25BE%25D1%2582%25D0%25BA%25D0%25B0-spasi-me%2F&tbnid=xZd_SkZxznQz2M&vet=12ahUKEwjRhYvo-ar7AhXKt6QKHedzA7IQMygHegUIARDIAQ..i&docid=Eb2i_C08SuPVnM&w=752&h=450&q=%D1%83%D0%BB%D0%B8%D1%87%D0%BD%D0%B0%20%D0%BA%D0%BE%D1%82%D0%BA%D0%B0&ved=2ahUKEwjRhYvo-ar7AhXKt6QKHedzA7IQMygHegUIARDIAQ" };
            return this.dbContext.Cats.ToList();
        }
        
        public Cat GetCat(int id)
        {
           var cat= this.dbContext.Cats.Find(id);
          

            if(cat == null)
            {
                throw new ArgumentException("There is no cat with such an id");
            }
            return cat;
        }
    }
}
