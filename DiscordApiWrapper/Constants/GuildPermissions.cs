using System.Numerics;

namespace DiscordNetKit.Constants;

public class GuildPermissions
{
    public static readonly BigInteger CreateInstantInvite = BigInteger.One << 0;
    public static readonly BigInteger KickMembers = BigInteger.One << 1;
    public static readonly BigInteger BanMembers = BigInteger.One << 2;
    public static readonly BigInteger Administrator = BigInteger.One << 3;
    public static readonly BigInteger ManageChannels = BigInteger.One << 4;
    public static readonly BigInteger ManageGuild = BigInteger.One << 5;
    public static readonly BigInteger AddReactions = BigInteger.One << 6;
    public static readonly BigInteger ViewAuditLog = BigInteger.One << 7;
    public static readonly BigInteger PrioritySpeaker = BigInteger.One << 8;
    public static readonly BigInteger Stream = BigInteger.One << 9;
    public static readonly BigInteger ViewChannel = BigInteger.One << 10;
    public static readonly BigInteger SendMessages = BigInteger.One << 11;
    public static readonly BigInteger SendTTSMessages = BigInteger.One << 12;
    public static readonly BigInteger ManageMessages = BigInteger.One << 13;
    public static readonly BigInteger EmbedLinks = BigInteger.One << 14;
    public static readonly BigInteger AttachFiles = BigInteger.One << 15;
    public static readonly BigInteger ReadMessageHistory = BigInteger.One << 16;
    public static readonly BigInteger MentionEveryone = BigInteger.One << 17;
    public static readonly BigInteger UseExternalEmojis = BigInteger.One << 18;
    public static readonly BigInteger ViewGuildInsights = BigInteger.One << 19;
    public static readonly BigInteger Connect = BigInteger.One << 20;
    public static readonly BigInteger Speak = BigInteger.One << 21;
    public static readonly BigInteger MuteMembers = BigInteger.One << 22;
    public static readonly BigInteger DeafenMembers = BigInteger.One << 23;
    public static readonly BigInteger MoveMembers = BigInteger.One << 24;
    public static readonly BigInteger UseVAD = BigInteger.One << 25;
    public static readonly BigInteger ChangeNickname = BigInteger.One << 26;
    public static readonly BigInteger ManageNicknames = BigInteger.One << 27;
    public static readonly BigInteger ManageRoles = BigInteger.One << 28;
    public static readonly BigInteger ManageWebhooks = BigInteger.One << 29;
    public static readonly BigInteger ManageEmojisAndStickers = BigInteger.One << 30;
    public static readonly BigInteger UseApplicationCommands = BigInteger.One << 31;
    public static readonly BigInteger RequestToSpeak = BigInteger.One << 32;
    public static readonly BigInteger ManageEvents = BigInteger.One << 33;
    public static readonly BigInteger ManageThreads = BigInteger.One << 34;
    public static readonly BigInteger CreatePublicThreads = BigInteger.One << 35;
    public static readonly BigInteger CreatePrivateThreads = BigInteger.One << 36;
    public static readonly BigInteger UseExternalStickers = BigInteger.One << 37;
    public static readonly BigInteger SendMessagesInThreads = BigInteger.One << 38;
    public static readonly BigInteger UseEmbeddedActivities = BigInteger.One << 39;
    public static readonly BigInteger ModerateMembers = BigInteger.One << 40;
    public static readonly BigInteger ViewCreatorMonetizationAnalytics = BigInteger.One << 41;
    public static readonly BigInteger UseSoundboard = BigInteger.One << 42;
    public static readonly BigInteger CreateGuildExpressions = BigInteger.One << 43;
    public static readonly BigInteger CreateEvents = BigInteger.One << 44;
    public static readonly BigInteger UseExternalSounds = BigInteger.One << 45;
    public static readonly BigInteger SendVoiceMessages = BigInteger.One << 46;
    public static readonly BigInteger SendPolls = BigInteger.One << 49;
}