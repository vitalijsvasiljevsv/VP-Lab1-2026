namespace Lab1Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var studentData = new Lab1Library.StudentData();
                studentData.Load(Lab1Library.StudentData.DafaultFileName);

                foreach (var student in studentData.Students)
                {
                    Console.WriteLine(student);
                }
            }
            catch (Exception ex) 
            { 
                System.Console.WriteLine(ex.Message);
            }
            System.Console.ReadLine();

        }
    }
}
