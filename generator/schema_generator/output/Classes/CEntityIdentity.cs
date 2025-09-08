using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEntityIdentity : SchemaClass, IEntityIdentity {

  public CEntityIdentity(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge Name {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xAE42345F4D8F5786));
  }
  public ref CUtlSymbolLarge DesignerName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xAE42345FBFC1F33F));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xAE42345FDC74A14C));
  }
  public ref WorldGroupId_t WorldGroupId {
    get => ref _Handle.AsRef<WorldGroupId_t>(Schema.GetOffset(0xAE42345F0BECFAC7));
  }
  public ref uint DataObjectTypes {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xAE42345F6C7E475F));
  }
  public IChangeAccessorFieldPathIndex_t PathIndex {
    get => new ChangeAccessorFieldPathIndex_t(_Handle + Schema.GetOffset(0xAE42345F2DA3F47A));
  }
  public IEntityIdentity Prev {
    get => new CEntityIdentity(_Handle + Schema.GetOffset(0xAE42345FD49AD9AA));
  }
  public IEntityIdentity Next {
    get => new CEntityIdentity(_Handle + Schema.GetOffset(0xAE42345F32B11E0E));
  }
  public IEntityIdentity PrevByClass {
    get => new CEntityIdentity(_Handle + Schema.GetOffset(0xAE42345F1F46E9A5));
  }
  public IEntityIdentity NextByClass {
    get => new CEntityIdentity(_Handle + Schema.GetOffset(0xAE42345F908D6209));
  }

  public void NameStringableIndexUpdated() {
    Schema.Update(_Handle, 0xAE42345F9A4938C9);
  }
}