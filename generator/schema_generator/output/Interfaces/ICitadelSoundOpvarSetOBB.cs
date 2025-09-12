using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICitadelSoundOpvarSetOBB : IBaseEntity {

  
  public ISchemaUntypedField StackName { get; }
  
  public ISchemaUntypedField OperatorName { get; }
  
  public ISchemaUntypedField OpvarName { get; }
  
  public ref Vector DistanceInnerMins { get; }
  
  public ref Vector DistanceInnerMaxs { get; }
  
  public ref Vector DistanceOuterMins { get; }
  
  public ref Vector DistanceOuterMaxs { get; }
  
  public ref int AABBDirection { get; }
}