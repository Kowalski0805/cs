using System;
using System.Linq;
using System.Collections.Generic;

namespace App {
    class Student : Person, ICloneable {
        public enum Education {
            Master,
            Bachelor,
            SecondEducator,
            PhD
        }

        private Education _education;
        private string _group;
        private int _cardNumber;
        private List<Examination> _exams;
        private float _average {
            get {
                int sum = 0;
                foreach (Examination exam in _exams) {
                    sum += exam._mark;
                }
                return sum/_exams.Count;
            }
        }

        public Student() : base("Ім'я", "Прізвище", new DateTime(1970, 1, 1)) {
            _education = Education.Bachelor;
            _group = "Група";
            _cardNumber = 111111;
            _exams = new List<Examination>{};
        }
        public Student(string name, string surname, DateTime birthday, Education education, string group, int cardNumber, List<Examination> exams) : base(name, surname, birthday) {
            _education = education;
            _group = group;
            _cardNumber = cardNumber;
            _exams = exams;
        }
        public void AddExams(List<Examination> exams) {
            _exams.AddRange(exams);
        }

        public override string ToString() {
            return _name + ' ' + _surname + ' ' + _group;
        }

        public override void PrintFullInfo() {
            Console.WriteLine("Ім'я: " + _name + " " + _surname + " | Освіта: " + _education + " | День народження: " + _birthday.ToShortDateString() + " | Група: " + _group + " | Залікова: " + _cardNumber + " | Екзамени: " + _exams.Aggregate("", (acc, e) => acc + e.ToString() + ", ") + " | Сер.бал: " + _average);
        }

        public object Clone() {
            List<Examination> exams = new List<Examination>(_exams);
            return new Student(_name, _surname, _birthday, _education, _group, _cardNumber, exams);
        }

        public IEnumerable<Examination> NotMarked() {
            foreach (Examination exam in _exams) {
                if (exam._isMarked) yield return exam;
            }
        }

        public List<Examination> getSortedExams() {
            return _exams.OrderBy(si => si._subject).ToList();
        }
    }
}