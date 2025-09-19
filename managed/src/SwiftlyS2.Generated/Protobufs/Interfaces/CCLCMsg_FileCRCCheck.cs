
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCLCMsg_FileCRCCheck : ITypedProtobuf<CCLCMsg_FileCRCCheck>, INetMessage<CCLCMsg_FileCRCCheck>, IDisposable
{
  static int INetMessage<CCLCMsg_FileCRCCheck>.MessageId => 26;
  
  static string INetMessage<CCLCMsg_FileCRCCheck>.MessageName => "CCLCMsg_FileCRCCheck";

  static CCLCMsg_FileCRCCheck ITypedProtobuf<CCLCMsg_FileCRCCheck>.Wrap(nint handle, bool isManuallyAllocated) => new CCLCMsg_FileCRCCheckImpl(handle, isManuallyAllocated);


  public int CodePath { get; set; }


  public string Path { get; set; }


  public int CodeFilename { get; set; }


  public string Filename { get; set; }


  public uint Crc { get; set; }

}
