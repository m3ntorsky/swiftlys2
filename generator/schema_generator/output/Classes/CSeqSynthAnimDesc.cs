using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqSynthAnimDesc : SchemaClass, ISeqSynthAnimDesc {

  public CSeqSynthAnimDesc(nint handle) : base(handle) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x7D8317C163D22D49));
  }
  public ISeqSeqDescFlag Flags {
    get => new CSeqSeqDescFlag(_Handle + Schema.GetOffset(0x7D8317C1DC74A14C));
  }
  public ISeqTransition Transition {
    get => new CSeqTransition(_Handle + Schema.GetOffset(0x7D8317C182B0A282));
  }
  public ref short LocalBaseReference {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x7D8317C1FE93178E));
  }
  public ref short LocalBoneMask {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x7D8317C191EDF3D2));
  }
  public ref CUtlVector ActivityArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x7D8317C138F0ACE1));
  }


}