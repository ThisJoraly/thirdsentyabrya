using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdsentyabrya.Model
{
    public class Day
    {
        public DateTime Date { get; set; }
        public List<UserChoice> UserChoices { get; set; } = new List<UserChoice>();
    }
}
