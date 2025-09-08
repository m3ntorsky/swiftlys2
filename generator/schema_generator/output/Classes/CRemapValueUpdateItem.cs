using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRemapValueUpdateItem : SchemaClass, IRemapValueUpdateItem {

  public CRemapValueUpdateItem(nint handle) : base(handle) {
  }

  public IAnimParamHandle ParamIn {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x93C5E8D6ED40E37B));
  }
  public IAnimParamHandle ParamOut {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x93C5E8D6AA5799A8));
  }
  public ref float MinInputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93C5E8D6BDB4BC64));
  }
  public ref float MaxInputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93C5E8D63EF75C2A));
  }
  public ref float MinOutputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93C5E8D6F63C7011));
  }
  public ref float MaxOutputValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x93C5E8D6A91B71B3));
  }


}