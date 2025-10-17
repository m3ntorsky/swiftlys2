namespace SwiftlyS2.Shared.Services;

public interface IEngineService
{
    /// <summary>
    /// The IP address of the server.
    /// </summary>
    string ServerIP { get; }

    /// <summary>
    /// Gets the map that the server is running
    /// </summary>
    string Map { get; }

    /// <summary>
    /// Determines whether the specified map string represents a valid map in server files.
    /// </summary>
    /// <param name="map">The map string to validate. It also supports Workshop ID.</param>
    /// <returns>true if the map is valid; otherwise, false.</returns>
    bool IsMapValid(string map);

    /// <summary>
    /// Gets the maximum number of players allowed in the game.
    /// </summary>
    int MaxPlayers { get; }

    /// <summary>
    /// Executes the specified command string in the current context.
    /// </summary>
    /// <param name="command">The command to execute. Cannot be null or empty.</param>
    void ExecuteCommand(string command);

    /// <summary>
    /// Executes the specified command string in the current context.
    /// </summary>
    /// <param name="command">The command to execute. Cannot be null or empty.</param>
    /// <param name="bufferCallback">The callback to receive the output of the command.</param>
    void ExecuteCommandWithBuffer(string command, Action<string> bufferCallback);

    /// <summary>
    /// The time since the server started.
    /// </summary>
    float CurrentTime { get; }

    /// <summary>
    /// The number of simulation ticks that have occurred since the server started.
    /// </summary>
    int TickCount { get; }

    /// <summary>
    /// Find a game system by name.
    /// </summary>
    /// <param name="name">The name of the game system.</param>
    /// <returns>The game system handle. Null if not found.</returns>
    nint? FindGameSystemByName(string name);
}