using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using DSharpPlus.VoiceNext;

namespace DiscordBot.Comands
{
    public class BasicComands : BaseCommandModule
    {

        [Command("help")]
        public async Task Help(CommandContext cx)

        {
            if (cx.Channel.Id == 1099302771943022625)
            {
                DiscordEmbedBuilder EmbedHelp = new ()
                {
                    Color = DiscordColor.DarkButNotBlack,
                    Title = $"Help",
                    Description = $" These Are the Command That You can Use",

                };
                EmbedHelp.AddField("Here", $"`Help` : Shows The Commands\n`Hi` : Says Hello\n`Calculate` : Calculates 2 Numbers\n`Game` : Gives You A Game Role");
                await cx.Channel.SendMessageAsync(EmbedHelp).ConfigureAwait(false);
            }
            else
            {
                await cx.Channel.SendMessageAsync("This Type of commands only work in 『🇧​​​​​🇴​​​​​🇹​​​​​ 🇨​​​​​🇴​​​​​🇲​​​​​🇲​​​​​🇦​​​​​🇳​​​​​🇩​​​​​』 ");
            }

        }
        [Command("Hi")]
        public async Task Hi(CommandContext cx)

        {
            if (cx.Channel.Id == 1099302771943022625) 
            { await cx.Channel.SendMessageAsync("Hello!").ConfigureAwait(false); 
            }
            else
            {
                await cx.Channel.SendMessageAsync("This Type of commands only work in 『🇧​​​​​🇴​​​​​🇹​​​​​ 🇨​​​​​🇴​​​​​🇲​​​​​🇲​​​​​🇦​​​​​🇳​​​​​🇩​​​​​』 ");
            }

        }
        [Command("Game")]
        public async Task Game(CommandContext cx)

        {

            DiscordRole NewWorld = cx.Guild.GetRole(1099056992665993368);

            if (cx.Channel.Id == 1099302771943022625)
            {
                await cx.Member.GrantRoleAsync(NewWorld);
                await cx.Channel.SendMessageAsync("Role Granted");

            }
            else
            {
                await cx.Channel.SendMessageAsync("This Type of commands only work in 『🇧​​​​​🇴​​​​​🇹​​​​​ 🇨​​​​​🇴​​​​​🇲​​​​​🇲​​​​​🇦​​​​​🇳​​​​​🇩​​​​​』 ");
            }

        }
        [Command("Calculate")]
        public async Task A(CommandContext cx, int a, int b)

        {
            if (cx.Channel.Id == 1099302771943022625)
            {
                await cx.Channel.SendMessageAsync("Num Is :" + (a + b)).ConfigureAwait(false);
            }
            else
            {
                await cx.Channel.SendMessageAsync("This Type of commands only work in 『🇧​​​​​🇴​​​​​🇹​​​​​ 🇨​​​​​🇴​​​​​🇲​​​​​🇲​​​​​🇦​​​​​🇳​​​​​🇩​​​​​』 ");
            }
            

        }

    }
}
