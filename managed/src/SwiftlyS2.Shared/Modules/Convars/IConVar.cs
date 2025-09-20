namespace SwiftlyS2.Shared.Convars;

public interface IConVar<T> {
  /// <summary>
  /// The value of the convar.
  /// When setting, if the convar can be replicated, it will automatically replicate to all clients.
  /// Also, setting value with this method will internally put it into a set queue,
  /// Which means that for some special case ( e.g. setting sv_enablebunnyhopping inside a hook ) it won't work,
  /// in such cases you should use the SetInternal method instead.
  /// </summary>
  T Value { get; set; }

  /// <summary>
  /// Add flags to the convar.
  /// </summary>
  /// <param name="flags">flags.</param>
  void AddFlags(ConvarFlags flags);

  /// <summary>
  /// Remove flags from the convar.
  /// </summary>
  /// <param name="flags">flags.</param>
  void RemoveFlags(ConvarFlags flags);

  /// <summary>
  /// Clear all flags from the convar.
  /// </summary>
  void ClearFlags();

  /// <summary>
  /// Get the flags of the convar.
  /// </summary>
  /// <returns>The flags of the convar.</returns>
  ConvarFlags GetFlags();

  /// <summary>
  /// Check if the convar has the given flags.
  /// </summary>
  /// <param name="flags">flags.</param>
  /// <returns>True if the convar has all the given flags, false otherwise.</returns>
  bool HasFlags(ConvarFlags flags);

  /// <summary>
  /// Internally set the value of the convar.
  /// Won't replicate the change to clients.
  /// </summary>
  /// <param name="value">The value to set.</param>
  void SetInternal(T value);

  /// <summary>
  /// Replicate the value of the convar to specified client.
  /// </summary>
  /// <param name="clientId">The client id to replicate to.</param>
  void ReplicateToClient(int clientId, T value);

  /// <summary>
  /// Query the value of the convar from specified client.
  /// </summary>
  /// <param name="clientId"></param>
  /// <param name="value">The action to execute with the value.</param>
  void QueryClient(int clientId, Action<string> callback);
}