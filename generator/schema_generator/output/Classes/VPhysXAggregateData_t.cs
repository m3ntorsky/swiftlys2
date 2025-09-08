using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VPhysXAggregateData_t : SchemaClass, IVPhysXAggregateData_t {

  public VPhysXAggregateData_t(nint handle) : base(handle) {
  }

  public ref ushort Flags {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xB689D5A1CE6E9C28));
  }
  public ref ushort RefCounter {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xB689D5A17E36A3B6));
  }
  public ref CUtlVector<uint> BonesHash {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0xB689D5A191F01C74));
  }
  public ref CUtlVector<CUtlString> BoneNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xB689D5A13CC0D1ED));
  }
  public ref CUtlVector<ushort> IndexNames {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0xB689D5A15B7383D9));
  }
  public ref CUtlVector<ushort> IndexHash {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0xB689D5A1FDBDCAEB));
  }
  public ref CUtlVector<matrix3x4a_t> BindPose {
    get => ref _Handle.AsRef<CUtlVector<matrix3x4a_t>>(Schema.GetOffset(0xB689D5A1751196C3));
  }
  public ref CUtlVector Parts {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xB689D5A1C7044545));
  }
  public ref CUtlVector ShapeMarkups {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xB689D5A109755123));
  }
  public ref CUtlVector Constraints2 {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xB689D5A10539BEDB));
  }
  public ref CUtlVector Joints {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xB689D5A15E6E8FEC));
  }
  public IPhysFeModelDesc_t FeModel {
    get => new PhysFeModelDesc_t(_Handle + Schema.GetOffset(0xB689D5A1299418A7));
  }
  public ref CUtlVector<ushort> BoneParents {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0xB689D5A171828F04));
  }
  public ref CUtlVector<uint> SurfacePropertyHashes {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0xB689D5A16C35E0E5));
  }
  public ref CUtlVector CollisionAttributes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xB689D5A1FA66F6C2));
  }
  public ref CUtlVector<CUtlString> DebugPartNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xB689D5A174B4FFC7));
  }
  public ref CUtlString EmbeddedKeyvalues {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB689D5A1C004AF5C));
  }


}