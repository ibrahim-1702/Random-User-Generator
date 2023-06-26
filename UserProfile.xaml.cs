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
    /// Interaction logic for UserProfile.xaml
    /// </summary>
    public partial class UserProfile : Window
    {
        public UserProfile()
        {
            InitializeComponent();
            Choice gen = new Choice();
            RandomUser user = new RandomUser(Choice.gender);
            user.GenerateUser();
            UserNameLB.Content = (RandomUser.Name);
            UserMailLB.Content = Convert.ToString(RandomUser.Mail);
            CreateViewImageDynamically(RandomUser.PPpath);
            BG.Content = RandomUser.BG;
            PhLB.Content = RandomUser.Phone;
            LocLB.Content = RandomUser.Loc;
        }
        private void CreateViewImageDynamically(string path)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(path);
            bitmap.EndInit();
            ImageB.Source = bitmap;

        }  
    }
}
