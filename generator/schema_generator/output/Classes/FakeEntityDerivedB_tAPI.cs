using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FakeEntityDerivedB_tAPI : SchemaClass, IFakeEntityDerivedB_tAPI {

  public FakeEntityDerivedB_tAPI(nint handle) : base(handle) {
  }

  public FakeEntityDerivedB_tAPI(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}