using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System.ComponentModel;
using System.Text.Encodings.Web;

public class Program
{
    private static void Main(string[] args)
    {
        CategoryCRUD();
        Console.WriteLine();
        CourseManager courseManager = new(new CourseDal());

        List<Course> listAll = courseManager.GetAll();
        foreach (Course c in listAll)
        {
            Console.WriteLine(c.Name + " " + c.Description + " " + c.ImageUrl);
        }
        Console.WriteLine();
        var courseDetail = courseManager.GetByID(1);
        Console.WriteLine(courseDetail.Name + "****");

        courseManager.Update(new Course() { Id = 1, Name = "Kotlin", Description = "Başlangıç seviye", ImageUrl = "ktl.jpg" });
        Console.WriteLine(courseDetail.Name + " Degistirilen kurs");
        Console.WriteLine();

        courseManager.Add(new Course() { Id = 7, Name = "Algoritma temelleri", Description = "0'dan ileri seviye", ImageUrl = "algr.jpg" });
        foreach (Course c in listAll)
        {
            Console.WriteLine(c.Name);
        }
        courseManager.Remove(courseDetail);


    }

    private static void CategoryCRUD()
    {
        CategoryManager categoryManager = new(new CategoryDal());

        foreach (var item in categoryManager.GetAll())
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("************");
        Category category1 = new() { Id = 4, Name = "Security" };
        categoryManager.Add(category1);
        foreach (var item in categoryManager.GetAll())
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("************");
        var category2 = categoryManager.GetByID(3);
        Console.WriteLine(category2.Name + " " + category2.Id);

        Console.WriteLine("************");
        Category category3 = new Category() { Id = 3, Name = "Database Systems" }; //idyi değiştirmek istediğimiz categorye göre yazıyoruz
        categoryManager.Update(category3);
        Console.WriteLine(category2.Name + " " + category2.Id);

        Console.WriteLine("************");
        categoryManager.Remove(category2);

        Console.WriteLine("************");
        foreach (var item in categoryManager.GetAll())
        {
            Console.WriteLine(item.Name);
        }
    }
}