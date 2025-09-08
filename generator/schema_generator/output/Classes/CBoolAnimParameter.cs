using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoolAnimParameter : CConcreteAnimParameter, IBoolAnimParameter {

  public CBoolAnimParameter(nint handle) : base(handle) {
  }

  public ref bool DefaultValue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3BF60C6A26126DF));
  }


}