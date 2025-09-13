using System;
using System.Drawing;
using Microsoft.Extensions.DependencyInjection;
using Spectre.Console;
using SwiftlyS2.Core.Hosting;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Natives;
namespace SwiftlyS2.Core;

internal static class Bootstrap {
  public static void Start(IntPtr nativeTable, int nativeTableSize) {

    NativeBinding.BindNatives(nativeTable, nativeTableSize);

    AnsiConsole.Write(new FigletText("SwiftlyS2").LeftJustified().Color(Spectre.Console.Color.Aquamarine1));

    ServiceCollection services = new ServiceCollection();
    
    services.AddProfileService();
    services.AddConfigurationService();
    services.AddRootDirService();
    services.AddPluginManager();
    services.AddLoggerFactory();
    
    var provider = services.BuildServiceProvider();
    
    provider.UsePluginManager();
  }
}