﻿using System.Threading.Tasks;

namespace Discord
{
    public interface IInvite : IEntity<string>
    {
        /// <summary> Gets the unique identifier for this invite. </summary>
        string Code { get; }
        /// <summary> Gets the url used to accept this invite, using Code. </summary>
        string Url { get; }
        /// <summary> Gets the human-readable identifier for this code. </summary>
        string XkcdCode { get; }
        /// <summary> Gets the url used to accept this invite, using XkcdCode. </summary>
        string XkcdUrl { get; }

        /// <summary> Gets the id of the the channel this invite is linked to. </summary>
        ulong ChannelId { get; }
        /// <summary> Gets the id of the guild this invite is linked to. </summary>
        ulong GuildId { get; }

        /// <summary> Accepts this invite and joins the target server. This will fail on bot accounts. </summary>
        Task Accept();
    }
}
