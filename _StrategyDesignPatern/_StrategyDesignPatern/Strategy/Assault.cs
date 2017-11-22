using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _StrategyDesignPatern.Strategy
{
    class Assault : IGun
    {
        public Assault(PictureBox GBox, PictureBox BBox, FlowLayoutPanel FlowPanel)
        {
            _gunBox = GBox;
            _bulletBox = BBox;
            _flowPanel = FlowPanel;
        }
        private FlowLayoutPanel _flowPanel;
        public Assault() { }

        private PictureBox _bulletBox;
        private PictureBox _gunBox;
        private int _bullets = 10;

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

        public void Draw()
        {
            _gunBox.Image = Images.Assault_Rifle;
            _gunBox.Width = _gunBox.Image.Width;
            _gunBox.Height = _gunBox.Image.Height;
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

        }

        public void Fire()
        {
            if (_bullets == 0)
            {
                MessageBox.Show("No bullet!");
                return;
            }

            _bulletBox.Image = Images.bullet2;
            _bulletBox.Left = _gunBox.Left + _gunBox.Width ;
            _bulletBox.Top = _gunBox.Top + 16;
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
    }
}
