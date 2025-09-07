using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomNamedModelSequence : C_INIT_RandomNamedModelElement, IC_INIT_RandomNamedModelSequence {

  public C_INIT_RandomNamedModelSequence(nint handle) : base(handle) {
  }

  public C_INIT_RandomNamedModelSequence(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}