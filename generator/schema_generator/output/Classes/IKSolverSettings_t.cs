using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class IKSolverSettings_t : SchemaClass, IIKSolverSettings_t {

  public IKSolverSettings_t(nint handle) : base(handle) {
  }

  public IKSolverSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref IKSolverType SolverType {
    get => ref _Handle.AsRef<IKSolverType>(Schema.GetOffset(0x368DC59819CA61B6));
  }
  public ref int NumIterations {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x368DC59878BB0057));
  }
  public ref EIKEndEffectorRotationFixUpMode EndEffectorRotationFixUpMode {
    get => ref _Handle.AsRef<EIKEndEffectorRotationFixUpMode>(Schema.GetOffset(0x368DC5980B45E281));
  }


}