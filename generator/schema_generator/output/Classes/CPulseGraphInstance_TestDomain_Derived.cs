using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseGraphInstance_TestDomain_Derived : CPulseGraphInstance_TestDomain, IPulseGraphInstance_TestDomain_Derived {

  public CPulseGraphInstance_TestDomain_Derived(nint handle) : base(handle) {
  }

  public CPulseGraphInstance_TestDomain_Derived(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int InstanceValueX {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x439D00CDD2DC0135));
  }


}