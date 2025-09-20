using SwiftlyS2.Core.EntitySystem;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.SchemaDefinitions;

public partial interface CEntityInstance {

  /// <summary>
  /// Fire an input to the entity.
  /// </summary>
  /// <typeparam name="T">Param type. Support bool, int, uint, long, ulong, float, double, string</typeparam>
  /// <param name="input">Input name.</param>
  /// <param name="value">Input value.</param>
  /// <param name="activator">Activator entity. Nullable.</param>
  /// <param name="caller">Caller entity. Nullable.</param>
  /// <param name="outputID">Output ID.</param>
  public void AcceptInput<T>(string input, T value, CEntityInstance? activator = null, CEntityInstance? caller = null, int outputID = 0);

  /// <summary>
  /// Add an entity IO event to the entity.
  /// </summary>
  /// <typeparam name="T">Param type. Support bool, int, uint, long, ulong, float, double, string</typeparam>
  /// <param name="input">Input name.</param>
  /// <param name="value">Input value.</param>
  /// <param name="activator">Activator entity. Nullable.</param>
  /// <param name="caller">Caller entity. Nullable.</param>
  /// <param name="delay">Delay in seconds.</param>
  public void AddEntityIOEvent<T>(string input, T value, CEntityInstance? activator = null, CEntityInstance? caller = null, float delay = 0f);

  /// <summary>
  /// Dispatch a spawn event to the entity.
  /// </summary>
  /// <param name="entityKV">Entity key values. Nullable.</param>
  public void DispatchSpawn( CEntityKeyValues? entityKV = null );

  /// <summary>
  /// Despawn the entity.
  public void Despawn();
}