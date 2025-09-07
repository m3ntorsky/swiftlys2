using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class constraint_hingeparams_t : SchemaClass, Iconstraint_hingeparams_t {

  public constraint_hingeparams_t(nint handle) : base(handle) {
  }

  public constraint_hingeparams_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector WorldPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x790804C3F16C2360));
  }
  public ref Vector WorldAxisDirection {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x790804C3637CEB43));
  }
  public Iconstraint_axislimit_t HingeAxis {
    get => new constraint_axislimit_t(_Handle + Schema.GetOffset(0x790804C33BD096FD));
  }
  public Iconstraint_breakableparams_t Constraint {
    get => new constraint_breakableparams_t(_Handle + Schema.GetOffset(0x790804C3B822E25A));
  }


}