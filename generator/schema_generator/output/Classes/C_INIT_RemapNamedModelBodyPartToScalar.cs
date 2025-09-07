using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapNamedModelBodyPartToScalar : C_INIT_RemapNamedModelElementToScalar, IC_INIT_RemapNamedModelBodyPartToScalar {

  public C_INIT_RemapNamedModelBodyPartToScalar(nint handle) : base(handle) {
  }

  public C_INIT_RemapNamedModelBodyPartToScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}