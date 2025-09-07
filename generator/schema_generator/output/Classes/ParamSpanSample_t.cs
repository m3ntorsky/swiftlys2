using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParamSpanSample_t : SchemaClass, IParamSpanSample_t {

  public ParamSpanSample_t(nint handle) : base(handle) {
  }

  public ParamSpanSample_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Value {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x37E203136B99AEEA));
  }
  public ref float Cycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x37E203130C77829F));
  }


}