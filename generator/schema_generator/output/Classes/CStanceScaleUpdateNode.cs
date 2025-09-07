using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CStanceScaleUpdateNode : CUnaryUpdateNode, IStanceScaleUpdateNode {

  public CStanceScaleUpdateNode(nint handle) : base(handle) {
  }

  public CStanceScaleUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimParamHandle Param {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA2CC6975679286A4));
  }


}