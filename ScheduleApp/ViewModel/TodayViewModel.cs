using ScheduleApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ScheduleApp.ViewModel
{
    internal class TodayViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private TodayModel Today;

        public TodayViewModel()
        {
            Today = new TodayModel();
        }

        public string Time1
        {
            get { return Today.Time1; }
            set
            {
                if (Today.Time1 != value)
                {
                    Today.Time1 = value;
                    OnPropertyChanged(nameof(Time1));
                }
            }
        }

        public string Time2
        {
            get { return Today.Time2; }
            set
            {
                if (Today.Time2 != value)
                {
                    Today.Time2 = value;
                    OnPropertyChanged(nameof(Time2));
                }
            }
        }

        public string Time3
        {
            get { return Today.Time3; }
            set
            {
                if (Today.Time3 != value)
                {
                    Today.Time3 = value;
                    OnPropertyChanged(nameof(Time3));
                }
            }
        }
        public string Time4
        {
            get { return Today.Time4; }
            set
            {
                if (Today.Time4 != value)
                {
                    Today.Time4 = value;
                    OnPropertyChanged(nameof(Time4));
                }
            }
        }
        public string Lesson1
        {
            get { return Today.Lesson1; }
            set
            {
                if (Today.Lesson1 != value)
                {
                    Today.Lesson1 = value;
                    OnPropertyChanged(nameof(Lesson1));
                }
            }
        }
        public string Lesson2
        {
            get { return Today.Lesson2; }
            set
            {
                if (Today.Lesson2 != value)
                {
                    Today.Lesson2 = value;
                    OnPropertyChanged(nameof(Lesson2));
                }
            }
        }
        public string Lesson3
        {
            get { return Today.Lesson3; }
            set
            {
                if (Today.Lesson3 != value)
                {
                    Today.Lesson3 = value;
                    OnPropertyChanged(nameof(Lesson3));
                }
            }
        }
        public string Lesson4
        {
            get { return Today.Lesson4; }
            set
            {
                if (Today.Lesson4 != value)
                {
                    Today.Lesson4 = value;
                    OnPropertyChanged(nameof(Lesson4));
                }
            }
        }
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
