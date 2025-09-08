using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSequenceFinishedAnimTag : CAnimTagBase, ISequenceFinishedAnimTag {

  public CSequenceFinishedAnimTag(nint handle) : base(handle) {
  }

  public ref CUtlString SequenceName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x1B46C5202B4A24CB));
  }


}