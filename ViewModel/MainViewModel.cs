using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using thirdsentyabrya.Model;
using thirdsentyabrya.Util;

namespace thirdsentyabrya.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<DayModel> _days;
        public ObservableCollection<DayModel> Days
        {
            get => _days;
            set
            {
                _days = value;
            }
        }

        public ICommand PreviousMonthCommand { get; private set; }
        public ICommand NextMonthCommand { get; private set; }

        public MainViewModel()
        {
            Days = new ObservableCollection<DayModel>();
            PreviousMonthCommand = new RelayCommand(PreviousMonth);
            NextMonthCommand = new RelayCommand(NextMonth);
            LoadDays();
        }

        private void LoadDays()
        {
            // TODO сделать
        }

        private void PreviousMonth()
        {
            // TODO сделать
        }

        private void NextMonth()
        {
            // TODO сделать
        }
    }
}
