using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAttributeManager : SchemaClass, IAttributeManager {

  public CAttributeManager(nint handle) : base(handle) {
  }

  public ref CUtlVector Providers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x7FCB380DA07F345D));
  }
  public ref bool PreventLoopback {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7FCB380D2CE71CA4));
  }
  public ref CUtlVector CachedResults {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x7FCB380D3CD4B7CB));
  }

  public void ReapplyProvisionParityUpdated() {
    Schema.Update(_Handle, 0x7FCB380D2F68110B);
  }
  public void OuterUpdated() {
    Schema.Update(_Handle, 0x7FCB380D30AE9FA2);
  }
  public void ProviderTypeUpdated() {
    Schema.Update(_Handle, 0x7FCB380DD5677CB4);
  }
}