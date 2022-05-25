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

namespace BitCoinSimulator.View
{
    /// <summary>
    /// Tutorial_Page_2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Tutorial_Page_2 : Page
    {
        static int current_idx = 0;
        public Tutorial_Page_2()
        {
            InitializeComponent();
        }
        private void Tutorial_Chat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tutorial_Chat.Content = Scene_2(current_idx);
            current_idx++;
        }
        public string Scene_2(int idx)
        {

            if (idx == 0)
            {
                
                return "\n나는 내가 부자가 될거라 믿었다 하하하...";
            }
            if (idx == 1)
            {
                return "\n군대에서 그 선임놈 말을 듣고 혹하는게 아니였는데...";
            }
            if (idx == 2)
            {
                return "\n대교 난간을 넘어가려는 그 때..";
            }
            if (idx == 3)
            {
                return "\n[???] 저기요~";
            }
            if (idx == 4)
            {
                return "\n누가 날 부르지만 그게 뭔 상관인가";
            }
            if (idx == 5)
            {
                return "\n[???] 와 독한놈 뒤도 안돌아보네";
            }
            if (idx == 6)
            {
                tutorial_back.Background = Brushes.Black;
                return "\n 내 돈을 모두 가져간 망할 세상 다 망했으면";
            }
            if (idx == 7)
            {
               return "\n 풍덩 소리와 함께 몸이 점점 차가워진다";
                
            }
            if (idx == 8)
            {
                return "\n...";
                
            }
            if (idx == 9)
            {
                return "\n 뭐야 왜 안끝나지?";
            }
            if (idx == 10)
            {
                return "\n [???] 언제까지 잘꺼야!! 일어나라 이제";
            }
            if (idx == 11)
            {
                Page Tuto = new Tutorial_Page_3();
                Application.Current.MainWindow.Content = Tuto;
                return "";
            }
            else
            {
                return "";
            }
        }
    }
}
