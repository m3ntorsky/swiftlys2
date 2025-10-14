namespace SwiftlyS2.Shared.Services;

public interface ICommandTrackedService
{
    /// <summary>
    /// Enqueues a command to be executed.
    /// </summary>
    /// <param name="callback">The callback to receive the output of the command.</param>
    void EnqueueCommand(Action<string> callback);
}