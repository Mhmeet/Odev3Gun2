using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryDal : IGenericDal<Category>
    {
        List<Category> categories;
        public CategoryDal()
        {
            categories = new List<Category>()
            {
                new Category(){Id = 1, Name="Front-end"},
                new Category(){Id = 2, Name="Back-end"},
                new Category(){Id = 3, Name="Data"},
            };
        }
        public List<Category> GetAll()
        {
            return categories;
        }
        public void Add(Category entity)
        {
            categories.Add(entity);
            Console.WriteLine("New Category added!");
        }


        public void Remove(Category entity)
        {
            var catRemove= categories.Where(c => c.Id == entity.Id).SingleOrDefault();
            if (catRemove != null)
            {
                categories.Remove(catRemove);
                Console.WriteLine("Category removed!");
            }
            else
            {
                Console.WriteLine("Check Id and try again");
            }
        }

        public void Update(Category entity)
        {
            var catUpdate = categories.Where(u => u.Id == entity.Id).SingleOrDefault();
            if (catUpdate != null)
            {
                catUpdate.Name = entity.Name;                
            }
        }

        public Category GetByID(int id)
        {
            var categoryInfo = categories.FirstOrDefault(c => c.Id == id);        
                return categoryInfo;
            
            
        }

    }
}
