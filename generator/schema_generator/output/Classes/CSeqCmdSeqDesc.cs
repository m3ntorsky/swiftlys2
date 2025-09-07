using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSeqCmdSeqDesc : SchemaClass, ISeqCmdSeqDesc {

  public CSeqCmdSeqDesc(nint handle) : base(handle) {
  }

  public CSeqCmdSeqDesc(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x8619E10F63D22D49));
  }
  public ISeqSeqDescFlag Flags {
    get => new CSeqSeqDescFlag(_Handle + Schema.GetOffset(0x8619E10FDC74A14C));
  }
  public ISeqTransition Transition {
    get => new CSeqTransition(_Handle + Schema.GetOffset(0x8619E10F82B0A282));
  }
  public ref short FrameRangeSequence {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x8619E10FAE2B7FB6));
  }
  public ref short FrameCount {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x8619E10F1DBCD049));
  }
  public ref float FPS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8619E10F38CAA4F6));
  }
  public ref short SubCycles {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x8619E10FBA8C5B82));
  }
  public ref short NumLocalResults {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x8619E10FC4396DD8));
  }
  public ref CUtlVector< CSeqCmdLayer > CmdLayerArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqCmdLayer >>(Schema.GetOffset(0x8619E10FA7272079));
  }
  public ref CUtlVector< CAnimEventDefinition > EventArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimEventDefinition >>(Schema.GetOffset(0x8619E10FB9FB599C));
  }
  public ref CUtlVector< CAnimActivity > ActivityArray {
    get => ref _Handle.AsRef<CUtlVector< CAnimActivity >>(Schema.GetOffset(0x8619E10F38F0ACE1));
  }
  public ref CUtlVector< CSeqPoseSetting > PoseSettingArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqPoseSetting >>(Schema.GetOffset(0x8619E10FD257125D));
  }


}