using System;

namespace SQL_Connect
{
    public class Person
    {
        public int PersonID { get; }
        public string FullName { get; }

        public Person(int personId, string fullname)
        {
            PersonID = personId;
            FullName = fullname ?? throw new ArgumentNullException(nameof(fullname));
        }
    }
}
