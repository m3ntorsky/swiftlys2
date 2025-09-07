using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class InfoForResourceTypeIVectorGraphic : SchemaClass, IInfoForResourceTypeIVectorGraphic {

  public InfoForResourceTypeIVectorGraphic(nint handle) : base(handle) {
  }

  public InfoForResourceTypeIVectorGraphic(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}