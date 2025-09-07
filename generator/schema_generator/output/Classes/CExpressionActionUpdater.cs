using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CExpressionActionUpdater : CAnimActionUpdater, IExpressionActionUpdater {

  public CExpressionActionUpdater(nint handle) : base(handle) {
  }

  public CExpressionActionUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimParamHandle Param {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x3B8502F3679286A4));
  }
  public ref AnimParamType_t ParamType {
    get => ref _Handle.AsRef<AnimParamType_t>(Schema.GetOffset(0x3B8502F3F05DFDD9));
  }
  public IAnimScriptHandle Script {
    get => new AnimScriptHandle(_Handle + Schema.GetOffset(0x3B8502F329D70FB0));
  }


}