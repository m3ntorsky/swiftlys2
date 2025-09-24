namespace SwiftlyS2.Shared.SchemaDefinitions;

public partial interface CBaseModelEntity
{
    /// <summary>
    /// Sets the model to the entity.
    /// </summary>
    /// <param name="model">The model path to be used.</param>
    public void SetModel(string model);
}