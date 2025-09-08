using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysXConstraint2_t : ISchemaClass {

  public ref uint Flags { get; }
  
  public ref ushort Parent { get; }
  
  public ref ushort Child { get; }
  
  public IVPhysXConstraintParams_t Params { get; }
  
}