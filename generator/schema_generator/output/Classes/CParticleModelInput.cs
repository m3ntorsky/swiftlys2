using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleModelInput : CParticleInput, IParticleModelInput {

  public CParticleModelInput(nint handle) : base(handle) {
  }

  public CParticleModelInput(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ParticleModelType_t Type {
    get => ref _Handle.AsRef<ParticleModelType_t>(Schema.GetOffset(0xC8FF4F3F18853D59));
  }
  public ISchemaUntypedField NamedValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC8FF4F3FE0618727));
  }
  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC8FF4F3F0D0DDF8C));
  }


}