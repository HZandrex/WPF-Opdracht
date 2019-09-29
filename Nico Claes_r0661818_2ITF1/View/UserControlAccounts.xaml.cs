using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Nico_Claes_r0661818_2ITF1.View
{
    /// <summary>
    /// Interaction logic for UserControlAccounts.xaml
    /// </summary>
    public partial class UserControlAccounts : UserControl
    {
        public UserControlAccounts()
        {
            InitializeComponent();
            InitializeData();
            //accountListView.SelectedItem = null;
        }

        private void InitializeData()
        {
            //Bitmap original = new Bitmap("resources/images/grade_icon.tga");
            //System.Drawing.Rectangle srcRect = new System.Drawing.Rectangle(0, 0, 64, 64);
            //Bitmap cropped = (Bitmap)original.Clone(srcRect, original.PixelFormat);
        }
    }
}
