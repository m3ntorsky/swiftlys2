using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Services;

internal class PlayerManagerService : IPlayerManagerService
{
    public int PlayerCount => NativePlayerManager.GetPlayerCount();

    public int PlayerCap => NativePlayerManager.GetPlayerCap();

    public void ClearAllBlockedTransmitEntities()
    {
        NativePlayerManager.ClearAllBlockedTransmitEntity();
    }

    public bool IsPlayerOnline(int playerid)
    {
        return NativePlayerManager.IsPlayerOnline(playerid);
    }

    public void SendMessage(MessageType kind, string message)
    {
        NativePlayerManager.SendMessage((int)kind, message);
    }

    public void ShouldBlockTransmitEntity(int entityid, bool shouldBlockTransmit)
    {
        NativePlayerManager.ShouldBlockTransmitEntity(entityid, shouldBlockTransmit);
    }
}