using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimEnum : SchemaClass, IAnimEnum {

  public CAnimEnum(nint handle) : base(handle) {
  }

  public ref byte Value {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xFB67C2A26B99AEEA));
  }


}