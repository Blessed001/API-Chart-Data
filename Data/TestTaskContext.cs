using Microsoft.EntityFrameworkCore;
using TestTask.Models;

namespace TestTask.Data
{
    public class TestTaskContext : DbContext
    {
        public TestTaskContext(DbContextOptions<TestTaskContext> options)
            : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dataa> Dates { get; set; }
        public DbSet<Circle1> Circle1s { get; set; }
        public DbSet<Circle2> Circle2s { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    //seed Dates
        //    modelBuilder.Entity<Dataa>().HasData( new Dataa { DataId =1, Year= 2017});
        //    modelBuilder.Entity<Dataa>().HasData( new Dataa { DataId =2, Year= 2018});
        //    modelBuilder.Entity<Dataa>().HasData( new Dataa { DataId =3, Year= 2019});

        //    //seed Circles
        //    modelBuilder.Entity<Circle1>().HasData(new Circle1 { Circle1Id = 1, value=12, maxValue = 100, DataId = 1 });
        //    modelBuilder.Entity<Circle2>().HasData(new Circle2 { Circle2Id = 1, value=13, maxValue = 90, DataId = 1 });
        //    modelBuilder.Entity<Circle1>().HasData(new Circle1 { Circle1Id = 2, value=12, maxValue = 60, DataId = 2 });
        //    modelBuilder.Entity<Circle2>().HasData(new Circle2 { Circle2Id = 2, value=12, maxValue = 40, DataId = 2 });
        //    modelBuilder.Entity<Circle1>().HasData(new Circle1 { Circle1Id = 3, value=12, maxValue = 75, DataId = 3 });
        //    modelBuilder.Entity<Circle2>().HasData(new Circle2 { Circle2Id = 3, value=12, maxValue = 12, DataId = 3 });

        //    //seed Categories
        //    modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Value = 9, MaxValue = 50, Title="Cat1"});
        //    modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Value = 9, MaxValue = 50, Title="Cat2"});
        //    modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Value = 9, MaxValue = 50, Title="Cat3"});
        //    modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Value = 9, MaxValue = 50, Title="Cat4"});
        //    modelBuilder.Entity<Category>().HasData(new Category { Id = 5, Value = 9, MaxValue = 50, Title="Cat5"});
        //    modelBuilder.Entity<Category>().HasData(new Category { Id = 6, Value = 9, MaxValue = 50, Title="Cat6"});

        //}
    }
}