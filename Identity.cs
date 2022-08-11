using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    class Identity
    {
        string name;
        string surname;
        string born;
        int age;
        char gender;

        public string NAME
        {
            get { return name; }
            set { name = value.ToLower(); }
        }
        public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }
        public string BORN
        {
            get { return born;}
            set { born = value; }

        }
        public int AGE
        {
            get { return age; }
            set { age = Math.Abs(value); }
        }

        public char GENDER
        {
            get { return gender; }
            set { gender = value; }
        }

        public Identity()
        {
            name = "";
            surname = "";
            age = 18;
            gender = 'f';
            born = "New York";

        }
    }
}
