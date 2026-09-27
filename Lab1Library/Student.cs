namespace Lab1Library
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Id { get; set; }

        public string Group { get; set; }

        public Student()
        {

        }

        public Student(string name, string surname, string id, string group)
        {
            if(name.Length == 0 || surname.Length == 0 || id.Length == 0 || group.Length == 0)
            {
                throw new Exception("Invalid student data");
            }
            Name = name;
            Surname = surname;
            Id = id;
            Group = group;
        }

        public override string ToString() 
        {
            return Id + " " + Name +  " " + Surname + " " + Group;
        }
    }
}
