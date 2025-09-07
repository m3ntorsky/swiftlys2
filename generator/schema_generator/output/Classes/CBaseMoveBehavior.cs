using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseMoveBehavior : CPathKeyFrame, IBaseMoveBehavior {

  public CBaseMoveBehavior(nint handle) : base(handle) {
  }

  public CBaseMoveBehavior(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int PositionInterpolator {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4C94E06076D631CA));
  }
  public ref int RotationInterpolator {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4C94E060D5ABDED3));
  }
  public ref float AnimStartTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C94E060C2FA1CCF));
  }
  public ref float AnimEndTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C94E06042C3E66A));
  }
  public ref float AverageSpeedAcrossFrame {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C94E0603F4A5B51));
  }
  public IPathKeyFrame CurrentKeyFrame {
    get => new CPathKeyFrame(_Handle + Schema.GetOffset(0x4C94E060AF22FD24));
  }
  public IPathKeyFrame TargetKeyFrame {
    get => new CPathKeyFrame(_Handle + Schema.GetOffset(0x4C94E0606B9E13EA));
  }
  public IPathKeyFrame PreKeyFrame {
    get => new CPathKeyFrame(_Handle + Schema.GetOffset(0x4C94E0609753526C));
  }
  public IPathKeyFrame PostKeyFrame {
    get => new CPathKeyFrame(_Handle + Schema.GetOffset(0x4C94E06033EC8ED5));
  }
  public ref float TimeIntoFrame {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4C94E060C6B111CD));
  }
  public ref int Direction {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4C94E0606BDD23E5));
  }


}