using _StrategyDesignPatern.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _StrategyDesignPatern
{
    public partial class Form1 : Form
    {
        private Gamer _gamer;
        private List<IGun> _gunList = new List<IGun>();

        private int _index;

        public Form1()
        {
            InitializeComponent();
            _gunList.Add(new PistolGun(GunBox, BulletBox, flowLayoutPanel1));
            _gunList.Add(new GrenadeLauncherGun(GunBox, BulletBox, flowLayoutPanel1));
            _gunList.Add(new HK416(GunBox, BulletBox, flowLayoutPanel1));
            _gunList.Add(new ACWGun(GunBox, BulletBox,flowLayoutPanel1));
            _gunList.Add(new Assault(GunBox, BulletBox, flowLayoutPanel1));

            _gamer = new Gamer(BulletsLabel);
            _gamer.Gun = _gunList[_index = 0];


        }

        private void ChangeGun_Click(object sender, EventArgs e)
        {
            _index++;
            if (_index >= _gunList.Count)
                _index = 0;

            _gamer.Gun = _gunList[_index];
        }


        Thread thread;
        private void Fire_Click(object sender, EventArgs e)
        {
           
            _gamer.Fire();
            if (EnemyPic.Location.Y>=113&&EnemyPic.Location.Y<=233)
            {
                EnemyPic.Image = Images.enemyyDead;
                thread.Abort();
                DialogResult dialogResult=MessageBox.Show("Tebrikler Düşmanı Öldürdün. \nDevam etmek ister misin? ","You Win", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EnemyPic.Image = Images.enemyy;
                    Control.CheckForIllegalCrossThreadCalls = false;
                    thread = new Thread(new ThreadStart(enemyMove));
                    thread.Start();
             
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

            }
        }

        private void enemyMove()
        {
            int x = EnemyPic.Location.X;
            int y = 445;
            for (;;)
            {
                for (int i = 0; i <= 90; i++)
                {
                    Thread.Sleep(20);
                    Application.DoEvents();
                    y = y - 5;
                    EnemyPic.Location = new Point(x, y);
                }
                for (int i = 90; i >= 0; i--)
                {
                    Thread.Sleep(20);
                    Application.DoEvents();
                    y = y + 5;
                    EnemyPic.Location = new Point(x, y);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnemyPic.Image = Images.enemyy;
            Control.CheckForIllegalCrossThreadCalls = false;
            thread = new Thread(new ThreadStart(enemyMove));
            thread.Start();
          
        }
    }
}
