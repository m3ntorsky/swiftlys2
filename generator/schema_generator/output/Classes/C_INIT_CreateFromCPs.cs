using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_CreateFromCPs : CParticleFunctionInitializer, IC_INIT_CreateFromCPs {

  public C_INIT_CreateFromCPs(nint handle) : base(handle) {
  }

  public C_INIT_CreateFromCPs(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Increment {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2593FF962359F182));
  }
  public ref int MinCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2593FF9663AFBE98));
  }
  public ref int MaxCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2593FF964C307D96));
  }
  public IParticleCollectionFloatInput DynamicCPCount {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x2593FF96DF30CE38));
  }


}