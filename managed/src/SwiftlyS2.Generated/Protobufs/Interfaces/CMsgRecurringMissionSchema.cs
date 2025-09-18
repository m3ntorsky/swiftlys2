
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgRecurringMissionSchema : ITypedProtobuf<CMsgRecurringMissionSchema>
{
  static CMsgRecurringMissionSchema ITypedProtobuf<CMsgRecurringMissionSchema>.Wrap(nint handle) => new CMsgRecurringMissionSchemaImpl(handle);


  public IProtobufRepeatedFieldSubMessageType<CMsgRecurringMissionSchema_MissionTemplateList> Missions { get; }

}
