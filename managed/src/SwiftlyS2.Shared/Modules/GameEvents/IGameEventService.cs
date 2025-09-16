using SwiftlyS2.Shared.Misc;

namespace SwiftlyS2.Shared.GameEvents;

/// <summary>
/// Plugin-scoped service for managing game events.
/// </summary>
public interface IGameEventService : IDisposable {

  /// <summary>
  /// Hooks a pre-event callback.
  /// </summary>
  /// <typeparam name="T">The event type.</typeparam>
  /// <param name="callback">The callback to hook.</param>
  /// <returns>A GUID representing the hook. You can use this to unhook the callback later.</returns>
  Guid HookPre<T>(Func<T, HookResult> callback) where T : IGameEvent<T>;

  /// <summary>
  /// Hooks a post-event callback.
  /// </summary>
  /// <typeparam name="T">The event type.</typeparam>
  /// <param name="callback">The callback to hook.</param>
  /// <returns>A GUID representing the hook. You can use this to unhook the callback later.</returns>
  Guid HookPost<T>(Func<T, HookResult> callback) where T : IGameEvent<T>;

  /// <summary>
  /// Unhooks a callback.
  /// </summary>
  /// <param name="guid">The GUID of the hook to unhook.</param>
  void Unhook(Guid guid);

  /// <summary>
  /// Unhooks all pre-event callbacks.
  /// </summary>
  /// <typeparam name="T">The event type.</typeparam>
  void UnhookPre<T>() where T : IGameEvent<T>;

  /// <summary>
  /// Unhooks all post-event callbacks.
  /// </summary>
  /// <typeparam name="T">The event type.</typeparam>
  void UnhookPost<T>() where T : IGameEvent<T>;

  /// <summary>
  /// Creates a new game event.
  /// </summary>
  /// <typeparam name="T">The event type.</typeparam>
  /// <returns>A new game event.</returns>
  T Create<T>() where T : IGameEvent<T>;
}