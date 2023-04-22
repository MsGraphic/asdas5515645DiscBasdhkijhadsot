using DSharpPlus;
using DSharpPlus.Interactivity;
using DSharpPlus.CommandsNext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using DSharpPlus.EventArgs;
using System.Threading;
using DiscordBot.Comands;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using DSharpPlus.VoiceNext;

namespace DiscordBot
{
    public class Bot
    {
        
        DiscordChannel Logchannel = null;
        DiscordChannel Welcomechannel = null;
        DiscordChannel BadLanguege = null;
        

        public DiscordClient Client { get; set; }
        public CommandsNextExtension Commands { get; set; }
        public async Task RunAsync()
        {

            var Conf = new DiscordConfiguration

            {

                Token = "MTAyMDIyODUyOTM3NzUwOTM4Ng.GNZ4zn.pUD4fgHiXmMrLOxnyvGJkBVgrUcBAodNcExe-U",
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug,
                Intents = DiscordIntents.All
            };
            var ComandsConf = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { "!" },
                EnableDefaultHelp = false,
                EnableMentionPrefix = true,
                UseDefaultCommandHandler = true,

            };
            var SlashCommandsConf = new SlashCommandsConfiguration
            {
                Services = null
            };
            var VoiceNextConf=new VoiceNextConfiguration 
            { 
            EnableIncoming=false,

            };

            Client = new DiscordClient(Conf);
            Client.Ready += ONClient_Ready;
            Client.ChannelCreated += Client_ChannelCreated;
            Client.ChannelDeleted += Client_ChannelDeleted;
            Client.GuildMemberAdded += Client_GuildMemberAdded;
            Client.MessageCreated += Client_MessageCreated;
            Commands = Client.UseCommandsNext(ComandsConf);
            var slash = Client.UseSlashCommands(SlashCommandsConf);
            Commands.RegisterCommands<BasicComands>();
            slash.RegisterCommands<SlashCommands>();
            Logchannel = await Client.GetChannelAsync(1099039433707229224);
            Welcomechannel = await Client.GetChannelAsync(1099076614207324282);
            BadLanguege = await Client.GetChannelAsync(1099300021423321180);
            await Client.ConnectAsync();
            await Task.Delay(-1);

        }

        private Task Client_MessageCreated(DiscordClient sender, MessageCreateEventArgs args)
        {
            DiscordEmbedBuilder.EmbedThumbnail ETF = new()
            {
                Url = args.Author.AvatarUrl,
                Height = 64,
                Width = 64,

            };
            string Message = args.Message.Content.ToLower();
            switch (Message)
            {

                case string A when Message.Contains("kir"):
                    {

                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" Kir "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;
                    }
                case string A when Message.Contains("kos"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" Kos "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;
                    }
                case string A when Message.Contains("nanat"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" nanat "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;
                    }
                case string A when Message.Contains("مادر"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" مادر "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;
                    }
                case string A when Message.Contains("جنده"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" جنده "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;
                    }
                case string A when Message.Contains("ننت"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" ننت "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;

                    }
                case string A when Message.Contains("ن.ن.ت"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" ننت "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;

                    }
                case string A when Message.Contains("ن ن ت"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" ننت "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;

                    }
                case string A when Message.Contains("کص"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" کص "}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;

                    }
                case string A when Message.Contains("ک.ص"):
                    {
                        DiscordEmbedBuilder EmbedFosh = new DiscordEmbedBuilder
                        {
                            Color = DiscordColor.DarkRed,
                            Title = $"Warning",
                            Description = $" Fosh Nade Pesaram\nFosh : ||{" کص"}||",
                            Thumbnail = ETF,
                        };
                        EmbedFosh.AddField("User", $"{args.Author.Mention}");
                        args.Message.DeleteAsync();
                        sender.SendMessageAsync(BadLanguege, EmbedFosh);
                        break;

                    }
            }
            return Task.CompletedTask;
        }

        private Task Client_GuildMemberAdded(DiscordClient sender, GuildMemberAddEventArgs args)
        {
            DiscordEmbedBuilder.EmbedThumbnail ET = new()
            {
                Url = args.Member.AvatarUrl,
                Height = 64,
                Width = 64,

            };

            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = args.Member.Color,
                Description = $"Welcome To My server",

                Title = "Welcome",
                Thumbnail = ET
            };

            sender.SendMessageAsync(Welcomechannel, $"{args.Member.Mention} Welcome Bro", embed);
            return Task.CompletedTask;
        }

        private Task Client_ChannelDeleted(DiscordClient sender, ChannelDeleteEventArgs args)
        {
            DiscordEmbedBuilder.EmbedThumbnail ET = new()
            {
                Url = Client.CurrentUser.AvatarUrl,
                Height = 32,
                Width = 32,

            };

            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Red,
                Description = $"A Channel Was Deleted!\nID : {args.Channel.Id}\nName : {args.Channel.Name}",

                Title = "Status",
                Thumbnail = ET
            };
            sender.SendMessageAsync(Logchannel, embed);
            return Task.CompletedTask;

        }

        private Task Client_ChannelCreated(DiscordClient sender, ChannelCreateEventArgs args)
        {

            DiscordEmbedBuilder.EmbedThumbnail ET = new()
            {
                Url = Client.CurrentUser.AvatarUrl,
                Height = 32,
                Width = 32,

            };

            DiscordEmbedBuilder embed = new DiscordEmbedBuilder
            {
                Color = DiscordColor.Blue,
                Description = $"A Channel Was Created!\nID : {args.Channel.Id}\nName : {args.Channel.Name}",
                Title = "Status",
                Thumbnail = ET
            };
            sender.SendMessageAsync(Logchannel, embed);
            return Task.CompletedTask;

        }

        private Task ONClient_Ready(DiscordClient sender, ReadyEventArgs args)
        {

             DiscordEmbedBuilder.EmbedThumbnail ET = new()
            {
                Url = Client.CurrentUser.AvatarUrl,
                Height = 32,
                Width = 32,

            };
            DiscordEmbedBuilder Online = new DiscordEmbedBuilder
       
            {
                Color = DiscordColor.Green,
                Description = "Bot Is Online Bitch",
                Title = "Status",
                Thumbnail = ET
            };
            async Task Runint() 
            
            {
                Client.UseVoiceNext();
                DiscordChannel channel = await Client.GetChannelAsync(1099270069235744798);
                VoiceNextConnection connection = await channel.ConnectAsync();
            }
            Runint();
            Online.AddField("Bot Name", $"\n{Client.CurrentUser.Username}");
            sender.SendMessageAsync(Logchannel, Online);
            return Task.CompletedTask;
        }
    }
}
