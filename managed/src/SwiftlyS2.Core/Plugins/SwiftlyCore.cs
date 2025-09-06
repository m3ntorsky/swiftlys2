using SwiftlyS2.Core.Events;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Events;

namespace SwiftlyS2.Core.Plugins;


internal class SwiftlyCore : ISwiftlyCore, IDisposable {

  public EventSubscriber CustomEventSubscriber { get; }


  public SwiftlyCore(string id, IServiceProvider provider) {
    CustomEventSubscriber = new EventSubscriber(id, provider);
  }

  public void Dispose() {
    CustomEventSubscriber.Dispose();
  }

  IEventSubscriber ISwiftlyCore.CustomEvents => CustomEventSubscriber;

}