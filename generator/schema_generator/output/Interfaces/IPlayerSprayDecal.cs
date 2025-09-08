using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayerSprayDecal : IModelPointEntity {

  public ref int UniqueID { get; }
  
  public ref uint AccountID { get; }
  
  public ref uint TraceID { get; }
  
  public ref uint RtGcTime { get; }
  
  public ref Vector EndPos { get; }
  
  public ref Vector Start { get; }
  
  public ref Vector Left { get; }
  
  public ref Vector Normal { get; }
  
  public ref int Player { get; }
  
  public ref int Entity { get; }
  
  public ref int Hitbox { get; }
  
  public ref float CreationTime { get; }
  
  public ref int TintID { get; }
  
  public ref byte Version { get; }
  
  public ISchemaFixedArray<byte> Signature { get; }
  
}