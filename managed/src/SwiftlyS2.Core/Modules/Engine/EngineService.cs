using SwiftlyS2.Shared;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Services;

internal class EngineService : IEngineService
{
    private readonly CommandTrackerManager _commandTrackedManager;

    public EngineService(CommandTrackerManager commandTrackedManager)
    {
        this._commandTrackedManager = commandTrackedManager;
    }

    public string ServerIP => NativeEngineHelpers.GetServerIP();

    public string Map => NativeEngineHelpers.GetMap();

    public int MaxPlayers => NativeEngineHelpers.GetMaxPlayers();

    public float CurrentTime => NativeEngineHelpers.GetServerCurrentTime();

    public int TickCount => NativeEngineHelpers.GetServerTickCount();

    public void ExecuteCommand(string command)
    {
        NativeEngineHelpers.ExecuteCommand(command);
    }

    public void ExecuteCommandWithBuffer(string command, Action<string> bufferCallback)
    {
        _commandTrackedManager.EnqueueCommand(bufferCallback);
        NativeEngineHelpers.ExecuteCommand($"^wb^{command}");
    }

    public bool IsMapValid(string map)
    {
        return NativeEngineHelpers.IsMapValid(map);
    }

    public nint? FindGameSystemByName(string name)
    {
        var handle = NativeEngineHelpers.FindGameSystemByName(name);
        return handle == nint.Zero ? null : handle;
    }
}