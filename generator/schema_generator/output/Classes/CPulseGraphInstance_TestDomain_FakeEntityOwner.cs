using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseGraphInstance_TestDomain_FakeEntityOwner : CBasePulseGraphInstance, IPulseGraphInstance_TestDomain_FakeEntityOwner {

  public CPulseGraphInstance_TestDomain_FakeEntityOwner(nint handle) : base(handle) {
  }

  public CPulseGraphInstance_TestDomain_FakeEntityOwner(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}