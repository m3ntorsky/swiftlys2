using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBreakableStageHelper : SchemaClass, IBreakableStageHelper {

  public CBreakableStageHelper(nint handle) : base(handle) {
  }

  public ref int CurrentStage {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF3B3D901E6644458));
  }
  public ref int StageCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF3B3D901117B2130));
  }


}