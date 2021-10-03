using System;

namespace DatingApp
{
    public class MyData
    {
        public String Name { get; set; }

        public int YearOfBirth { get; set; }

        public int Age => (int)(2021 - YearOfBirth);

        public string Abilties { get; set; }
    }
}
