using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.NetMessages;

public interface INetMessage<T> where T : INetMessage<T>, ITypedProtobuf<T>, IDisposable {

  public static abstract int MessageId { get; }
  public static abstract string MessageName { get; }

  /// <summary>
  /// Sends the net message to the specified players.
  /// </summary>
  /// <param name="filter">The recipient filter.</param>
  public void Send(CRecipientFilter filter);

  /// <summary>
  /// Sends the net message to all players.
  /// </summary>
  public void SendToAllPlayers();

  /// <summary>
  /// Sends the net message to the specified player.
  /// </summary>
  /// <param name="playerId">The player ID.</param>
  public void SendToPlayer(int playerId);

}