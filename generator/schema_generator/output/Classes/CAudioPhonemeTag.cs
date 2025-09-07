using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAudioPhonemeTag : SchemaClass, IAudioPhonemeTag {

  public CAudioPhonemeTag(nint handle) : base(handle) {
  }

  public CAudioPhonemeTag(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float StartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBE68CF3E67FE9DC4));
  }
  public ref float EndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBE68CF3E2041DF9D));
  }
  public ref int PhonemeCode {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBE68CF3EBFB1B4C4));
  }


}