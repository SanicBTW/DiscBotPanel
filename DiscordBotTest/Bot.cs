using DiscordBotTest.Commands;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotTest
{
    public class Bot
    {
        public DiscordClient Client { get; private set; }
        public CommandsNextExtension Commands { get; private set; }
        public async Task StartBot(String token)
        {
            var config = new DiscordConfiguration
            {
                Token = token,
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                Intents = DiscordIntents.AllUnprivileged,
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug
            };

            Client = new DiscordClient(config);
            Client.Ready += Client_Ready;

            var commandsConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { Settings.Default.Prefix },
                EnableDms = false,
            };

            Commands = Client.UseCommandsNext(commandsConfig);

            Commands.RegisterCommands<MainCommands>();

            await Client.ConnectAsync();
            await Task.Delay(-1);
        }

        private Task Client_Ready(DiscordClient sender, DSharpPlus.EventArgs.ReadyEventArgs e)
        {
            Settings.Default.IsBotOn = true;
            return Task.CompletedTask;
        }
    }
}
