using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVectorAnimParameter : CConcreteAnimParameter, IVectorAnimParameter {

  public CVectorAnimParameter(nint handle) : base(handle) {
  }

  public ref Vector DefaultValue {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x74346C8BBBE0341F));
  }
  public ref bool Interpolate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x74346C8BF6607650));
  }


}