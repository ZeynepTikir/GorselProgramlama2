using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        List<int> butonSayilari = new List<int>();
        List<Button> tiklananButonlar = new List<Button>();
        int kalanSure = 60;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            panelOyun.Controls.Clear();
            butonSayilari.Clear();
            tiklananButonlar.Clear();
            listBoxKayit.Items.Clear();
            kalanSure = 60;
            lblSure.Text = "60 SN";

            timer1.Start();

            for (int i = 0; i < 10; i++)
            {
                int s = rnd.Next(1, 101);
                butonSayilari.Add(s);

                Button btn = new Button();
                btn.Text = s.ToString();
                btn.Width = 60;
                btn.Height = 40;
                btn.Tag = s;
                btn.BackColor = Color.White;
                btn.Location = new Point(
                    rnd.Next(10, panelOyun.Width - 70),
                    rnd.Next(10, panelOyun.Height - 50)
                );

                btn.Click += SayiButon_Click;
                panelOyun.Controls.Add(btn);
            }
        }

        private void SayiButon_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;
            tiklanan.Visible = false;
            tiklananButonlar.Add(tiklanan);
          
            listBoxKayit.Items.Add((int)tiklanan.Tag);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            kalanSure--;
            lblSure.Text = $"{kalanSure} SN";

            if (kalanSure <= 0)
            {
                timer1.Stop();
                KontrolEt(sureDoldu: true);
            }

            foreach (var btn in panelOyun.Controls.OfType<Button>())
            {
                if (!btn.Visible) continue;

                btn.Location = new Point(
                    rnd.Next(0, panelOyun.Width - btn.Width),
                    rnd.Next(0, panelOyun.Height - btn.Height)
                );
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            KontrolEt();
        }

        private void KontrolEt(bool sureDoldu = false)
        {
            List<int> dogruSiraliCiftler = new List<int>();
            for (int i = 0; i < butonSayilari.Count; i++)
            {
                int sayi = butonSayilari[i];
                if (sayi % 2 == 0)
                    dogruSiraliCiftler.Add(sayi);
            }

            for (int i = 0; i < dogruSiraliCiftler.Count - 1; i++)
            {
                for (int j = 0; j < dogruSiraliCiftler.Count - i - 1; j++)
                {
                    if (dogruSiraliCiftler[j] > dogruSiraliCiftler[j + 1])
                    {
                        int temp = dogruSiraliCiftler[j];
                        dogruSiraliCiftler[j] = dogruSiraliCiftler[j + 1];
                        dogruSiraliCiftler[j + 1] = temp;
                    }
                }
            }

            List<int> tiklananCiftler = new List<int>();
            for (int i = 0; i < tiklananButonlar.Count; i++)
            {
                int sayi = (int)tiklananButonlar[i].Tag;
                if (sayi % 2 == 0)
                    tiklananCiftler.Add(sayi);
            }

            // 3️⃣ Doğru mu kontrol et (sıralı mı)
            bool dogruMu = true;
            if (dogruSiraliCiftler.Count != tiklananCiftler.Count)
            {
                dogruMu = false;
            }
            else
            {
                for (int i = 0; i < dogruSiraliCiftler.Count; i++)
                {
                    if (dogruSiraliCiftler[i] != tiklananCiftler[i])
                    {
                        dogruMu = false;
                        break;
                    }
                }
            }

            if (sureDoldu)
            {
                MessageBox.Show("Süre doldu! Doğru tamamlayamadınız.", "Oyun Bitti");
            }
            else if (dogruMu)
            {
                MessageBox.Show($"Doğru tamamladınız! Kalan süre: {kalanSure} saniye", "Tebrikler!");
            }
            else
            {
                MessageBox.Show($"Yanlış tamamladınız! Kalan süre: {kalanSure} saniye", "Oyun Bitti");
            }
        }
    }
}
