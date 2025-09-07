using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class InfoForResourceTypeIPulseGraphDef : SchemaClass, IInfoForResourceTypeIPulseGraphDef {

  public InfoForResourceTypeIPulseGraphDef(nint handle) : base(handle) {
  }

  public InfoForResourceTypeIPulseGraphDef(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}