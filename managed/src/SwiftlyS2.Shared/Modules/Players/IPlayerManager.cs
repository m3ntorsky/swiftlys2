namespace SwiftlyS2.Shared.Services;

public interface IPlayerManagerService
{
    /// <summary>
    /// Checks whether a specific player is currently online and connected to the server.
    /// </summary>
    /// <returns>True if the player is online, false otherwise.</returns>
    bool IsPlayerOnline(int playerid);

    /// <summary>
    /// Gets the number of players currently in the game.
    /// </summary>
    public int PlayerCount { get; }

    /// <summary>
    /// Gets the maximum number of players allowed by the engine.
    /// </summary>
    public int PlayerCap { get; }

    /// <summary>
    /// Broadcasts a message to players using different display methods based on the message type.
    /// </summary>
    /// <param name="kind">The type of message display.</param>
    /// <param name="message">The text content to send to players.</param>
    void SendMessage(MessageType kind, string message);

    /// <summary>
    /// Controls whether a specific entity should be blocked from being transmitted/synchronized to clients.
    /// </summary>
    void ShouldBlockTransmitEntity(int entityid, bool shouldBlockTransmit);

    /// <summary>
    /// Removes all entity transmission blocks, allowing all previously blocked entities to be transmitted to clients again.
    /// </summary>
    void ClearAllBlockedTransmitEntities();
}