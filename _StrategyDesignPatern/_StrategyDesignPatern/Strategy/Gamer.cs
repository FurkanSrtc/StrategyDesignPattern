using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _StrategyDesignPatern.Strategy
{
    public class Gamer
    {
        private Label _bulletsLabel;
        public Gamer(Label bulletsLabel)
        {
            this._bulletsLabel = bulletsLabel;
        }

        private IGun _gun;

        public IGun Gun
        {
            get { return _gun; }
            set { _gun = value; RefreshGunInfo(); }
        }

        private void RefreshGunInfo()
        {
            _gun.Draw();
            ShowbulletsInfo();
        }

        private void ShowbulletsInfo()
        {

            _bulletsLabel.Text = "Bullets: " + _gun.Bullets.ToString();
        }

        public void Fire()
        {
            _gun.Fire();
            ShowbulletsInfo();
        }

    }
}
