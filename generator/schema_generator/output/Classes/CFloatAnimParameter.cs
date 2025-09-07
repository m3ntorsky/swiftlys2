using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFloatAnimParameter : CConcreteAnimParameter, IFloatAnimParameter {

  public CFloatAnimParameter(nint handle) : base(handle) {
  }

  public CFloatAnimParameter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float DefaultValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6CE7934089D370B3));
  }
  public ref float MinValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6CE79340AD86BD50));
  }
  public ref float MaxValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6CE79340DB7358B2));
  }
  public ref bool Interpolate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6CE79340F6607650));
  }


}