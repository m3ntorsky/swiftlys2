using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Services;
using SwiftlyS2.Core.Modules.Engine;

namespace SwiftlyS2.Core.Services;

internal class EngineService : IEngineService
{
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
        CommandTracked.Instance?.EnqueueCommand($"{command}^wb^", bufferCallback);
        NativeEngineHelpers.ExecuteCommand($"{command}^wb^");
    }

    public bool IsMapValid(string map)
    {
        return NativeEngineHelpers.IsMapValid(map);
    }
}