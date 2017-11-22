using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _StrategyDesignPatern.Strategy
{
    public class GrenadeLauncherGun : IGun
    {
        public GrenadeLauncherGun(PictureBox GBox, PictureBox BBox, FlowLayoutPanel FlowPanel)
        {
            _gunBox = GBox;
            _bulletBox = BBox;
            _flowPanel = FlowPanel;
        }
        private FlowLayoutPanel _flowPanel;


        public void Fire()
        {
            if (_bullets==0)
            {
                MessageBox.Show("No bullet!");
                return;
            }

            _bulletBox.Image = Images.Grenade;
            _bulletBox.Left = _gunBox.Left + _gunBox.Width + 5;
            _bulletBox.Top = _gunBox.Top + 60;
            _bulletBox.Show();
            for (int i = 0; i <= 35; i++)
            {
                Thread.Sleep(10);
                Application.DoEvents();
                _bulletBox.Left += _bulletBox.Width / 2;
            }
            foreach (Control item in _flowPanel.Controls)
            {
                item.Hide();
            }
            for (int i = 0; i < _bullets-1; i++)
            {
                PictureBox pbox = new PictureBox();
                pbox.Image = Images.bullet3;
                _flowPanel.Controls.Add(pbox);
            }
            _bullets--;
            _bulletBox.Hide();

        }

        public void Draw()
        {
            foreach (Control item in _flowPanel.Controls)
            {
                item.Hide();
            }
            for (int i = 0; i < _bullets; i++)
            {
                PictureBox pbox = new PictureBox();
                pbox.Image = Images.bullet3;
                _flowPanel.Controls.Add(pbox);
            }

            _gunBox.Image = Images.GrenadeLauncher;

            _gunBox.Width = _gunBox.Image.Width;
            _gunBox.Height = _gunBox.Image.Height;
        }


        private int _bullets = 20;
        public int Bullets
        {
            get
            {
                return _bullets;
            }
            set
            {
                _bullets = value;
            }
        }


        private PictureBox _gunBox;
        public PictureBox GunBox
        {
            get
            {
                return _gunBox;
            }
            set
            {
                _gunBox = value;
            }
        }

        private PictureBox _bulletBox;
        public PictureBox BulletBox
        {
            get
            {
                return _bulletBox;
            }
            set
            {
                _bulletBox = value;
            }
        }
    }
}
