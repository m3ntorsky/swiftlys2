using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimActivity : SchemaClass, IAnimActivity {

  public CAnimActivity(nint handle) : base(handle) {
  }

  public CAnimActivity(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString Name {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0xB773FBB24D8F5786));
  }
  public ref int Activity {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB773FBB2E3986930));
  }
  public ref int Flags {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB773FBB2CE6E9C28));
  }
  public ref int Weight {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB773FBB2C5CC6905));
  }


}