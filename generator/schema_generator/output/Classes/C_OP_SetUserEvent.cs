using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetUserEvent : CParticleFunctionOperator, IC_OP_SetUserEvent {

  public C_OP_SetUserEvent(nint handle) : base(handle) {
  }

  public C_OP_SetUserEvent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPerParticleFloatInput Input {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9A6F6FB81D4B7FFD));
  }
  public IPerParticleFloatInput RisingEdge {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9A6F6FB8DCFBDCF4));
  }
  public ref EventTypeSelection_t RisingEventType {
    get => ref _Handle.AsRef<EventTypeSelection_t>(Schema.GetOffset(0x9A6F6FB83790928D));
  }
  public IPerParticleFloatInput FallingEdge {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x9A6F6FB8CBE5115B));
  }
  public ref EventTypeSelection_t FallingEventType {
    get => ref _Handle.AsRef<EventTypeSelection_t>(Schema.GetOffset(0x9A6F6FB8C79ED114));
  }


}