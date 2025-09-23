using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Services;

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

    public bool IsMapValid(string map)
    {
        return NativeEngineHelpers.IsMapValid(map);
    }
}