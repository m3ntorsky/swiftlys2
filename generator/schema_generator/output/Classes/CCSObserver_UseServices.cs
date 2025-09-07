using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSObserver_UseServices : CPlayer_UseServices, ICSObserver_UseServices {

  public CCSObserver_UseServices(nint handle) : base(handle) {
  }

  public CCSObserver_UseServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}