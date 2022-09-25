//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Övningsuppgifter
//{
//    public class PersonClass
//    {
//        private string _name;

//        public string Name
//        {
//            get { return _name; }
//            set
//            {
//                _name = value;
//                string[] nameSplit = _name.Split(' ');
//                _firstName = nameSplit[0];
//                _lastName = nameSplit[1];
//            }
//        }

//        private string _firstName;

//        public string FirstName
//        {
//            get { return _firstName; }
//            set
//            {
//                _firstName = value;
//                Name = $"{value} {LastName}";
//            }
//        }

//        private string _lastName;

//        public string LastName
//        {
//            get { return _lastName; }
//            set
//            {
//                _lastName = value;
//                Name = $"{FirstName} + {value}";
//            }
//        }



//        public PersonClass(string firstName, string lastName)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Name = $"{firstName} {lastName}";
//        }

//        public override string ToString()
//        {
//            return $"Full name: {Name}, First name: {FirstName}, Last name: {LastName}";
//        }
//    }
//}
