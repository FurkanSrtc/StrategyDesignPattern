using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _StrategyDesignPatern.Strategy
{
    public interface IGun
    {
        void Fire();
        void Draw();
        int Bullets { get; set; }
        PictureBox GunBox { get; set; }
        PictureBox BulletBox { get; set; }
    }
}
