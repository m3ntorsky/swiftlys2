using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Shared.EntitySystem;

public interface IEntitySystemService {

  /// <summary>
  /// Create an entity by designer name.
  /// </summary>
  /// <typeparam name="T">Entity type.</typeparam>
  /// <param name="designerName">Designer name.</param>
  /// <returns>Created entity.</returns>
  /// <exception cref="ArgumentException">Thrown when failed to create entity by designer name or designer name is invalid.</exception>
  public T CreateEntityByDesignerName<T>(string designerName) where T : ISchemaClass<T>;

  /// <summary>
  /// Get a reference handle to the entity.
  /// </summary>
  /// <typeparam name="T">Entity type.</typeparam>
  /// <param name="entity">Entity instance.</param>
  /// <returns>Reference entity handle to the entity.</returns>
  public CHandle<T> GetRefEHandle<T>(T entity) where T : class, ISchemaClass<T>;

  /// <summary>
  /// Get the game rules entity.
  /// </summary>
  /// <returns>Game rules entity. Nullable.</returns>
  public CCSGameRules? GetGameRules();

  /// <summary>
  /// Get all entities.
  /// </summary>
  /// <returns>All entities.</returns>
  public IEnumerable<CEntityInstance> GetAllEntities();

  /// <summary>
  /// Get all entities by class.
  /// </summary>
  /// <typeparam name="T">Entity type.</typeparam>
  /// <returns>All entities by class.</returns>
  public IEnumerable<T> GetAllEntitiesByClass<T>() where T : class, ISchemaClass<T>;

  /// <summary>
  /// Get all entities by designer name, and cast to type T.
  /// </summary>
  /// <typeparam name="T">Entity type.</typeparam>
  /// <param name="designerName">Designer name.</param>
  /// <returns>All entities by designer name.</returns>
  public IEnumerable<T> GetAllEntitiesByDesignerName<T>(string designerName) where T : class, ISchemaClass<T>;

}