using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FuseVariableIndex_t : SchemaClass, IFuseVariableIndex_t {

  public FuseVariableIndex_t(nint handle) : base(handle) {
  }

  public ref ushort Value {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0xA039B887DCB0894A));
  }


}