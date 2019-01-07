using System;
using System.Collections.Generic;

namespace App {
    class Examination {
        private byte _semester;
        public string _subject { get; }
        private List<string> _teacher;
        public byte _mark { get; }
        public bool _isMarked { get; }
        private DateTime _date;

        public Examination() {
            _semester = 1;
            _subject = "Предмет";
            _teacher = new List<string>{"Прізвище", "І.Б."};
            _mark = 100;
            _isMarked = true;
            _date = new DateTime(1970, 1, 1);
        }

        public Examination(byte semester, string subject, List<string> teacher, byte mark, bool isMarked, DateTime date) {
            _semester = semester;
            _subject = subject;
            _teacher = teacher;
            _mark = mark;
            _isMarked = isMarked;
            _date = date;
        }

        public override string ToString() {
            return _subject + " " + _teacher[0] + ' ' + _mark;
        }
    }
}