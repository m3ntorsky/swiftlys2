
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageUpdateCssClasses : ITypedProtobuf<CUserMessageUpdateCssClasses>, INetMessage<CUserMessageUpdateCssClasses>
{
  static int INetMessage<CUserMessageUpdateCssClasses>.MessageId => 153;
  
  static string INetMessage<CUserMessageUpdateCssClasses>.MessageName => "CUserMessageUpdateCssClasses";

  static CUserMessageUpdateCssClasses ITypedProtobuf<CUserMessageUpdateCssClasses>.Wrap(nint handle) => new CUserMessageUpdateCssClassesImpl(handle);


  public int TargetWorldPanel { get; set; }


  public string CssClasses { get; set; }


  public bool IsAdd { get; set; }

}
