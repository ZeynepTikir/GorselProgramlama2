using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class Form1 : Form
    {
        //taşıma işlemi için değişken lazım,
        private bool tasiniyor = false;
        //konum değişkeni lazım!
        private Point baslangic = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        //Fareye tıklandığında çalışcak
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            tasiniyor = true;              // Taşıma başlasın
            baslangic = e.Location;        // İlk tıklanan nokta kaydedilecek
        }

        //Fare hareket ettiği sürece çalışcak
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tasiniyor) //Doğruysa,
            {
                // Yeni konumunu hesapla:
                // farenin konumla başlangıcın farkını button koordinatlarına ekle.
                button1.Left += e.X - baslangic.X;
                button1.Top += e.Y - baslangic.Y;
            }
        }

        //Fare tıkı bırakıldığında taşımayı bitir.
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
           tasiniyor = false;
        }

        

        
    }
}
