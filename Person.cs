using System;
 
namespace App
{
    class Person
    {
        public string _name { get; }
        public string _surname { get; }
        public DateTime _birthday { get; set; }
        public int birthday {
            get { return _birthday.Year; }
            set { _birthday = new DateTime(value, _birthday.Month, _birthday.Day); }
        }

        public Person() {
            _name = "Ім'я";
            _surname = "Прізвище";
            _birthday = new DateTime(1970, 1, 1);
        }

        public Person(string name, string surname, DateTime birthday) {
            _name = name;
            _surname = surname;
            _birthday = birthday;
        }

        public virtual void PrintFullInfo() {
            Console.Write(_name + ' ' + _surname + ' ' + _birthday.ToShortDateString());
        }

        public override bool Equals(object obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }
            
            Person p = (Person) obj;
            // TODO: write your implementation of Equals() here
            if (p._name != _name) return false;
            if (p._surname != _surname) return false;
            if (p._birthday.Year != _birthday.Year) return false;
            if (p._birthday.Month != _birthday.Month) return false;
            if (p._birthday.Day != _birthday.Day) return false;

            return true;
        }

        public static bool operator ==(Person a, Person b) {
            return a.Equals(b);
        }

        public static bool operator !=(Person a, Person b) {
            return !a.Equals(b);
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }
    }
}