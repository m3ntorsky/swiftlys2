using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseFuncs_GameParticleManager : SchemaClass, IPulseFuncs_GameParticleManager {

  public CPulseFuncs_GameParticleManager(nint handle) : base(handle) {
  }

  public CPulseFuncs_GameParticleManager(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}