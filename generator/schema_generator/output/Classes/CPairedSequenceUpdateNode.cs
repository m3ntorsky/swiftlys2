using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPairedSequenceUpdateNode : CSequenceUpdateNodeBase, IPairedSequenceUpdateNode {

  public CPairedSequenceUpdateNode(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol PairedSequenceRole {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0xB2B6F0EB4A4CFB12));
  }


}