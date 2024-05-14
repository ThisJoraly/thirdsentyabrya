using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using thirdsentyabrya.View;
using thirdsentyabrya.ViewModel.Helpers;

namespace thirdsentyabrya.ViewModel
{
    internal class MainWindowViewModel : BindingHelper
    {
        public BindableCommand PreviouseMonth { get; set; }
        public BindableCommand NextMonth { get; set; }


        public MainWindowViewModel()
        {
            Date = DateTime.Now;

            PreviouseMonth = new BindableCommand(_ => Previouse());
            NextMonth = new BindableCommand(_ => Next());
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
           //Должно перелистываться назад
        }

        public void Next()
        {
            //Должно перелистываться вперёд
        }
    }
}
