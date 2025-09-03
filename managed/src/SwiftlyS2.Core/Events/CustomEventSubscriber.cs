using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.CustomEvents;

namespace SwiftlyS2.Core.Events;

/// <summary>
/// Plugin-scoped custom event subscriber.
/// </summary>
internal class CustomEventSubscriber : ICustomEventSubscriber, IDisposable {

  public string Id { get; init; }
  private ProfileService _ProfileService { get; init; }

  public CustomEventSubscriber(string id, IServiceProvider provider) {
    Id = id;
    _ProfileService = provider.GetRequiredService<ProfileService>();
  }

  public event CustomEventListeners.OnTick OnTick;


  public void Dispose() {
    CustomEventPublisher.Unsubscribe(this);
  }

  public void InvokeOnTick() {
    var stopwatch = new Stopwatch();
    OnTick?.Invoke();
    stopwatch.Stop();
    _ProfileService.ProfilePlugin(Id, "CustomEventSubscriber::OnTick", stopwatch.Elapsed.TotalMilliseconds);
  }

}