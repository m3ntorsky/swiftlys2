using SwiftlyS2.Shared.Misc;

namespace SwiftlyS2.Shared.Events;

/// <summary>
/// Called when a command is executed.
/// </summary>
public interface IOnCommandExecuteHookEvent {

  /// <summary>
  /// The command name.
  /// </summary>
  public string CommandName { get; }

  /// <summary>
  /// The command arguments.
  /// </summary>
  public HookMode HookMode { get; }
}