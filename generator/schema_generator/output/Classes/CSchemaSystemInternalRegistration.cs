using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSchemaSystemInternalRegistration : SchemaClass, ISchemaSystemInternalRegistration {

  public CSchemaSystemInternalRegistration(nint handle) : base(handle) {
  }

  public CSchemaSystemInternalRegistration(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector2D Vector2D {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xDDD6CA303570333C));
  }
  public ref Vector Vector {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDDD6CA30FE2AA082));
  }
  public ref VectorAligned VectorAligned {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0xDDD6CA3076A2F792));
  }
  public ref Quaternion Quaternion {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0xDDD6CA308FFA070D));
  }
  public ref QAngle QAngle {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xDDD6CA30D3989847));
  }
  public ISchemaUntypedField RotationVector {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDDD6CA30D5A2443C));
  }
  public ref RadianEuler RadianEuler {
    get => ref _Handle.AsRef<RadianEuler>(Schema.GetOffset(0xDDD6CA30E6A91A09));
  }
  public ref DegreeEuler DegreeEuler {
    get => ref _Handle.AsRef<DegreeEuler>(Schema.GetOffset(0xDDD6CA30FCD6D92E));
  }
  public ref QuaternionStorage QuaternionStorage {
    get => ref _Handle.AsRef<QuaternionStorage>(Schema.GetOffset(0xDDD6CA303C6C2D0E));
  }
  public ref matrix3x4_t Matrix3x4_t {
    get => ref _Handle.AsRef<matrix3x4_t>(Schema.GetOffset(0xDDD6CA30EC15D3EA));
  }
  public ref matrix3x4a_t Matrix3x4a_t {
    get => ref _Handle.AsRef<matrix3x4a_t>(Schema.GetOffset(0xDDD6CA30E298503B));
  }
  public ref Color Color {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xDDD6CA30D7D017D8));
  }
  public ref Vector4D Vector4D {
    get => ref _Handle.AsRef<Vector4D>(Schema.GetOffset(0xDDD6CA30197F11B2));
  }
  public ref CTransform CTransform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xDDD6CA3045C7677A));
  }
  public ISchemaUntypedField KeyValues {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDDD6CA3011F5FBEC));
  }
  public ref CUtlBinaryBlock CUtlBinaryBlock {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0xDDD6CA307F63D33D));
  }
  public ref CUtlString CUtlString {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDDD6CA3041577950));
  }
  public ref CUtlSymbol CUtlSymbol {
    get => ref _Handle.AsRef<CUtlSymbol>(Schema.GetOffset(0xDDD6CA30EA008FA9));
  }
  public ref CUtlStringToken StringToken {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0xDDD6CA3049D8C20D));
  }
  public ref CUtlStringTokenWithStorage StringTokenWithStorage {
    get => ref _Handle.AsRef<CUtlStringTokenWithStorage>(Schema.GetOffset(0xDDD6CA30A8DD475A));
  }
  public ISchemaUntypedField ResourceTypes {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDDD6CA30410F830A));
  }
  public ISchemaUntypedField KV3 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDDD6CA302E1AEFC5));
  }


}