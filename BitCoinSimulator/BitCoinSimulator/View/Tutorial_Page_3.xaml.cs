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
    /// Tutorial_Page_3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Tutorial_Page_3 : Page
    {
        static int current_idx = 0;
        public Tutorial_Page_3()
        {
            InitializeComponent();
        }
        private void Tutorial_Chat_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tutorial_Chat.Content = Scene_3(current_idx);
            current_idx++;
        }
        public string Scene_3(int idx)
        {

            if (idx == 0)
            {
                return "\n [???] 어우 독한놈 이제 일어났네";
            }
            if (idx == 1)
            {
                return "\n [간호사] 어... 환자분 일어나셨군요~ 딱히 이상은 없었으니깐 퇴원하시면 됩니다.";
            }
            if (idx == 2)
            {
                return "\n 퇴원 수속을 해야 하는데 난 수중에 돈이 없다... 어쩌지";
            }
            if (idx == 3)
            {
                return "\n [???} 지금 돈 걱정 하는거야? 걱정하지마 내가 처리했으니까";
            }
            if (idx == 4)
            {
                return "\n 뭐하는 인간이지? 왜 나를 돕는걸까";
            }
            if (idx == 5)
            {
                return "\n["+Properties.Save_Data.Default.username+ "] 누구신데 저한테 이렇게 잘 해주세요?";
            }
            if (idx == 6)
            {
                return "\n [???] 나? ";
            }
            if (idx == 7)
            {
                return "\n [???] 빚쟁이야 이거 공짜 아니야";
            }
            if (idx == 8)
            {
                return "\n 와 씨 얏댔다...";
            }
            if (idx == 9)
            {
                return "\n [???] 꼬라지 보아하니 돈도 없는거 같은데 빌려줄테니깐 이자까지 갚아라 그 전까지는  ";
            }
            if (idx == 10)
            {
                Properties.Save_Data.Default.balance += 100000000;
                return "\n [???] 1억 빌려줄께~ 5일 마다 이자 받을거니까 그렇게 알아~";
            }
            if (idx == 11)
            {
                //메인 페이지 진입
                //Page Tuto = new Tutorial_Page_2();
                //Application.Current.MainWindow.Content = Tuto;
                MessageBox.Show("꾸하아항");
                return "";
            }
            else
            {
                return "";
            }
        }
    }

}