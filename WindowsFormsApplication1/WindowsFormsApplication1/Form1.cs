using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    // partial: class나 구조체, 인터페이스, 메소드의 정의를 둘 이상의 소스 파일로 분할한 경우!!
    // 규모가 큰 프로젝트일 때 하나의 파일에 다수가 접근할 때 사용됨!
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 윈도우 이벤트 핸들러는 모두 같은 형식!!!!
        // sender: 이벤트를 호출하는 객체 참조. (이벤트가 어느객체에서 발생했는지에 대해 참조할 수 있게 해줌)
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("hello world", Font, Brushes.Black, 10, 10);

            e.Graphics.DrawLine(Pens.Red, 20, 20, 200, 20);
            e.Graphics.DrawEllipse(Pens.Black, 20, 30, 100, 100);
            e.Graphics.DrawRectangle(Pens.Black, 150, 20, 100, 100);
        }
    }
}
