
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgUpdateItemSchema : ITypedProtobuf<CMsgUpdateItemSchema>
{
  static CMsgUpdateItemSchema ITypedProtobuf<CMsgUpdateItemSchema>.Wrap(nint handle) => new CMsgUpdateItemSchemaImpl(handle);


  public byte[] ItemsGame { get; set; }


  public int ItemSchemaVersion { get; set; }


  public string ItemsGameUrl { get; set; }

}
