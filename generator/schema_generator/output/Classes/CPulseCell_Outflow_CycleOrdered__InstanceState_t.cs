using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Outflow_CycleOrdered__InstanceState_t : SchemaClass, IPulseCell_Outflow_CycleOrdered__InstanceState_t {

  public CPulseCell_Outflow_CycleOrdered__InstanceState_t(nint handle) : base(handle) {
  }

  public CPulseCell_Outflow_CycleOrdered__InstanceState_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int NextIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB3EBE505EFEC0D98));
  }


}