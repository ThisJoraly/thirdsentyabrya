using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using thirdsentyabrya.Model;
using thirdsentyabrya.ViewModel.Helpers;

namespace thirdsentyabrya.ViewModel
{
    internal class ListPageViewModel : BindingHelper
    {
        public BindableCommand SaveCommand { get; }
        public BindableCommand CancelCommand { get; }

        public Day SelectedDay { get; set; }

        public List<UserChoice> Activities { get; } = new List<UserChoice>();

        public ListPageViewModel()
        {
            SaveCommand = new BindableCommand(_ => SaveChanges());
            CancelCommand = new BindableCommand(_ => Cancel());
        }

        private void SaveChanges()
        {
            SelectedDay.UserChoices = Activities.Where(a => a.IsSelected).ToList();
            var window = (Window)App.Current.MainWindow;
            window.DialogResult = true;
            window.Close();
        }

        private void Cancel()
        {
            var window = (Window)App.Current.MainWindow;
            window.DialogResult = false;
            window.Close();
        }
    }
}
