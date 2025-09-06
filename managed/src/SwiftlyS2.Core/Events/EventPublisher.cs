using System.Runtime.InteropServices;
using SwiftlyS2.Shared.Events;

namespace SwiftlyS2.Core.Events;

internal static class EventPublisher {

  private static List<EventSubscriber> _subscribers = new();

  public static void Subscribe(EventSubscriber subscriber) {
    _subscribers.Add(subscriber);
  }

  public static void Unsubscribe(EventSubscriber subscriber) {
    _subscribers.Remove(subscriber);
  }


  [UnmanagedCallersOnly]
  public static void OnTick()
  {
    _subscribers.ForEach(subscriber => subscriber.InvokeOnTick());
  }

}