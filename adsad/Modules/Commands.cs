using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace adsad.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("Nachmi")]
        public async Task Nachmi()
        {
            await ReplyAsync("Is Gay");
        }

        [Command("Roles")]

        public async Task Roles()
        {
            
        }


        [Command("Gay")]
        public async Task Gay()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("גיי!");
            embed.WithImageUrl("https://p76.tr0.n0.cdn.getcloudapp.com/items/L1uNGNqL/b34da71e-ab58-45fc-b1c2-f3525d190b2e.png?source=viewer&v=b48eee072dcb94bea0865b196f41681c");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }

        [Command("FuckBoys")]
        public async Task FuckBoys()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("פאקבויז!");
            embed.WithImageUrl("https://p76.tr0.n0.cdn.getcloudapp.com/items/z8uPA65J/0359ad16-4645-4a34-ad84-b725420a03d4.png?source=viewer&v=47d3580c27bc524056e5d90a6082959c");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }
        [Command("Ido")]
        public async Task FB()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("אשכנזי!");
            embed.WithImageUrl("https://p76.tr0.n0.cdn.getcloudapp.com/items/KouZOdd9/9c3d5fc6-536d-4e61-8e9b-855733c471ae.png?source=viewer&v=ed73452d3b3a597f86cbfdd53ab9f825");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }
          [Command("Levy")]
        public async Task Levy()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("סטלן!");
            embed.WithImageUrl("https://p76.tr0.n0.cdn.getcloudapp.com/items/L1uNGdjp/e1c663c5-e201-4149-983c-e4446e271694.png?source=viewer&v=a6392a22973c46cc39a3e33a5860a74a");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }

         [Command("AgamBason")]
        public async Task AgamBason()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("דינג דנג דונג!");
            embed.WithImageUrl("https://p76.tr0.n0.cdn.getcloudapp.com/items/mXu18r68/996e4259-5e61-4c76-8c9f-29160fe4a738.png?source=viewer&v=b45eb2fa1bc4fd73bf0efceda1cf038b");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }


        [Command("a")]
        public async Task a()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("דינג דנג דונג!");
            embed.WithImageUrl("https://p76.tr0.n0.cdn.getcloudapp.com/items/mXu18r68/996e4259-5e61-4c76-8c9f-29160fe4a738.png?source=viewer&v=b45eb2fa1bc4fd73bf0efceda1cf038b");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }


        [Command("b")]
        public async Task b()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("דינג דנג דונג!");
            embed.WithImageUrl("https://p76.tr0.n0.cdn.getcloudapp.com/items/mXu18r68/996e4259-5e61-4c76-8c9f-29160fe4a738.png?source=viewer&v=b45eb2fa1bc4fd73bf0efceda1cf038b");
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }
    }
}
