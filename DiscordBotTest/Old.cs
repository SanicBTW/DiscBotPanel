using DSharpPlus;
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
    public partial class Old : Form
    {
        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();
        public Old()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartBot();
            button1.Enabled = false;
        }
        private void StartBot()
        {
            var disc = new DiscordClient(new DiscordConfiguration()
            {
                Token = Settings.Default.toekn,
                TokenType = TokenType.Bot,
                Intents = DiscordIntents.AllUnprivileged
            });

            disc.ConnectAsync().GetAwaiter().GetResult();
            DiscordBotStatusLabel.Text = "Bot is Online";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Console.WriteLine(textBox1.Text);
            }
        }
    }
}
