
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgTEBeamEntsImpl : NetMessage<CMsgTEBeamEnts>, CMsgTEBeamEnts
{
  public CMsgTEBeamEntsImpl(nint handle): base(handle)
  {
  }


  public CMsgTEBaseBeam Base
  { get => new CMsgTEBaseBeamImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "base")); }


  public uint Startentity
  { get => Accessor.GetUInt32("startentity"); set => Accessor.SetUInt32("startentity", value); }


  public uint Endentity
  { get => Accessor.GetUInt32("endentity"); set => Accessor.SetUInt32("endentity", value); }

}
