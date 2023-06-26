using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RUG
{
    
        public class RandomUser
        {
            Random Rand = new Random();
            public bool isMale = false;
            public RandomUser(char Gender)
            {
                if (Gender == 'M')
                    isMale = true;
            }
            public static string  Name = "", BG = "", Mail = "", Phone = "", Loc = "" , PPpath = "";
            string[] Data;

            public void GenerateUser()
            {
                int fCount;
                int SelectOne;
                
                #region ProfilePic
                if (isMale)
                {
                    DirectoryInfo dir = new DirectoryInfo(@"C:\RUG\Users\Male\ProfilePicture");
                    fCount = dir.GetFiles().Length;
                    SelectOne = Rand.Next(1, fCount+1);
                    FileInfo[] arr = dir.GetFiles();

                    PPpath = @"C:\RUG\Users\Male\ProfilePicture\img" + SelectOne + "" + arr[SelectOne-1].Extension;

                }
                else
                {
                    DirectoryInfo dir = new DirectoryInfo(@"C:\RUG\Users\Female\ProfilePicture");
                    fCount = dir.GetFiles().Length;
                    SelectOne = Rand.Next(1, fCount+1);
                    FileInfo[] arr = dir.GetFiles();


                    PPpath = @"C:\RUG\Users\Female\ProfilePicture\img" + SelectOne + "" + arr[SelectOne-1].Extension;
                }
                #endregion

                #region Name

                if (isMale)
                {
                    Data = Convert.ToString(File.ReadAllText(@"C:\RUG\Users\Male\Name.txt")).Split(',');
                }
                else
                {
                    Data = Convert.ToString(File.ReadAllText(@"C:\RUG\Users\Female\Name.txt")).Split(',');
                }
                Name = Convert.ToString(Data[Rand.Next(0, Data.Length)]);
                
                #endregion

                #region BloodGrup
                Data = Convert.ToString(File.ReadAllText(@"C:\RUG\Users\BloodGroups.txt")).Split(',');
                BG = Convert.ToString(Data[Rand.Next(0, Data.Length)]);
                #endregion

                #region Mail
                Data = Convert.ToString(File.ReadAllText(@"C:\RUG\Users\MailID.txt")).Split(',');
                Mail = Convert.ToString(Data[Rand.Next(0, Data.Length)]);
                #endregion

                #region PhoneNumber
                Data = Convert.ToString(File.ReadAllText(@"C:\RUG\Users\Phone.txt")).Split(',');
                Phone = Convert.ToString(Data[Rand.Next(0, Data.Length)]);
                #endregion

                #region Location
                Data = Convert.ToString(File.ReadAllText(@"C:\RUG\Users\Location.txt")).Split('|');
                Loc = Data[Rand.Next(0, Data.Length)];
                #endregion
            }
        }
    
}
