using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHitBox : SchemaClass, IHitBox {

  public CHitBox(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x97E3DD244D8F5786));
  }
  public ref CUtlString SurfaceProperty {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x97E3DD241A25534C));
  }
  public ref CUtlString BoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x97E3DD247559AC1F));
  }
  public ref Vector MinBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x97E3DD24114799FE));
  }
  public ref Vector MaxBounds {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x97E3DD24C0B4CE60));
  }
  public ref float ShapeRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x97E3DD24D8107F0E));
  }
  public ref uint BoneNameHash {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x97E3DD24767FF938));
  }
  public ref int GroupId {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x97E3DD245BB08395));
  }
  public ref byte ShapeType {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x97E3DD24AE159B72));
  }
  public ref bool TranslationOnly {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x97E3DD24B775D846));
  }
  public ref uint CRC {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x97E3DD244E8CCEF9));
  }
  public ref Color CRenderColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x97E3DD24723B0259));
  }
  public ref ushort HitBoxIndex {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x97E3DD24770A3AE9));
  }


}