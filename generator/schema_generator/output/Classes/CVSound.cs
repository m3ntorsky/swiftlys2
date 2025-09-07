using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVSound : SchemaClass, IVSound {

  public CVSound(nint handle) : base(handle) {
  }

  public CVSound(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Rate {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x478C987331106783));
  }
  public ref CVSoundFormat_t Format {
    get => ref _Handle.AsRef<CVSoundFormat_t>(Schema.GetOffset(0x478C9873A87491AE));
  }
  public ref uint Channels {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x478C98735A815AD1));
  }
  public ref int LoopStart {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x478C9873A12E4295));
  }
  public ref uint SampleCount {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x478C98732DEF676A));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x478C9873BC5E3BAB));
  }
  public ref CUtlVector< CAudioSentence > Sentences {
    get => ref _Handle.AsRef<CUtlVector< CAudioSentence >>(Schema.GetOffset(0x478C98730FF1D785));
  }
  public ref uint StreamingSize {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x478C9873CB44A8AE));
  }
  public ref CUtlVector< int32 > SeekTable {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x478C987388E17207));
  }
  public ref int LoopEnd {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x478C9873900B36CC));
  }
  public ref CUtlBinaryBlock EncodedHeader {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0x478C9873BDA3C36C));
  }


}