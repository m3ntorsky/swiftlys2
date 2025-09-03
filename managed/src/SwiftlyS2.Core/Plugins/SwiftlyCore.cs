using SwiftlyS2.Core.Events;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.CustomEvents;

namespace SwiftlyS2.Core.Plugins;


internal class SwiftlyCore : ISwiftlyCore, IDisposable {

  public CustomEventSubscriber CustomEventSubscriber { get; }


  public SwiftlyCore(string id, IServiceProvider provider) {
    CustomEventSubscriber = new CustomEventSubscriber(id, provider);
  }

  public void Dispose() {
    CustomEventSubscriber.Dispose();
  }

  ICustomEventSubscriber ISwiftlyCore.CustomEvents => CustomEventSubscriber;

}