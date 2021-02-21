namespace StudentRatingSystem
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using StudentRatingSystem.Model;
    public class StudentRate : DbContext
    {
        // Your context has been configured to use a 'StudentRate' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StudentRatingSystem.StudentRate' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentRate' 
        // connection string in the application configuration file.
        public StudentRate()
            : base("name=StudentRate")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<User_Rating> User_Ratings { get; set; }

        public virtual DbSet<SystemUser> SystemUsers { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}