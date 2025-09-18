using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

public enum NetChannelBufType_t: sbyte
{
    BUF_DEFAULT = -1,
    BUF_UNRELIABLE = 0,
    BUF_RELIABLE,
    BUF_VOICE,
};

[StructLayout(LayoutKind.Sequential)]
public class CRecipientFilter
{
    public NetChannelBufType_t BufferType;
    public bool InitMessage;
    public CBitVec RecipientFilters;

    public CRecipientFilter(NetChannelBufType_t BufType = NetChannelBufType_t.BUF_RELIABLE, bool bInitMessage = false)
    {
        RecipientFilters = new(64);
        InitMessage = bInitMessage;
        BufferType = BufType;
    }

    public virtual void NopDestructor() { }

    public virtual NetChannelBufType_t GetNetworkBufferType() => BufferType;
    public virtual bool IsInitMessage() => InitMessage;
    public virtual ref CBitVec GetRecipients() => ref RecipientFilters;

    public void AddAllPlayers()
    {
        // @todo: When playermanager will be implemeneted, iterate through all the 64 players and if they're online and are authorized, add them here
    }

    public void RemoveAllPlayers()
    {
        RecipientFilters.ClearAll();
    }

    public void AddRecipient(int playerid)
    {
        if (playerid < 0 || playerid > 63) throw new IndexOutOfRangeException("PlayerID out of range (0-63).");

        RecipientFilters.Set(playerid);
    }

    public void RemoveRecipient(int playerid)
    {
        if (playerid < 0 || playerid > 63) throw new IndexOutOfRangeException("PlayerID out of range (0-63).");

        RecipientFilters.Clear(playerid);
    }

    public int GetRecipientCount()
    {
        return RecipientFilters.Count();
    }
}