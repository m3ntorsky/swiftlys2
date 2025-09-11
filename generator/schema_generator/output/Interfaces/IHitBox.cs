using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHitBox : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref CUtlString SurfaceProperty { get; }
  
  public ref CUtlString BoneName { get; }
  
  public ref Vector MinBounds { get; }
  
  public ref Vector MaxBounds { get; }
  
  public ref float ShapeRadius { get; }
  
  public ref uint BoneNameHash { get; }
  
  public ref int GroupId { get; }
  
  public ref byte ShapeType { get; }
  
  public ref bool TranslationOnly { get; }
  
  public ref uint CRC { get; }
  
  public ref Color CRenderColor { get; }
  
  public ref ushort HitBoxIndex { get; }
}