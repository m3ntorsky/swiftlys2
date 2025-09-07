using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomNamedModelBodyPart : C_INIT_RandomNamedModelElement, IC_INIT_RandomNamedModelBodyPart {

  public C_INIT_RandomNamedModelBodyPart(nint handle) : base(handle) {
  }

  public C_INIT_RandomNamedModelBodyPart(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}