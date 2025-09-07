using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseTestScriptLib : SchemaClass, IPulseTestScriptLib {

  public CPulseTestScriptLib(nint handle) : base(handle) {
  }

  public CPulseTestScriptLib(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}