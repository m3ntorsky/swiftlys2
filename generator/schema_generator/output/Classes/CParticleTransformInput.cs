using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleTransformInput : CParticleInput, IParticleTransformInput {

  public CParticleTransformInput(nint handle) : base(handle) {
  }

  public CParticleTransformInput(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ParticleTransformType_t Type {
    get => ref _Handle.AsRef<ParticleTransformType_t>(Schema.GetOffset(0x9DF3328C18853D59));
  }
  public ISchemaUntypedField NamedValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x9DF3328CE0618727));
  }
  public ref bool FollowNamedValue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DF3328C0F6CBBBA));
  }
  public ref bool SupportsDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DF3328CCCD6A201));
  }
  public ref bool UseOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DF3328C8DAE39FE));
  }
  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DF3328C0D0DDF8C));
  }
  public ref int ControlPointRangeMax {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DF3328CE07DB935));
  }
  public ref float EndCPGrowthTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9DF3328CC156B981));
  }


}