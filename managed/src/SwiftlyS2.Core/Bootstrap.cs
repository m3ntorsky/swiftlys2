using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;
using SwiftlyS2.Core.Hosting;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared;
using SwiftlyS2.Core.Events;
namespace SwiftlyS2.Core;

internal static class Bootstrap {
  public static void Start(IntPtr nativeTable, int nativeTableSize, string basePath) {
    Environment.SetEnvironmentVariable("SWIFTLY_MANAGED_ROOT", basePath);

    NativeBinding.BindNatives(nativeTable, nativeTableSize);

    EventPublisher.Register();
    GameFunctions.Initialize();

    AnsiConsole.Write(new FigletText("SwiftlyS2").LeftJustified().Color(Spectre.Console.Color.LightSteelBlue1));

    ServiceCollection services = new ServiceCollection();

    services.AddProfileService();
    services.AddConfigurationService();
    services.AddTestService();
    services.AddRootDirService();
    services.AddPlayerManagerService();
    services.AddPluginManager();
    services.AddHookManager();
    services.AddEngineService();
    services.AddTraceManagerService();
    services.AddLogger();
    services.AddCoreCommandService();

    services.AddSingleton<ISwiftlyCore, SwiftlyCore>((provider) => new SwiftlyCore(
      "SwiftlyS2",
      basePath,
      null,
      typeof(SwiftlyCore),
      provider
    ));

    var provider = services.BuildServiceProvider();

    provider.UseCoreCommandService();
    provider.UsePluginManager();
    // provider.UseTestService();

  }
}