using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSSDSMsg_PostLayer : CSSDSMsg_LayerBase, ISSDSMsg_PostLayer {

  public CSSDSMsg_PostLayer(nint handle) : base(handle) {
  }

  public CSSDSMsg_PostLayer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}