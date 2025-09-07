using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseTestFuncs_LibraryA : SchemaClass, IPulseTestFuncs_LibraryA {

  public CPulseTestFuncs_LibraryA(nint handle) : base(handle) {
  }

  public CPulseTestFuncs_LibraryA(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}