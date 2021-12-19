using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASBlazor.Models;

namespace UASBlazor.Services
{
    public interface IDStudentService
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetbyId(int studentID);
        Task<Student> Add(Student student);
        Task<Student> Update(int studentID, Student student);
        Task<Student> Enroll(int studentID, DateTime waktu, Student student);
        Task Delete(int studentID);


    }
}