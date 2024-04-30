using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdsentyabrya.Model
{
    public class DayModel
    {
        public DateTime Date { get; set; }
        public ObservableCollection<ItemModel> SelectedItems { get; set; }
        public string IconPath { get; set; }
    }
}
