using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thirdsentyabrya.ViewModel.Helpers;

namespace thirdsentyabrya.ViewModel
{
    internal class DayCardViewModel : BindingHelper
    {
        public BindableCommand OpenDay { get; }
        public BindableCommand ClearDay { get; }

        public DayCardViewModel() 
        {
            OpenDay = new BindableCommand(_ => Open());
            ClearDay = new BindableCommand(_ => Clear());
        }
        private void Open()
        {
            //Открывается сохранённый день
        }

        private void Clear()
        {
            //Данные очищаются
        }
    }
}
