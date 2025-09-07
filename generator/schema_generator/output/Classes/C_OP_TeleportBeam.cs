using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_TeleportBeam : CParticleFunctionOperator, IC_OP_TeleportBeam {

  public C_OP_TeleportBeam(nint handle) : base(handle) {
  }

  public C_OP_TeleportBeam(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CPPosition {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD80BE8C1AECEEF2D));
  }
  public ref int CPVelocity {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD80BE8C165FA13B9));
  }
  public ref int CPMisc {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD80BE8C1466D5C8A));
  }
  public ref int CPColor {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD80BE8C14B880225));
  }
  public ref int CPInvalidColor {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD80BE8C1370493BC));
  }
  public ref int CPExtraArcData {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD80BE8C1FE881B08));
  }
  public ref Vector Gravity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD80BE8C1A5AE4779));
  }
  public ref float ArcMaxDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD80BE8C150FE58BD));
  }
  public ref float SegmentBreak {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD80BE8C18DEE8E2F));
  }
  public ref float ArcSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD80BE8C14E9BC58C));
  }
  public ref float Alpha {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD80BE8C1A0DB7DD1));
  }


}