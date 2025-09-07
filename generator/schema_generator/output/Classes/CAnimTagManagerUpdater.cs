using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimTagManagerUpdater : SchemaClass, IAnimTagManagerUpdater {

  public CAnimTagManagerUpdater(nint handle) : base(handle) {
  }

  public CAnimTagManagerUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSmartPtr< CAnimTagBase > > Tags {
    get => ref _Handle.AsRef<CUtlVector< CSmartPtr< CAnimTagBase > >>(Schema.GetOffset(0xF09D3FB1B46C8540));
  }


}