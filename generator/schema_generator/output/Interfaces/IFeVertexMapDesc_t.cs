using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeVertexMapDesc_t : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref uint NameHash { get; }
  
  public ref uint Color { get; }
  
  public ref uint Flags { get; }
  
  public ref ushort VertexBase { get; }
  
  public ref ushort VertexCount { get; }
  
  public ref uint MapOffset { get; }
  
  public ref uint NodeListOffset { get; }
  
  public ref Vector CenterOfMass { get; }
  
  public ref float VolumetricSolveStrength { get; }
  
  public ref short ScaleSourceNode { get; }
  
  public ref ushort NodeListCount { get; }
}