using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotTest
{
    public partial class MainParent : Form
    {
        public MainParent()
        {
            InitializeComponent();
        }

        private void BotPowerWindow_Click(object sender, EventArgs e)
        {
            BotPowerForm botPowerForm = new BotPowerForm();
            botPowerForm.MdiParent = this;
            botPowerForm.Text = "Bot Power Window";
            botPowerForm.Show();
        }

        private void ShowStatusBar_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = ShowStatusBar.Checked;
        }
    }
}
