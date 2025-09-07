using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSObserver_CameraServices : CCSPlayerBase_CameraServices, ICSObserver_CameraServices {

  public CCSObserver_CameraServices(nint handle) : base(handle) {
  }

  public CCSObserver_CameraServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}