using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomNamedModelMeshGroup : C_INIT_RandomNamedModelElement, IC_INIT_RandomNamedModelMeshGroup {

  public C_INIT_RandomNamedModelMeshGroup(nint handle) : base(handle) {
  }

  public C_INIT_RandomNamedModelMeshGroup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}