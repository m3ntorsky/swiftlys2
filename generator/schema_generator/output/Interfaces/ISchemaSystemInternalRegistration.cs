using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISchemaSystemInternalRegistration : ISchemaClass {

  
  public ref Vector2D Vector2D { get; }
  
  public ref Vector Vector { get; }
  
  public ref VectorAligned VectorAligned { get; }
  
  public ref Quaternion Quaternion { get; }
  
  public ref QAngle QAngle { get; }
  
  public ISchemaUntypedField RotationVector { get; }
  
  public ref RadianEuler RadianEuler { get; }
  
  public ref DegreeEuler DegreeEuler { get; }
  
  public ref QuaternionStorage QuaternionStorage { get; }
  
  public ref matrix3x4_t Matrix3x4_t { get; }
  
  public ref matrix3x4a_t Matrix3x4a_t { get; }
  
  public ref Color Color { get; }
  
  public ref Vector4D Vector4D { get; }
  
  public ref CTransform CTransform { get; }
  
  public ISchemaUntypedField KeyValues { get; }
  
  public ref CUtlBinaryBlock CUtlBinaryBlock { get; }
  
  public ref CUtlString CUtlString { get; }
  
  public ref CUtlSymbol CUtlSymbol { get; }
  
  public ref CUtlStringToken StringToken { get; }
  
  public ref CUtlStringTokenWithStorage StringTokenWithStorage { get; }
  
  public ISchemaUntypedField ResourceTypes { get; }
  
  public ISchemaUntypedField KV3 { get; }
}