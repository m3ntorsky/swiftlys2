using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHandshakeAnimTagBase : CAnimTagBase, IHandshakeAnimTagBase {

  public CHandshakeAnimTagBase(nint handle) : base(handle) {
  }

  public ref bool IsDisableTag {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x73566C0F04E21131));
  }


}