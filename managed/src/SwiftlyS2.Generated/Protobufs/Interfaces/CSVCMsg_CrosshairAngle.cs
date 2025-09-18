
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSVCMsg_CrosshairAngle : ITypedProtobuf<CSVCMsg_CrosshairAngle>
{
  static CSVCMsg_CrosshairAngle ITypedProtobuf<CSVCMsg_CrosshairAngle>.Wrap(nint handle) => new CSVCMsg_CrosshairAngleImpl(handle);


  public QAngle Angle { get; set; }

}
