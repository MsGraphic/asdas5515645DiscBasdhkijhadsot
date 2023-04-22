using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus.VoiceNext;

namespace DiscordBot.Comands
{
    public class SlashCommands : ApplicationCommandModule
    {
        [SlashCommand("Test", "Testing Command")]
        public async Task TestCommand(InteractionContext cx) 
        {
           
            await cx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Success!"));
        }
        [SlashCommand("Game", "Role Command")]
        public async Task RoleGame(InteractionContext cx)
        {
            var role = cx.Guild.GetRole(1099056992665993368);
            await cx.Member.GrantRoleAsync(role);
            await cx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("You got the role"));
        }
        [SlashCommand("Tokens", "Role Command")]
        [SlashCommandPermissions(Permissions.ChangeNickname)]
        public async Task RoleTokens(InteractionContext cx)

        {
            var role = cx.Guild.GetRole(1099056992665993368);
            await cx.Member.GrantRoleAsync(role);
            await cx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("You got the role"));
        }
        [SlashCommand("Purge","Deletes Messages")]
        [SlashCommandPermissions(Permissions.ManageChannels)]
        public async Task PurgeChat(InteractionContext cx, [Option("Quanity", "Deletes a Massage")]long amount)
        {
            var messages = await cx.Channel.GetMessagesAsync((int)amount);

            await cx.Channel.DeleteMessagesAsync(messages);
            const int delay = 3000;
            await cx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent($"Purge completed. **** This Message will be deleted in {delay / 1000} Seconds ****"));
            await Task.Delay(delay);
            await cx.DeleteResponseAsync();

        }

    }
}
