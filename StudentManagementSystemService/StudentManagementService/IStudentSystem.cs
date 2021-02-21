using StudentRatingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentRatingSystem
{
    [ServiceContract]
    public interface IStudentSystem
    {
        [OperationContract]
        string AddStudent(Student e);
        [OperationContract]
        string UpdateStudent(int id,Student e);
        [OperationContract]
        string DeleteStudent(int id);
        [OperationContract]
        IEnumerable<Student> ShowStudent();
        [OperationContract]
        string AddUser(SystemUser s);
        [OperationContract]
        string DeleteUser(int id);
        [OperationContract]
        string UpdateUser(int id,SystemUser e);
        [OperationContract]
        IEnumerable<SystemUser> ShowUser();
        [OperationContract]
        string Verify_User(string user, string pass);
        [OperationContract]
        string AddRating(User_Rating s);
        [OperationContract]
        string DeleteRating(int id);
        [OperationContract]
        string UpdateRating(int id,RatinDto e);
        [OperationContract]
        IEnumerable<RatinDto> ShowRating();
        [OperationContract]
        IEnumerable<RatinDto2> ShowRating_short();
        [OperationContract]
        IEnumerable<RatinDto2> ShowRating_Persional(int id);
        [OperationContract]
        IEnumerable<RatinDto3> ShowRating_Log(int id);
        [OperationContract]
        IEnumerable<string> getStudent_Name();
    }

}
