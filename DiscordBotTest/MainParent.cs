using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBotTest
{
    public partial class MainParent : Form
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();

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

        private void MainParent_Load(object sender, EventArgs e)
        {
            AllocConsole();
            Console.Title = "Discord Bot Panel Console";
        }
    }
}
