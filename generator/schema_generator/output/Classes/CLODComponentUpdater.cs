using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLODComponentUpdater : CAnimComponentUpdater, ILODComponentUpdater {

  public CLODComponentUpdater(nint handle) : base(handle) {
  }

  public ref int ServerLOD {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDE1020D244E2C75));
  }


}