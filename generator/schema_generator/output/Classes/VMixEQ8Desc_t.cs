using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixEQ8Desc_t : SchemaClass, IVMixEQ8Desc_t {

  public VMixEQ8Desc_t(nint handle) : base(handle) {
  }

  public IVMixFilterDesc_t Stages {
    get => new VMixFilterDesc_t(_Handle, 0xBF8A6F07B955349A, 8, 16, 4);
  }


}