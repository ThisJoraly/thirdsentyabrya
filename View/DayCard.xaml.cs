using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using thirdsentyabrya.ViewModel;

namespace thirdsentyabrya.View
{
    /// <summary>
    /// Логика взаимодействия для DayCard.xaml
    /// </summary>
    public partial class DayCard : UserControl
    {
        public DayCard()
        {
            InitializeComponent();
            DataContext = new DayCardViewModel();
        }

        private void ButtonDay_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Frame framePage = mainWindow.FramePage;
            framePage.Content = new Frame();
        }
    }
}
