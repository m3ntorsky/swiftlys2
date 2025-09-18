
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CEntityMessageRemoveAllDecals : ITypedProtobuf<CEntityMessageRemoveAllDecals>
{
  static CEntityMessageRemoveAllDecals ITypedProtobuf<CEntityMessageRemoveAllDecals>.Wrap(nint handle) => new CEntityMessageRemoveAllDecalsImpl(handle);


  public bool RemoveDecals { get; set; }


  public CEntityMsg EntityMsg { get; }

}
