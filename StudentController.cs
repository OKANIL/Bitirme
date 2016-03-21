public class StudentController : ApiController
 {
    //Burada öğrencilerimiz üzerine kayıtlar giriyoruz
    //ve bunları ekranda göstereceğiz
    Student[] students = new Student[]
    {
      new Student { StudentNo = 1 },
      new student { studentNo = 2 }
      
  };
 
   // GET api/
   //Bu metod ile tüm student çekilecektir
     public IEnumerable<student> Get_Tumstudent()
     {
        return student;
     }
 
   // GET api//3
   //Örneğin 3 yazarak, studentNo'su 3 olan kişi çekilecektir.
     public student Get_studentNoileGetir(int id)
     {
        var student = student.FirstOrDefault((p) => p.studentNo == id);
        if (student == null)
        {
          throw new HttpResponseException(HttpStatusCode.NotFound);
        }
          return student;
     }
 
    
    }
