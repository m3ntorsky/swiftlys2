
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCStrike15_v2_Server2GCClientValidate : ITypedProtobuf<CMsgGCCStrike15_v2_Server2GCClientValidate>
{
  static CMsgGCCStrike15_v2_Server2GCClientValidate ITypedProtobuf<CMsgGCCStrike15_v2_Server2GCClientValidate>.Wrap(nint handle) => new CMsgGCCStrike15_v2_Server2GCClientValidateImpl(handle);


  public uint Accountid { get; set; }

}
