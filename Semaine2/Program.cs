using LINQDataContext;

DataContext dc = new DataContext();

/*
Student? jdepp = (from student in dc.Students
                  where student.Login == "jdepp"
                  select student).SingleOrDefault();

if (jdepp != null)
{
    Console.WriteLine(jdepp.Last_Name + jdepp.First_Name);
}

IEnumerable<Student> students = (from student in dc.Students
                      select student);

foreach (Student student in students)
{
    Console.WriteLine(student.Last_Name + " " + student.First_Name + " : " + student.Student_ID + " "  + student.BirthDate);
}
*/


IEnumerable<Student> students = (from student in dc.Students
                                 where student.BirthDate.Year < 1995
                                 select student);

foreach (Student student in students)
{
    Console.WriteLine(student.Last_Name + " " + student.First_Name + " : " + student.Year_Result + " " + student.Year_Result>=12);
}

