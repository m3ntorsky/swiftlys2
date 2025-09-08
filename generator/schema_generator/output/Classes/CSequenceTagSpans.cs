using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSequenceTagSpans : SchemaClass, ISequenceTagSpans {

  public CSequenceTagSpans(nint handle) : base(handle) {
  }

  public ref CGlobalSymbol SequenceName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x132BFE6A7462AF30));
  }
  public ref CUtlVector Tags {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x132BFE6AB46C8540));
  }


}