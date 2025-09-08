using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqS1SeqDesc : SchemaClass, ISeqS1SeqDesc {

  public CSeqS1SeqDesc(nint handle) : base(handle) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x6EF8193563D22D49));
  }
  public ISeqSeqDescFlag Flags {
    get => new CSeqSeqDescFlag(_Handle + Schema.GetOffset(0x6EF81935DC74A14C));
  }
  public ISeqMultiFetch Fetch {
    get => new CSeqMultiFetch(_Handle + Schema.GetOffset(0x6EF81935ED8BE703));
  }
  public ref int LocalWeightlist {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6EF819356F64F49C));
  }
  public ref CUtlVector AutoLayerArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x6EF81935834EB170));
  }
  public ref CUtlVector IKLockArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x6EF81935BF1FEC6B));
  }
  public ISeqTransition Transition {
    get => new CSeqTransition(_Handle + Schema.GetOffset(0x6EF8193582B0A282));
  }
  public ISchemaUntypedField SequenceKeys {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6EF81935C7ACD18C));
  }
  public ref CBufferString LegacyKeyValueText {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x6EF81935D12D4AC1));
  }
  public ref CUtlVector ActivityArray {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x6EF8193538F0ACE1));
  }
  public ref CUtlVector FootMotion {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x6EF8193543CF70A3));
  }


}