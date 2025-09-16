using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Core.Services;
using SwiftlyS2.Shared.Events;

namespace SwiftlyS2.Core.Events;

/// <summary>
/// Plugin-scoped custom event subscriber.
/// </summary>
internal class EventSubscriber : IEventSubscriber, IDisposable {

  private Services.CoreContext _Id { get; init; }
  private ProfileService _ProfileService { get; init; }

  public EventSubscriber(Services.CoreContext id, IServiceProvider provider) {
    _Id = id;
    _ProfileService = provider.GetRequiredService<ProfileService>();
    EventPublisher.Subscribe(this);
  }

  public event EventListeners.OnTick? OnTick;


  public void Dispose() {
    EventPublisher.Unsubscribe(this);
  }

  public void InvokeOnTick() {
    var stopwatch = new Stopwatch();
    OnTick?.Invoke();
    stopwatch.Stop();
    _ProfileService.RecordTimeWithIdentifier(_Id.Name, "CustomEventSubscriber::OnTick", stopwatch.Elapsed.TotalMilliseconds);
  }

}