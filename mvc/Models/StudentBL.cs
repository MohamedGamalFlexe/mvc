namespace mvc.Models
{
    public class StudentBL
    {
        List<Student> students;

        public StudentBL()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Ahmed", ImageURL = "1.png" });
            students.Add(new Student() { Id = 2, Name = "Ali", ImageURL = "2.png" });
            students.Add(new Student() { Id = 3, Name = "owdy", ImageURL = "3.png" });
            students.Add(new Student() { Id = 4, Name = "atia", ImageURL = "4.png" });
            students.Add(new Student() { Id = 5, Name = "hend", ImageURL = "5.png" });
        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student? GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

    }
}
