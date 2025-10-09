using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek6
{
    public partial class Form1 : Form
    {
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();

        Timer timer = new Timer();
        bool toCenter = true; // Merkez kontrolü
        int step = 5; // adım boyuut


        Point pos1, pos2, pos3, pos4; // başlangıçlar

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //form boyutu
            this.ClientSize = new Size(400, 400);
            //ilk konumlar
            btn1.SetBounds(0, 0, 100, 100);
            btn2.SetBounds(300, 0, 100, 100);
            btn3.SetBounds(0, 300, 100, 100);
            btn4.SetBounds(300, 300, 100, 100);

            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            //ilk konumları not al.
            pos1 = btn1.Location;
            pos2 = btn2.Location;
            pos3 = btn3.Location;
            pos4 = btn4.Location;

            timer.Interval = 20;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Point center = new Point(150, 150);

            Point target1 = new Point(center.X - 50, center.Y - 50); // sol üst
            Point target2 = new Point(center.X + 50, center.Y - 50); // sağ üst
            Point target3 = new Point(center.X - 50, center.Y + 50); // sol alt
            Point target4 = new Point(center.X + 50, center.Y + 50); // sağ alt

            //hareket fonksiyonu
            Move(btn1, toCenter ? target1 : pos1);
            Move(btn2, toCenter ? target2 : pos2);
            Move(btn3, toCenter ? target3 : pos3);
            Move(btn4, toCenter ? target4 : pos4);

            // Yön değişim kontrol
            if (btn1.Location == target1)
                toCenter = false;
            else if (btn1.Location == pos1)
                toCenter = true;
        }

        private void Move(Button btn, Point target)
        {
            int dx = Math.Sign(target.X - btn.Left) * step;
            int dy = Math.Sign(target.Y - btn.Top) * step;

            if (Math.Abs(target.X - btn.Left) < step) dx = target.X - btn.Left;
            if (Math.Abs(target.Y - btn.Top) < step) dy = target.Y - btn.Top;

            btn.Location = new Point(btn.Left + dx, btn.Top + dy);
        }
    }
}
