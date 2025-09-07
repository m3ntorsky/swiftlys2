using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_TestDomainEntFire : CPulseCell_BaseFlow, IPulseCell_Step_TestDomainEntFire {

  public CPulseCell_Step_TestDomainEntFire(nint handle) : base(handle) {
  }

  public CPulseCell_Step_TestDomainEntFire(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Input {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x22A0E258942A24FB));
  }


}