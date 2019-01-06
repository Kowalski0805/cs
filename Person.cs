using System;
 
namespace App
{

    class Person
    {
        protected string _name, _surname;
        protected DateTime _birthday;
        public DateTime birthday {
            get { return _birthday.Year; }
            set { _birthday.ChangeYear(value); }
        }

        public Person() {
            this._name = "Ім'я";
            this._surname = "Прізвище";
            this._birthday = new DateTime(1970, 1, 1);
        }

        public Person(string name, string surname, DateTime birthday) {
            this._name = name;
            this._surname = surname;
            this._birthday = birthday;
        }

        public virtual void PrintFullInfo() {
            Console.Write(_name + ' ' + _surname + ' ' + _birthday.ToShortDateString());
        }
    }
}