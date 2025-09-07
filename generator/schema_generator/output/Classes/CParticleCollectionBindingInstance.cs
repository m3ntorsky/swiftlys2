using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleCollectionBindingInstance : CBasePulseGraphInstance, IParticleCollectionBindingInstance {

  public CParticleCollectionBindingInstance(nint handle) : base(handle) {
  }

  public CParticleCollectionBindingInstance(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}