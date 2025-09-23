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
    /// The time since the server started.
    /// </summary>
    float CurrentTime { get; }

    /// <summary>
    /// The number of simulation ticks that have occurred since the server started.
    /// </summary>
    int TickCount { get; }

    /// <summary>
    /// Gets the trace manager used to control and configure tracing operations within the game.
    /// </summary>
    ITraceManager TraceManager { get; }
}