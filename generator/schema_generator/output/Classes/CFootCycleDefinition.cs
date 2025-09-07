using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootCycleDefinition : SchemaClass, IFootCycleDefinition {

  public CFootCycleDefinition(nint handle) : base(handle) {
  }

  public CFootCycleDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector StancePositionMS {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6D604C9567085F86));
  }
  public ref Vector MidpointPositionMS {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6D604C9553980B1A));
  }
  public ref float StanceDirectionMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6D604C95848F3868));
  }
  public ref Vector ToStrideStartPos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x6D604C953F2E1417));
  }
  public IAnimCycle StanceCycle {
    get => new CAnimCycle(_Handle + Schema.GetOffset(0x6D604C954EDCBD91));
  }
  public IFootCycle FootLiftCycle {
    get => new CFootCycle(_Handle + Schema.GetOffset(0x6D604C9553A7B946));
  }
  public IFootCycle FootOffCycle {
    get => new CFootCycle(_Handle + Schema.GetOffset(0x6D604C959AC5AE30));
  }
  public IFootCycle FootStrikeCycle {
    get => new CFootCycle(_Handle + Schema.GetOffset(0x6D604C95E4D3DC2B));
  }
  public IFootCycle FootLandCycle {
    get => new CFootCycle(_Handle + Schema.GetOffset(0x6D604C954C100B46));
  }


}