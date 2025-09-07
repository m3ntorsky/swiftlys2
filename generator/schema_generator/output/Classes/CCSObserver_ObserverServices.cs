using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSObserver_ObserverServices : CPlayer_ObserverServices, ICSObserver_ObserverServices {

  public CCSObserver_ObserverServices(nint handle) : base(handle) {
  }

  public CCSObserver_ObserverServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}