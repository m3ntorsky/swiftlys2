using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Services;
using SwiftlyS2.Core.Modules.Engine;
using Microsoft.Extensions.DependencyInjection;

namespace SwiftlyS2.Core.Services;

internal class EngineService : IEngineService
{
    private readonly IServiceProvider serviceProvider;

    public EngineService(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
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
        try
        {
            var commandTracked = serviceProvider.GetService<CommandTracked>();
            commandTracked?.EnqueueCommand(bufferCallback);
            NativeEngineHelpers.ExecuteCommand($"{command}^wb^");
        }
        catch { }
    }

    public bool IsMapValid(string map)
    {
        return NativeEngineHelpers.IsMapValid(map);
    }
}