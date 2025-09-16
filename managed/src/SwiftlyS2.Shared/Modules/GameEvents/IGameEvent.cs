using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Shared.GameEvents;

/// <summary>
/// Represents a strongly-typed game event with helpers to set/get payload fields and fire the event.
/// </summary>
/// <typeparam name="T">Concrete event type implementing <see cref="IGameEvent{T}"/>.</typeparam>
public interface IGameEvent<T> where T : IGameEvent<T>
{
  /// <summary>
  /// Creates an event wrapper for a pointer allocated by the engine.
  /// </summary>
  /// <param name="ptr">Native pointer to the underlying game event.</param>
  /// <returns>The typed event instance.</returns>
  internal static abstract T FromAllocated(nint ptr);

  /// <summary>
  /// Creates an event wrapper for a pointer owned externally.
  /// </summary>
  /// <param name="ptr">Native pointer to the underlying game event.</param>
  /// <returns>The typed event instance.</returns>
  internal static abstract T FromExternal(nint ptr);
  
  /// <summary>
  /// Gets the engine event name used to identify this event.
  /// </summary>
  /// <returns>Event name.</returns>
  internal static abstract string GetName();

  /// <summary>
  /// Gets the engine event hash used to identify this event.
  /// </summary>
  /// <returns>Event hash.</returns>
  internal static abstract uint GetHash();

  /// <summary>
  /// When true, the event will not be broadcast to clients.
  /// </summary>
  public bool DontBroadcast { get; set; }

  /// <summary>
  /// Fires the event.
  /// </summary>
  public void Fire();

  /// <summary>
  /// Fires the event to a specific client.
  /// </summary>
  /// <param name="clientId">Target client slot/id.</param>
  public void FireToClient(int clientId);

  /// <summary>
  /// Sets a boolean field on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">Boolean value.</param>
  public void SetBool(string key, bool value);

  /// <summary>
  /// Gets a boolean field from the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Boolean value.</returns>
  public bool GetBool(string key);

  /// <summary>
  /// Sets an integer field on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">Integer value.</param>
  public void SetInt(string key, int value);

  /// <summary>
  /// Gets an integer field from the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Integer value.</returns>
  public int GetInt(string key);

  /// <summary>
  /// Sets an unsigned 64-bit integer field on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">Unsigned 64-bit value.</param>
  public void SetUint64(string key, ulong value);

  /// <summary>
  /// Sets a floating-point field on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">Float value.</param>
  public void SetFloat(string key, float value);

  /// <summary>
  /// Sets a string field on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">String value.</param>
  public void SetString(string key, string value);

  /// <summary>
  /// Gets a string field from the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>String value.</returns>
  public string GetString(string key);

  /// <summary>
  /// Sets an entity reference on the event payload.
  /// </summary>
  /// <typeparam name="K">Entity type derived from <see cref="CEntityInstance"/>.</typeparam>
  /// <param name="key">Field name.</param>
  /// <param name="value">Entity instance.</param>
  public void SetEntity<K>(string key, K value) where K : CEntityInstance;

  /// <summary>
  /// Gets an entity reference from the event payload.
  /// </summary>
  /// <typeparam name="K">Entity type derived from <see cref="CEntityInstance"/>.</typeparam>
  /// <param name="key">Field name.</param>
  /// <returns>Entity instance.</returns>
  public K GetEntity<K>(string key) where K : CEntityInstance;

  /// <summary>
  /// Sets an entity index field on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">Entity index.</param>
  public void SetEntityIndex(string key, int value);

  /// <summary>
  /// Gets an entity index field from the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Entity index.</returns>
  public int GetEntityIndex(string key);

  /// <summary>
  /// Sets a player slot field on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">Player slot.</param>
  public void SetPlayerSlot(string key, int value);

  /// <summary>
  /// Gets a player slot field from the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Player slot.</returns>
  public int GetPlayerSlot(string key);

  /// <summary>
  /// Gets the player controller referenced by the given field.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Player controller.</returns>
  public CCSPlayerController GetPlayerController(string key);

  /// <summary>
  /// Gets the player pawn referenced by the given field.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Player pawn.</returns>
  public CCSPlayerPawn GetPlayerPawn(string key);

  /// <summary>
  /// Sets a raw pointer value on the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <param name="value">Pointer value.</param>
  public void SetPtr(string key, nint value);

  /// <summary>
  /// Gets a raw pointer value from the event payload.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Pointer value.</returns>
  public nint GetPtr(string key);

  /// <summary>
  /// Gets the pawn entity index referenced by the given field.
  /// </summary>
  /// <param name="key">Field name.</param>
  /// <returns>Pawn entity index.</returns>
  public int GetPawnEntityIndex(string key);

  /// <summary>
  /// Indicates whether the event is marked as reliable.
  /// </summary>
  /// <returns>True if reliable.</returns>
  public bool IsReliable();

  /// <summary>
  /// Indicates whether the event is local to this server/client.
  /// </summary>
  /// <returns>True if local.</returns>
  public bool IsLocal();
  
  
}