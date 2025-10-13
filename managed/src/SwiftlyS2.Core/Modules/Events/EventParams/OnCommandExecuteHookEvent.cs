using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.Events;

namespace SwiftlyS2.Core.Events;

internal class OnCommandExecuteHookEvent : IOnCommandExecuteHookEvent
{

  public required string CommandName { get; set; }

  public required HookMode HookMode { get; set; }
}