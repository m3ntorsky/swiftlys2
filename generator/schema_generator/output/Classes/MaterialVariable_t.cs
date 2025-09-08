using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialVariable_t : SchemaClass, IMaterialVariable_t {

  public MaterialVariable_t(nint handle) : base(handle) {
  }

  public ref CUtlString StrVariable {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xCACB71DBA52C3390));
  }
  public IParticleAttributeIndex_t VariableField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xCACB71DBF868E9B3));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xCACB71DBB731A42F));
  }


}