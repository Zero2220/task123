using task;
using System.Linq;
using System.Runtime.InteropServices;

Brand brand2 = new Brand() { Name = "asd" };
Create(brand2);

void Create(Brand brand)
{

    using (CourseDbContext context = new CourseDbContext())
    {
        context.Brands.Add(brand);
        context.SaveChanges();
    }
}

List<Brand> Get(int Id)
{
    using(CourseDbContext context = new CourseDbContext())
    {
        return context.Brands.Skip(Id).ToList();
    }
}

void Delete(int Id)
{

    using (CourseDbContext context = new CourseDbContext())
    {
        var data = context.Brands.Find(Id);

        context.Brands.Remove(data);
        
    }
}

void Update(string name)
{
    using (CourseDbContext context = new CourseDbContext())
    {
        var data =context.Brands.Find();

        data.Name = name;
        context.SaveChanges();
    }
}


