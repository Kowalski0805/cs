using System;

namespace App {
    class Student : Person, ICloneable {
        enum Education {
            Master,
            Bachelor,
            SecondEducator,
            PhD
        }

        private Education Education;
        private string _group;
        private int _cardNumber;
        private Examination[] _exams;
        private readonly float _average {
            get {
                int sum;
                for (byte i = 0; i < _exams.Length; i++) {
                    sum += _exams[i].mark;
                }
                return sum/_exams.Length;
            }
        }

        public Student(string name, string surname, DateTime birthday, Education education, string group, int cardNumber, Examination[] exams) {
            base(name, surname, birthday);
            Education = education;
            _group = group;
            _cardNumber = cardNumber;
            _exams = exams;
        }
        public void AddExams(Examination[] exams) {
            this._exams = this._exams.Concat(exams).ToArray();
        }

        public override ToString() {
            return this._name + ' ' + this._surname + ' ' + this._group;
        }

        public override PrintFullInfo() {
            Console.WriteLine("" + _name + "" + _surname + "" + Education + "" + _birthday.ToShortDateString() + "" + _group + "" + _cardNumber + "" + _exams.ToString() + "" + _average);
        }

        public object Clone() {
            Examination[] exams = new Examination[_exams.Length];
            _exams.CopyTo(exams);
            return new Student()
        }
    }
}