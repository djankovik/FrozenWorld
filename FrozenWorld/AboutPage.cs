using FrozenWorld.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrozenWorld
{
    public partial class AboutPage : Form
    {
        public AboutPage()
        {
            InitializeComponent();

            pbFrozenWorld.Width = Resources.fw_80.Width;
            pbFrozenWorld.Height = Resources.fw_80.Height;
            pbFrozenWorld.BackgroundImage = Resources.fw_80;
            pbFrozenWorld.Image = Resources.fw_80;

            pbGamePlay.Width = Resources.gameplay_40.Width;
            pbGamePlay.Height = Resources.gameplay_40.Height;
            pbGamePlay.Image = Resources.gameplay_40;

            pbGamePlay.Width = Resources.gameplay_40.Width;
            pbGamePlay.Height = Resources.gameplay_40.Height;
            pbGamePlay.Image = Resources.gameplay_40;

            pbHazards.Width = Resources.hazards_40.Width;
            pbHazards.Height = Resources.hazards_40.Height;
            pbHazards.Image = Resources.hazards_40;

            pbSnowflakes.Width = Resources.snowflakes_40.Width;
            pbSnowflakes.Height = Resources.snowflakes_40.Height;
            pbSnowflakes.Image = Resources.snowflakes_40;

        }
    }
}
