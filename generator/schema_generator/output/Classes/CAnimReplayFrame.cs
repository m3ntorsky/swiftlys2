using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimReplayFrame : SchemaClass, IAnimReplayFrame {

  public CAnimReplayFrame(nint handle) : base(handle) {
  }

  public CAnimReplayFrame(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CUtlBinaryBlock > InputDataBlocks {
    get => ref _Handle.AsRef<CUtlVector< CUtlBinaryBlock >>(Schema.GetOffset(0xBED2F401F7E8195D));
  }
  public ref CUtlBinaryBlock InstanceData {
    get => ref _Handle.AsRef<CUtlBinaryBlock>(Schema.GetOffset(0xBED2F401AE26D9C2));
  }
  public ref CTransform StartingLocalToWorldTransform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xBED2F40140311BA5));
  }
  public ref CTransform LocalToWorldTransform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xBED2F401AE75F5B9));
  }
  public ref float TimeStamp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBED2F4014335BEE3));
  }


}