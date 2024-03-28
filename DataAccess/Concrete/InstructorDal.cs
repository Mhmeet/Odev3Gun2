using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InstructorDal : IGenericDal<Instructor>
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            instructors = new List<Instructor>()
            {
                new Instructor(){Id = 1, Name="Engin", LastName="Demirog"}
            };
        }
        public void Add(Instructor entity)
        {
            instructors.Add(entity);
            Console.WriteLine("instructor added!");
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetByID(int id)
        {
            Instructor entity = instructors.FirstOrDefault(x => x.Id == id);
            return entity;
        }

        public void Remove(Instructor entity)
        {
            var instrucorRemove = instructors.FirstOrDefault(entity=>entity.Id == entity.Id);
            if (instrucorRemove != null)
            {
                instructors.Remove(instrucorRemove);
                Console.WriteLine("Removed instructor!");
            }
        }

        public void Update(Instructor entity)
        {
            var instructorUpdate = instructors.FirstOrDefault(i => i.Id == entity.Id);
            if(instructorUpdate != null)
            {
                instructorUpdate.Name = entity.Name;
                instructorUpdate.LastName = entity.LastName;
                Console.WriteLine("instructor updated");
            }
        }
    }
}
