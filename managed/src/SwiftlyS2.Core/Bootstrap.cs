using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;
using SwiftlyS2.Core.Hosting;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Core.Extensions;
using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared;
using SwiftlyS2.Core.Events;
namespace SwiftlyS2.Core;

internal static class Bootstrap {
  public static void Start(IntPtr nativeTable, int nativeTableSize) {
    
    NativeBinding.BindNatives(nativeTable, nativeTableSize);

    AnsiConsole.Write(new FigletText("SwiftlyS2").LeftJustified().Color(Spectre.Console.Color.LightSteelBlue1));

    ServiceCollection services = new ServiceCollection();

    services.AddProfileService();
    services.AddConfigurationService();
    services.AddTestService();
    services.AddRootDirService();
    services.AddGameDataService();
    services.AddPluginManager();
    services.AddHookManager();
    services.AddLogger();

    services.AddSingleton<ISwiftlyCore, SwiftlyCore>((provider) => new SwiftlyCore(
      "SwiftlyS2",
      AppContext.BaseDirectory,
      typeof(SwiftlyCore),
      provider
    ));

    var provider = services.BuildServiceProvider();

    // Register native event callbacks
    EventPublisher.Register();

    provider.UsePluginManager();
    provider.UseTestService();

  }
}