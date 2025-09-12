using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysFixed : CPhysConstraint, IPhysFixed {

  public CPhysFixed(nint handle) : base(handle) {
  }

  public ref float LinearFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E8A38382FE6B034));
  }
  public ref float LinearDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E8A383882438FAF));
  }
  public ref float AngularFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E8A383836D56C7B));
  }
  public ref float AngularDampingRatio {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8E8A3838689E74E2));
  }
  public ref bool EnableLinearConstraint {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E8A383868F4518C));
  }
  public ref bool EnableAngularConstraint {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E8A3838F98A5C8B));
  }
  public ISchemaUntypedField BoneName1 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8E8A3838EA2A0C6A));
  }
  public ISchemaUntypedField BoneName2 {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8E8A3838E92A0AD7));
  }


}