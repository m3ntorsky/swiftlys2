using SwiftlyS2.Shared.Events;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Shared.Services;

[Flags]
public enum VoiceFlagValue: uint
{
    Normal = 0,
    Muted = 1 << 0,
    All = 1 << 1,
    ListenAll = 1 << 2,
    Team = 1 << 3,
    ListenTeam = 1 << 4,
};

public enum ListenOverride: byte
{
    Default = 0,
    Mute = 1,
    Hear = 2
};

public enum Team: byte
{
    None = 0,
    Spectator = 1,
    T = 2,
    CT = 3
};

public sealed class Language
{
    public string Value { get; }

    public Language(string value)
    {
        Value = value;
    }

    public static Language Arabic = new("ar");
    public static Language Bulgarian = new("bg");
    public static Language ChineseCN = new("zh-CN");
    public static Language ChineseTW = new("zh-TW");
    public static Language Czech = new("cs");
    public static Language Danish = new("da");
    public static Language Dutch = new("nl");
    public static Language English = new("en");
    public static Language Finnish = new("fi");
    public static Language French = new("fr");
    public static Language German = new("de");
    public static Language Greek = new("el");
    public static Language Hungarian = new("hu");
    public static Language Indonesian = new("id");
    public static Language Italian = new("it");
    public static Language Japanese = new("ja");
    public static Language Korean = new("ko");
    public static Language Norwegian = new("no");
    public static Language Polish = new("pl");
    public static Language Portuguese = new("pt");
    public static Language Brazilian = new("pt-BR");
    public static Language Romanian = new("ro");
    public static Language Russian = new("ru");
    public static Language Spanish = new("es");
    public static Language LatinAmerica = new("es-419");
    public static Language Swedish = new("sv");
    public static Language Thai = new("th");
    public static Language Turkish = new("tr");
    public static Language Ukrainian = new("uk");
    public static Language Vietnamese = new("vn");
    
    public override string ToString() => Value;
    
    public static implicit operator string(Language language) => language.Value;
};

public interface IPlayer
{
    /// <summary>
    /// Gets the unique identifier for the player.
    /// </summary>
    public int PlayerID { get; }
    /// <summary>
    /// Sends a message of the specified type to the player.
    /// </summary>
    /// <param name="kind">The type of message to send. Determines how the message is processed or displayed.</param>
    /// <param name="message">The content of the message to send. Cannot be null.</param>
    void SendMessage(MessageType kind, string message);
    /// <summary>
    /// Gets a value indicating whether the client is a bot.
    /// </summary>
    public bool FakeClient { get; }
    /// <summary>
    /// Gets a value indicating whether the current user is authorized by Steam.
    /// </summary>
    public bool IsAuthorized { get; }
    /// <summary>
    /// Gets the total time, in seconds, that the connection has been active.
    /// </summary>
    public uint ConnectedTime { get; }
    /// <summary>
    /// Gets the unique Steam identifier associated with the user.
    /// </summary>
    public ulong SteamID { get; }
    /// <summary>
    /// Gets the Steam ID that was not verified yet.
    /// </summary>
    public ulong UnauthorizedSteamID { get; }
    /// <summary>
    /// Gets the player controller associated with the player.
    /// </summary>
    public CCSPlayerController Controller { get; }
    /// <summary>
    /// Gets the pawn associated with the player.
    /// </summary>
    public CBasePlayerPawn Pawn { get; }
    /// <summary>
    /// Gets the player pawn associated with the player.
    /// </summary>
    public CCSPlayerPawn PlayerPawn { get; }
    /// <summary>
    /// Gets the set of game buttons that are currently pressed.
    /// </summary>
    public GameButtonFlags PressedButtons { get; }
    /// <summary>
    /// Gets the IP address associated with the player.
    /// </summary>
    public string IPAddress { get; }
    /// <summary>
    /// Gets or sets the set of flags that specify voice options or features to be applied.
    /// </summary>
    public VoiceFlagValue VoiceFlags { get; set; }
    /// <summary>
    /// Gets the language for the player.
    /// </summary>
    public Language PlayerLanguage { get; }
    /// <summary>
    /// Disconnects the user from the network session, providing a specified reason and disconnection type.
    /// </summary>
    /// <param name="reason">The message describing the reason for the disconnection. This message may be displayed to the user. Cannot be
    /// null or empty.</param>
    /// <param name="gameReason">The disconnection reason code indicating the type of network disconnection to perform.</param>
    public void Kick(string reason, ENetworkDisconnectionReason gameReason);
    /// <summary>
    /// Sets whether transmission of the specified entity should be blocked.
    /// </summary>
    /// <param name="entityid">The unique identifier of the entity whose transmission status is to be updated.</param>
    /// <param name="shouldBlockTransmit">A value indicating whether transmission for the entity should be blocked. Specify <see langword="true"/> to
    /// block transmission; otherwise, <see langword="false"/>.</param>
    public void ShouldBlockTransmitEntity(int entityid, bool shouldBlockTransmit);
    /// <summary>
    /// Determines whether the specified entity is currently blocked from transmitting data.
    /// </summary>
    /// <param name="entityid">The unique identifier of the entity to check for transmit blocking. Must be a valid entity ID.</param>
    /// <returns>true if the entity is blocked from transmitting; otherwise, false.</returns>
    public bool IsTransmitEntityBlocked(int entityid);
    /// <summary>
    /// Removes all entity blocks from the transmit buffer, discarding any pending data scheduled for transmission.
    /// </summary>
    public void ClearTransmitEntityBlocks();
    /// <summary>
    /// Sets a custom listen override for the specified player.
    /// </summary>
    /// <param name="player">The identifier of the player whose listen override setting will be updated. Must be a valid player index.</param>
    /// <param name="listenOverride">The listen override value to apply to the specified player.</param>
    public void SetListenOverride(int player, ListenOverride listenOverride);
    /// <summary>
    /// Retrieves the listen override settings for the specified player.
    /// </summary>
    /// <param name="player">The identifier of the player whose listen override settings are to be retrieved. Must be a valid player index.</param>
    /// <returns>A ListenOverride object containing the listen override settings for the specified player.</returns>
    public ListenOverride GetListenOverride(int player);
    /// <summary>
    /// Applies damage to the entity based on the specified damage information.
    /// </summary>
    /// <param name="damageInfo">An object containing details about the damage to be applied, including the amount, type, and source. Cannot be
    /// null.</param>
    public void TakeDamage(CTakeDamageInfo damageInfo);
    /// <summary>
    /// Teleports the entity to the specified position, orientation, and velocity.
    /// </summary>
    /// <param name="pos">The target position to teleport the entity to, represented as a <see cref="Vector"/>.</param>
    /// <param name="angle">The orientation to apply to the entity after teleportation, represented as a <see cref="QAngle"/>.</param>
    /// <param name="velocity">The velocity to assign to the entity upon arrival, represented as a <see cref="Vector"/>.</param>
    public void Teleport(Vector pos, QAngle angle, Vector velocity);
    /// <summary>
    /// Switches the player's team.
    /// </summary>
    /// <param name="team">The team to switch to. Cannot be null.</param>
    public void SwitchTeam(Team team);
    /// <summary>
    /// Changes the player's team.
    /// </summary>
    /// <param name="team">The team to assign. Cannot be null.</param>
    public void ChangeTeam(Team team);
}