using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Xml.Serialization;

namespace Lab1Library
{
    public class StudentData
    {
        public List<Student> Students { get; private set; }
        public const string DafaultFileName = @"C:\Users\Vitalya\Temp\Lab1\students.xml";

        public StudentData() 
        {
            Students = new List<Student>();
        }

        public void Add(Student newStudent)
        {
            if (newStudent != null)
            {
                Students.Add(newStudent);
            }
        }

        public void Save(string fileName)
        {
            if(fileName.Length == 0) 
            {
                fileName = DafaultFileName;
            }

            var data = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            var serializer = new XmlSerializer(typeof(List<Student>), [typeof(Student)]);

            serializer.Serialize(data, Students);
            data.Close();
        }

        public void Load(string fileName)
        {
            if (fileName.Length == 0)
            {
                fileName= DafaultFileName;
            }

            var data = new FileStream(fileName, FileMode.Open, FileAccess.Read);

            var serializer = new XmlSerializer(typeof(List<Student>), [typeof(Student)]);

            Students.AddRange((List<Student>)serializer.Deserialize(data));

            data.Close();

        }

    }
}
