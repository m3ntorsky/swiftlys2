using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoolAnimParameter : CConcreteAnimParameter, IBoolAnimParameter {

  public CBoolAnimParameter(nint handle) : base(handle) {
  }

  public CBoolAnimParameter(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool DefaultValue {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x3BF60C6A26126DF));
  }


}