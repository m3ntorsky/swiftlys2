using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SolveIKChainPoseOpFixedSettings_t : SchemaClass, ISolveIKChainPoseOpFixedSettings_t {

  public SolveIKChainPoseOpFixedSettings_t(nint handle) : base(handle) {
  }

  public SolveIKChainPoseOpFixedSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< ChainToSolveData_t > ChainsToSolveData {
    get => ref _Handle.AsRef<CUtlVector< ChainToSolveData_t >>(Schema.GetOffset(0x983BF8BD94B979E5));
  }


}