
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CNETMsg_SpawnGroup_SetCreationTick : ITypedProtobuf<CNETMsg_SpawnGroup_SetCreationTick>, INetMessage<CNETMsg_SpawnGroup_SetCreationTick>
{
  static int INetMessage<CNETMsg_SpawnGroup_SetCreationTick>.MessageId => 11;
  
  static string INetMessage<CNETMsg_SpawnGroup_SetCreationTick>.MessageName => "CNETMsg_SpawnGroup_SetCreationTick";

  static CNETMsg_SpawnGroup_SetCreationTick ITypedProtobuf<CNETMsg_SpawnGroup_SetCreationTick>.Wrap(nint handle) => new CNETMsg_SpawnGroup_SetCreationTickImpl(handle);


  public uint Spawngrouphandle { get; set; }


  public int Tickcount { get; set; }


  public uint Creationsequence { get; set; }

}
