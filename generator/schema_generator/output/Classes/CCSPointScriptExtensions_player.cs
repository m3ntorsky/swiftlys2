using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPointScriptExtensions_player : SchemaClass, ICSPointScriptExtensions_player {

  public CCSPointScriptExtensions_player(nint handle) : base(handle) {
  }

  public CCSPointScriptExtensions_player(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}