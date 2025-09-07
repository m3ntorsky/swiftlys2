using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleVariableRef : SchemaClass, IParticleVariableRef {

  public CParticleVariableRef(nint handle) : base(handle) {
  }

  public CParticleVariableRef(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField VariableName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4FB747D9D3D609A6));
  }
  public ref PulseValueType_t VariableType {
    get => ref _Handle.AsRef<PulseValueType_t>(Schema.GetOffset(0x4FB747D9954B670D));
  }


}