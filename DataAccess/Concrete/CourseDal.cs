using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CourseDal : IGenericDal<Course>
    {
        List<Course> courses;
        public CourseDal()
        {
            courses = new List<Course>()
                {
                new Course()
                {
                Id = 1,
                CategoryId = 1,
                InstructorId = 1,
                Name = "Angular",
                ImageUrl = "ang.jpg",
                Description = "İleri seviye"
                },
                new Course()
                {
                Id =2,
                CategoryId = 1,
                InstructorId = 1,
                Name = "React",
                ImageUrl = "rct.jpg",
                Description = "İleri seviye"
                },
                new Course()
                {
                Id = 3,
                CategoryId = 2,
                InstructorId = 1,
                Name = "C#",
                ImageUrl = "c.jpg",
                Description = "İleri seviye"
                },
                new Course()
                {
                Id = 4,
                CategoryId = 2,
                InstructorId = 1,
                Name = "Java",
                ImageUrl = "jv.jpg",
                Description = "İleri seviye"
                },
                new Course()
                {
                Id = 5,
                CategoryId = 3,
                InstructorId = 1,
                Name = "MsSQL",
                ImageUrl = "ms.jpg",
                Description = "İleri seviye"
                },
                new Course()
                {
                Id = 6,
                CategoryId = 3,
                InstructorId = 1,
                Name = "PostgreSQL",
                ImageUrl = "os.jpg",
                Description = "İleri seviye"
                }

            };
        }
        public void Add(Course entity)
        {
            courses.Add(entity);
            Console.WriteLine("Course Added!");
        }

        public List<Course> GetAll()
        {
            return courses;
            Console.WriteLine("Here are all courses");
        }

        public Course GetByID(int id)
        {
            Course course = courses.FirstOrDefault(c => c.Id == id);
            return course;
        }

        public void Remove(Course entity)
        {
            var courseRemove = courses.Where(c => c.Id == entity.Id).FirstOrDefault();
            if (courseRemove != null)
            {
                courses.Remove(courseRemove);
                Console.WriteLine(courseRemove.Name+" was removed!");
            }
        }

        public void Update(Course entity)
        {
            var courseUpdate = courses.FirstOrDefault(u => u.Id == entity.Id);
            if (courseUpdate != null)
            {
                courseUpdate.Name = entity.Name;
                courseUpdate.Description = entity.Description;
                courseUpdate.ImageUrl = entity.ImageUrl;
                courseUpdate.InstructorId = entity.InstructorId;
                courseUpdate.CategoryId = entity.CategoryId;
                Console.WriteLine("Course Updated!");
            }
        }
    }
}
