using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using thirdsentyabrya.View;
using thirdsentyabrya.Model;
using thirdsentyabrya.ViewModel.Helpers;

namespace thirdsentyabrya.ViewModel
{
    internal class MainWindowViewModel : BindingHelper
    {
        public BindableCommand PreviouseMonth { get; set; }
        public BindableCommand NextMonth { get; set; }

        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get => _selectedDate;
            set
            {
                if (_selectedDate != value)
                {
                    _selectedDate = value;
                    OnPropertyChanged(nameof(SelectedDate));
                }
            }
        }

        private List<Day> _days;
        public List<Day> Days
        {
            get => _days;
            set
            {
                if (_days != value)
                {
                    _days = value;
                    OnPropertyChanged(nameof(Days));
                }
            }
        }


        public MainWindowViewModel()
        {
            Date = DateTime.Now;

            PreviouseMonth = new BindableCommand(_ => Previouse());
            NextMonth = new BindableCommand(_ => Next());
        }

        private List<Day> GenerateDays(int year, int month)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);
            var days = new List<Day>();

            for (int i = 1; i <= daysInMonth; i++)
            {
                days.Add(new Day { Date = new DateTime(year, month, i) });
            }

            return days;
        }

        public void Previous()
        {
            Date = Date.AddMonths(-1);
            SelectedDate = Date;
            Days = GenerateDays(Date.Year, Date.Month);
        }



        private DateTime date;
        public DateTime Date
        {
            get => date; 
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged(nameof(date));
                }
            }
        }

        public void Previouse()
        {
            Date = Date.AddMonths(-1);
            SelectedDate = Date;
            Days = GenerateDays(Date.Year, Date.Month);
        }

        public void Next()
        {
            Date = Date.AddMonths(1);
            SelectedDate = Date;
            Days = GenerateDays(Date.Year, Date.Month);
        }
    }
}
