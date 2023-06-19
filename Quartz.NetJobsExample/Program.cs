

using Quartz.NetJobsExample;

List<Student> Studentler = new List<Student>() {
    new Student { StudentNo = 1, Name="Ali", Surname = "Yıldırım", Punishment = false},
    new Student { StudentNo = 2, Name="Veli", Surname = "Gök", Punishment = true},
    new Student { StudentNo = 3, Name="Mehmet", Surname = "Onbaşı", Punishment = false},
    new Student { StudentNo = 4, Name="Ayşe", Surname = "Candar", Punishment = false},
    new Student { StudentNo = 5, Name="Can", Surname = "Köse", Punishment = false},
    new Student { StudentNo = 6, Name="Turgay", Surname = "Arslan", Punishment = false},
    new Student { StudentNo = 7, Name="Faruk", Surname = "Menteş", Punishment = false}
};
 
foreach (var Student in Studentler)
{
    if (Student.Punishment)
    {
        Trigger tetikle = new Trigger();
        tetikle.Student = Student;
        tetikle.LessonTrigger();
    }
}
 
Console.Read();

Console.WriteLine("Hello, World!");