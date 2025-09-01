using System;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Hosting;
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.Services;
namespace SwiftlyS2.Core;

internal static class Bootstrap {
  public static void Start(IntPtr nativeTable, int nativeTableSize) {

    NativeBinding.BindNatives(nativeTable, nativeTableSize);

    ServiceCollection services = new ServiceCollection();
    
    services.AddTestService();
    
    var provider = services.BuildServiceProvider();
    
    provider.UseTestService();
  }
}