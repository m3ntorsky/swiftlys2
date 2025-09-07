using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class InfoForResourceTypeIParticleSnapshot : SchemaClass, IInfoForResourceTypeIParticleSnapshot {

  public InfoForResourceTypeIParticleSnapshot(nint handle) : base(handle) {
  }

  public InfoForResourceTypeIParticleSnapshot(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}