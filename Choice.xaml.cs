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
using System.Windows.Shapes;
using RUG;

namespace RandomUserGenerator
{
    /// <summary>
    /// Interaction logic for Choice.xaml
    /// </summary>
    public partial class Choice : Window
    {
        public Choice()
        {
            InitializeComponent();
        }
        public static char gender = new char();
        private void GenerateBT_Click(object sender, RoutedEventArgs e)
        {
            
            
            if ((bool)MaleRB.IsChecked) 
            {
                gender = 'M';
            }
            else if ((bool)FemaleRB.IsChecked)
            {
                gender = 'F';
            }
            else 
            {
                MessageBox.Show("Select One Of The Options");
            }
            UserProfile window = new UserProfile();
            window.Show();
        }
    }
}
