
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEPhysicsProp : ITypedProtobuf<CMsgTEPhysicsProp>, INetMessage<CMsgTEPhysicsProp>
{
  static int INetMessage<CMsgTEPhysicsProp>.MessageId => 423;
  
  static string INetMessage<CMsgTEPhysicsProp>.MessageName => "CMsgTEPhysicsProp";

  static CMsgTEPhysicsProp ITypedProtobuf<CMsgTEPhysicsProp>.Wrap(nint handle) => new CMsgTEPhysicsPropImpl(handle);


  public Vector Origin { get; set; }


  public Vector Velocity { get; set; }


  public QAngle Angles { get; set; }


  public int Skin { get; set; }


  public uint Flags { get; set; }


  public uint Effects { get; set; }


  public int Color { get; set; }


  public ulong Modelindex { get; set; }


  public uint UnusedBreakmodelsnottomake { get; set; }


  public float Scale { get; set; }


  public Vector Dmgpos { get; set; }


  public Vector Dmgdir { get; set; }


  public int Dmgtype { get; set; }

}
