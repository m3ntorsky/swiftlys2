using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ChainToSolveData_t : SchemaClass, IChainToSolveData_t {

  public ChainToSolveData_t(nint handle) : base(handle) {
  }

  public ChainToSolveData_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ChainIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x87A241BDA34589B6));
  }
  public IIKSolverSettings_t SolverSettings {
    get => new IKSolverSettings_t(_Handle + Schema.GetOffset(0x87A241BDE19D8233));
  }
  public IIKTargetSettings_t TargetSettings {
    get => new IKTargetSettings_t(_Handle + Schema.GetOffset(0x87A241BDD6828E35));
  }
  public ref SolveIKChainAnimNodeDebugSetting DebugSetting {
    get => ref _Handle.AsRef<SolveIKChainAnimNodeDebugSetting>(Schema.GetOffset(0x87A241BD624CC0B4));
  }
  public ref float DebugNormalizedValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x87A241BD0F331460));
  }
  public ref VectorAligned DebugOffset {
    get => ref _Handle.AsRef<VectorAligned>(Schema.GetOffset(0x87A241BD2FF28BBF));
  }


}