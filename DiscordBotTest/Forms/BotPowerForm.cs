using DSharpPlus;
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
    public partial class BotPowerForm : Form
    {
        public BotPowerForm()
        {
            InitializeComponent();
        }

        private void StartBotBTN_Click(object sender, EventArgs e)
        {
            StartBot();
            StartBotBTN.Enabled = false;
            ShutdownBTN.Enabled = true;
        }

        private void ShutdownBTN_Click(object sender, EventArgs e)
        {
            if(StartBotBTN.Enabled == false)
            {
                ShutDownBot();
                ShutdownBTN.Enabled = false;
                StartBotBTN.Enabled = true;
            }
        }

        private void SaveTokenBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.toekn = TokenTXTBox.Text;
            Settings.Default.Save();
        }

        private void DelTokenBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.toekn = null;
            Settings.Default.Save();
        }

        private void BotPowerForm_Load(object sender, EventArgs e)
        {
            if (Settings.Default.IsBotOn == false)
            {
                StartBotBTN.Enabled = true;
                ShutdownBTN.Enabled = false;
            }
            else if (Settings.Default.IsBotOn == true)
            {
                StartBotBTN.Enabled = false;
                ShutdownBTN.Enabled = true;
            }

            TokenTXTBox.Text = Settings.Default.toekn.ToString();
        }

        private async void StartBot()
        {
            Bot what = new Bot();

            if(Settings.Default.toekn != null)
            {
                await what.StartBot(Settings.Default.toekn);
            }
            else if(Settings.Default.toekn == null && TokenTXTBox.Text != null)
            {
                await what.StartBot(TokenTXTBox.Text);
            }
        }

        private void ShutDownBot()
        {
            //Is this bad or something? idk
            if (Settings.Default.toekn != null)
            {
                var disc = new DiscordClient(new DiscordConfiguration()
                {
                    Token = Settings.Default.toekn,
                    TokenType = TokenType.Bot,
                    Intents = DiscordIntents.AllUnprivileged,
                    AutoReconnect = true
                });

                disc.DisconnectAsync().GetAwaiter().GetResult();
                Console.WriteLine("Bot Disconnected I guess");
                Settings.Default.IsBotOn = false;
            }
            else if (Settings.Default.toekn == null && TokenTXTBox.Text != null)
            {
                var disc = new DiscordClient(new DiscordConfiguration()
                {
                    Token = TokenTXTBox.Text,
                    TokenType = TokenType.Bot,
                    Intents = DiscordIntents.AllUnprivileged,
                    AutoReconnect = true
                });

                disc.DisconnectAsync().GetAwaiter().GetResult();
                Console.WriteLine("Bot Disconnected I guess");
                Settings.Default.IsBotOn = false;
            }
        }
    }
}
