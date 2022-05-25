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
    /// Tutorial_Page.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Tutorial_Page : Page
    {
        static int current_idx = 0;
        public Tutorial_Page()
        {
             
            InitializeComponent();
        }
        private void Tutorial_Chat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tutorial_Chat.Content=Scene_1(current_idx);
            current_idx++;
        }
        public string Scene_1(int idx)
        {

            if (idx == 0)
            {
                return "\n [만이범 병장] 야.";
            }
            if (idx == 1)
            {
                return "\n [나] ㅇ... ㅖ... 옙!!!!";
            }
            if (idx == 2)
            {
                return "\n [만이범 병장] 뭐? 예? 정신 안차리나? 관등성명 안 배워왔어?";
            }
            if (idx == 3)
            {
                Tutorial_Chat.Content = "\n [나] 이....이병!";
                Window set_window = new SetNameWindow();
                set_window.ShowDialog();
            }
            if (idx == 4)
            {
                return "\n [만이범 병장] 에휴...  정신차리고 다녀라";
            }
            if (idx == 5)
            {
                return "\n [만이범 병장] 야 심심한데 여자친구 있냐? 어떻게 만났는지 얘기좀 해봐라";
            }
            if (idx == 6)
            {
                return "\n [나] 이...이병!!";
            }
            if (idx == 7)
            {
                return "\n [만이범 병장] 됐다 치우고 여자친구 있냐고";
            }
            if (idx == 8)
            {
                return "\n [나] 없습니다!!";
            }
            if (idx == 9)
            {
                return "\n [만이범 병장] 씁... 재미없는 놈";
            }
            if (idx == 10)
            {
                return "\n [만이범 병장] 아 그럼 너 비트코인 해봤냐?";
            }
            if (idx == 11)
            {
                return "\n [만이범 병장] 내가 이번에 좀 땡겼거든";
            }
            if (idx == 12)
            {
                return "\n [나] 오오 얼마나 많이 버신겁니까?";
            }
            if (idx == 13)
            {
                return "\n [만이범 병장] 별건아니고~ 나가서 외제차 하나 뽑을정도?";
            }
            if (idx == 14)
            {
                return "\n [나] 와아... 대단하심다!";
            }
            if (idx == 15)
            {
                return "\n [만이범 병장]  지금 도지코인인가? 그게 그렇게 뜬다던데 너도 해봐";
            }
            if (idx == 16)
            {
                return "\n [나] 옙! 이병 " + Properties.Save_Data.Default.username + "!!!" + "꼭 많이 벌어서 부자 되겠습니다!";
            }
            if (idx == 17)
            {
                return "\n [만이범 병장] 그래라, 으 춥다 이제 들어가자~";
            }
            else if (idx == 18)
            {
                tutorial_back.Background = Brushes.Black;
                return "\n 그렇게 나는  입대 전에 아르바이트로 모은 돈, 군인 월급을 전부 날렸다....";
            }
            if (idx == 19)
            {
                Page Tuto = new Tutorial_Page_2();
                Application.Current.MainWindow.Content = Tuto;
                return "";
            }
            else
            {
                return "\n [나] 이병!" + Properties.Save_Data.Default.username + "!!!!!!";
            }
        }
    }

}
