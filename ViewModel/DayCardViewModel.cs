using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thirdsentyabrya.Model;
using thirdsentyabrya.ViewModel.Helpers;

namespace thirdsentyabrya.ViewModel
{
    internal class DayCardViewModel : BindingHelper
    {
        public BindableCommand OpenDay { get; }

        public BindableCommand ClearDay { get; }
        public BindableCommand SaveCommand { get; }
        public BindableCommand CancelCommand { get; }

        private Day _selectedDay;
        public Day SelectedDay
        {
            get => _selectedDay;
            set
            {
                if (_selectedDay != value)
                {
                    _selectedDay = value;
                    OnPropertyChanged(nameof(SelectedDay));
                }
            }
        }

        private List<UserChoice> _activities;
        public List<UserChoice> Activities
        {
            get => _activities;
            set
            {
                if (_activities != value)
                {
                    _activities = value;
                    OnPropertyChanged(nameof(Activities));
                }
            }
        }

        public DayCardViewModel()
        {
            OpenDay = new BindableCommand(_ => Open());
            ClearDay = new BindableCommand(_ => Clear());
            SaveCommand = new BindableCommand(_ => SaveChanges());
            CancelCommand = new BindableCommand(_ => Cancel());

            Activities = new List<UserChoice>
    {
        new UserChoice { Name = "Еда", IconPath = "path/to/food_icon.png" },
        new UserChoice { Name = "Питьё", IconPath = "path/to/drink_icon.png" },
        new UserChoice { Name = "Занятия", IconPath = "path/to/activity_icon.png" },
    };

            LoadData();
        }

        public void SaveChanges()
        {
            Serializer.SerializeToJson(SelectedDay, "user_choices.json");
        }

        public void LoadData()
        {
            if (File.Exists("user_choices.json"))
            {
                SelectedDay = Serializer.DeserializeFromJson<Day>("user_choices.json");
            }
        }


        private void Open()
        {
            //Открывается сохранённый день
        }

        private void Cancel()
        {
            LoadData();
        }

        private void Clear()
        {
            SelectedDay.UserChoices.Clear();
            SaveChanges();
        }
    }
}
