using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimBone : ISchemaClass {

  
  public ref CBufferString Name { get; }
  
  public ref int Parent { get; }
  
  public ref Vector Pos { get; }
  
  public ref QuaternionStorage Quat { get; }
  
  public ref float Scale { get; }
  
  public ref QuaternionStorage Alignment { get; }
  
  public ref int Flags { get; }
}