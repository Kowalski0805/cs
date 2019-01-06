using System;

namespace App {
    class Examination {
        private byte _semester;
        private string _subject;
        private string[] _teacher;
        public byte mark { get; }
        private bool _isMarked;
        private DateTime _date;

        public Examination() {
            this._semester = 1;
            this._subject = "Предмет";
            this._teacher = new Array("Прізвище", "І.Б.");
            this._mark = 100;
            this._isMarked = true;
            this._date = new DateTime(1970, 1, 1);
        }

        public Examination(byte semester, string subject, string[] teacher, byte mark, bool isMarked, DateTime date) {
            this._semester = semester;
            this._subject = subject;
            this._teacher = teacher;
            this._mark = mark;
            this._isMarked = isMarked;
            this._date = date;
        }

        public override string ToString() {
            return this._subject + " " + this._teacher[0] + ' ' + this._mark;
        }
    }
}