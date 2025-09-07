using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPairedSequenceUpdateNode : CSequenceUpdateNodeBase, IPairedSequenceUpdateNode {

  public CPairedSequenceUpdateNode(nint handle) : base(handle) {
  }

  public CPairedSequenceUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CGlobalSymbol PairedSequenceRole {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xB2B6F0EB4A4CFB12));
  }


}