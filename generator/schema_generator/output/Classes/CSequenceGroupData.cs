using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSequenceGroupData : SchemaClass, ISequenceGroupData {

  public CSequenceGroupData(nint handle) : base(handle) {
  }

  public CSequenceGroupData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xF2F9B8263D22D49));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xF2F9B82CE6E9C28));
  }
  public ref CUtlVector< CBufferString > LocalSequenceNameArray {
    get => ref _Handle.AsRef<CUtlVector< CBufferString >>(Schema.GetOffset(0xF2F9B820E9F09FF));
  }
  public ref CUtlVector< CSeqS1SeqDesc > LocalS1SeqDescArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqS1SeqDesc >>(Schema.GetOffset(0xF2F9B828BEF5ECB));
  }
  public ref CUtlVector< CSeqS1SeqDesc > LocalMultiSeqDescArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqS1SeqDesc >>(Schema.GetOffset(0xF2F9B82DC0E5EC6));
  }
  public ref CUtlVector< CSeqSynthAnimDesc > LocalSynthAnimDescArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqSynthAnimDesc >>(Schema.GetOffset(0xF2F9B82BD6C1F83));
  }
  public ref CUtlVector< CSeqCmdSeqDesc > LocalCmdSeqDescArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqCmdSeqDesc >>(Schema.GetOffset(0xF2F9B822371FDAB));
  }
  public ref CUtlVector< CSeqBoneMaskList > LocalBoneMaskArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqBoneMaskList >>(Schema.GetOffset(0xF2F9B82C880268F));
  }
  public ref CUtlVector< CSeqScaleSet > LocalScaleSetArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqScaleSet >>(Schema.GetOffset(0xF2F9B8241FDCDAB));
  }
  public ref CUtlVector< CBufferString > LocalBoneNameArray {
    get => ref _Handle.AsRef<CUtlVector< CBufferString >>(Schema.GetOffset(0xF2F9B82B86CAC56));
  }
  public ref CBufferString LocalNodeName {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xF2F9B82EDCB530F));
  }
  public ref CUtlVector< CSeqPoseParamDesc > LocalPoseParamArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqPoseParamDesc >>(Schema.GetOffset(0xF2F9B82FF654A73));
  }
  public ISchemaUntypedField KeyValues {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xF2F9B8221578BC2));
  }
  public ref CUtlVector< CSeqIKLock > LocalIKAutoplayLockArray {
    get => ref _Handle.AsRef<CUtlVector< CSeqIKLock >>(Schema.GetOffset(0xF2F9B82AD4D3FFB));
  }


}