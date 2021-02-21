using StudentRatingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentRatingSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class StudentSystem : IStudentSystem
    {
        StudentRate context;
        StudentSystem() {
            context = new StudentRate();
        }
        //########################################################################## Students
        public string AddStudent(Student Student) 
        {
            context.Student.Add(Student);
            context.SaveChanges();
            return "Student Added";
        }
        public string UpdateStudent(int id,Student Student)
        {
            Student Student_= context.Student.Find(id);
            Student_.Student_Name = Student.Student_Name;
            Student_.Student_CPI = Student.Student_CPI;
            Student_.Student_Branch = Student.Student_Branch;
            context.SaveChanges();
            return "Student Updated";
        }
        public string DeleteStudent(int id)
        {
            Student m=context.Student.Find(id);
            context.Student.Remove(m);
            context.SaveChanges();
            return "Deleted SuccessFully";
        }
        public IEnumerable<Student> ShowStudent()
        {
            IEnumerable<Student> list =context.Student.ToList();
            return list;
        }
        //########################################################################## Users
        public string AddUser(SystemUser user)
        {
            context.SystemUsers.Add(user);
            context.SaveChanges();
            return "User Added";
        }
        public string UpdateUser(int id, SystemUser user)
        {
            SystemUser user_ = context.SystemUsers.Find(id);
            user_.User_Name = user.User_Name;
            user_.User_Password = user.User_Password;
            context.SaveChanges();
            return "User Updated";
        }
        public string DeleteUser(int id)
        {
           SystemUser user= context.SystemUsers.Find(id);
            context.SystemUsers.Remove(user);
            context.SaveChanges();
            return "Deleted SuccessFully";
        }
        public IEnumerable<SystemUser> ShowUser()
        {
            IEnumerable<SystemUser> list = context.SystemUsers.ToList();
            return list;
        }
        public string Verify_User(String username, string password) {
            SystemUser user = context.SystemUsers.FirstOrDefault(x => x.User_Name == username && x.User_Password == password);
            if (user != null)
            {
                string des = user.User_Designation.ToString();
                string id__ = user.UserId.ToString();
                return des+" "+id__;
            }
            else {
                return "Invalide Username Or Password";
            }

        }
        //########################################################################## Ratings
        public string AddRating(User_Rating rate)
        {
            context.User_Ratings.Add(rate);
            context.SaveChanges();
            return "Ratings Added";
        }
        public string UpdateRating(int id, RatinDto Student)
        {
            User_Rating rate = context.User_Ratings.Find(id);
            rate.StudentName = Student.StudentName;
            rate.User_Provided_Rating = Student.User_Provided_Rating;
            context.SaveChanges();
            return "Ratings Updated";
        }
        public string DeleteRating(int id)
        {
            User_Rating Student = context.User_Ratings.Find(id);
            context.User_Ratings.Remove(Student);
            context.SaveChanges();
            return "Ratings Deleted SuccessFully";
        }
        public IEnumerable<RatinDto> ShowRating()
        {
            IEnumerable<RatinDto> list = context.User_Ratings.Select(  x=> new RatinDto(){User_Rarting_Id=x.User_Rarting_Id,UserId=x.UserId ,StudentName=x.StudentName,User_Provided_Rating=x.User_Provided_Rating }  ).ToList();
            return list;
        }
        public IEnumerable<RatinDto2> ShowRating_short()
        {
            IEnumerable<RatinDto2> list = context.User_Ratings.Select(x => new RatinDto2() {  StudentName = x.StudentName, User_Provided_Rating = x.User_Provided_Rating }).ToList();
            return list;
        }
        public IEnumerable<RatinDto2> ShowRating_Persional(int id)
        {
            IEnumerable<RatinDto2> list = context.User_Ratings.Where(x=>x.UserId==id).Select(x => new RatinDto2() { StudentName = x.StudentName, User_Provided_Rating = x.User_Provided_Rating }).ToList();
            return list;
        }
        public IEnumerable<RatinDto3> ShowRating_Log(int id)
        {
            IEnumerable<RatinDto3> list = context.User_Ratings.Where(x => x.UserId == id).Select(x => new RatinDto3() { User_Rarting_Id=x.User_Rarting_Id,StudentName = x.StudentName, User_Provided_Rating = x.User_Provided_Rating }).ToList();
            return list;
        }
        public IEnumerable<string> getStudent_Name() {

            return context.Student.Select(x => x.Student_Name).ToList();
        }
    }
}
