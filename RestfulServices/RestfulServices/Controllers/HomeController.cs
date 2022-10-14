using Microsoft.AspNetCore.Mvc;
using RestfulServices.Models;

namespace RestfulServices.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public Student[] arr = new Student[5];
        public HomeController()
        {
            for (int i = 0; i < 5; i++)
            {
                arr[i] = new Student();
                arr[i].name = i.ToString();
            }
        }
        
        [HttpGet]
        public List<Student> GetNames()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < arr.Length; i++)
                students.Add(arr[i]);
            return students;
        }
        [HttpGet("{id}")]
        public Student GetNameById(int id)
        {
            return arr.ElementAt(id);
        }
        [Route("Add")]
        [HttpPost]
        public void Add(Student s)
        {
            arr.Append(new Student { name = s.name });
        }
    }
}
