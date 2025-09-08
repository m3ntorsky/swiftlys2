using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CQuaternionAnimParameter : CConcreteAnimParameter, IQuaternionAnimParameter {

  public CQuaternionAnimParameter(nint handle) : base(handle) {
  }

  public ref Quaternion DefaultValue {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0xFAFCCCCABBE0341F));
  }
  public ref bool Interpolate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFAFCCCCAF6607650));
  }


}