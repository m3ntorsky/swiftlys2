using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapNamedModelSequenceToScalar : C_INIT_RemapNamedModelElementToScalar, IC_INIT_RemapNamedModelSequenceToScalar {

  public C_INIT_RemapNamedModelSequenceToScalar(nint handle) : base(handle) {
  }

  public C_INIT_RemapNamedModelSequenceToScalar(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}