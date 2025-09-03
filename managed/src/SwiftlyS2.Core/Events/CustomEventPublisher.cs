using System.Runtime.InteropServices;
using SwiftlyS2.Shared.CustomEvents;

namespace SwiftlyS2.Core.Events;

internal static class CustomEventPublisher {

  private static List<CustomEventSubscriber> _subscribers = new();

  public static void Subscribe(CustomEventSubscriber subscriber) {
    _subscribers.Add(subscriber);
  }

  public static void Unsubscribe(CustomEventSubscriber subscriber) {
    _subscribers.Remove(subscriber);
  }


  [UnmanagedCallersOnly]
  public static void OnTick()
  {
    _subscribers.ForEach(subscriber => subscriber.InvokeOnTick());
  }

}