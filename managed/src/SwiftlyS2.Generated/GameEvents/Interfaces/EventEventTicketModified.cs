using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Core.GameEventDefinitions;

namespace SwiftlyS2.Shared.GameEventDefinitions;

/// <summary> 
/// Event "event_ticket_modified"
/// </summary>
public interface EventEventTicketModified : ITypedGameEvent<EventEventTicketModified> {

  static EventEventTicketModified ITypedGameEvent<EventEventTicketModified>.Create() => new EventEventTicketModifiedImpl();

  static string ITypedGameEvent<EventEventTicketModified>.GetName() => "event_ticket_modified";

  static uint ITypedGameEvent<EventEventTicketModified>.GetHash() => 0xAD893DFEu;
}
