using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ActiveModelConfig_t : SchemaClass, IActiveModelConfig_t {

  public ActiveModelConfig_t(nint handle) : base(handle) {
  }

  public ActiveModelConfig_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IModelConfigHandle_t Handle {
    get => new ModelConfigHandle_t(_Handle + Schema.GetOffset(0x554D81919D208453));
  }
  public ref CUtlSymbolLarge Name {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x554D8191CAE8A266));
  }
  public ref CUtlVector< CHandle< CBaseModelEntity > > AssociatedEntities {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CBaseModelEntity > >>(Schema.GetOffset(0x554D8191D6EB4F18));
  }
  public ref CUtlVector< CUtlSymbolLarge > AssociatedEntityNames {
    get => ref _Handle.AsRef<CUtlVector< CUtlSymbolLarge >>(Schema.GetOffset(0x554D8191EB3B241C));
  }

  public void HandleUpdated() {
    Schema.Update(_Handle, 0x554D81919D208453);
  }
  public void NameUpdated() {
    Schema.Update(_Handle, 0x554D8191CAE8A266);
  }
  public void AssociatedEntitiesUpdated() {
    Schema.Update(_Handle, 0x554D8191D6EB4F18);
  }
  public void AssociatedEntityNamesUpdated() {
    Schema.Update(_Handle, 0x554D8191EB3B241C);
  }
}