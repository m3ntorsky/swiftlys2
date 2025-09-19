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
public struct CRecipientFilter
{
    public nint pVTable;
    public NetChannelBufType_t BufferType;
    public bool InitMessage;
    public CBitVec64 RecipientFilters;

    public CRecipientFilter(NetChannelBufType_t BufType = NetChannelBufType_t.BUF_RELIABLE, bool bInitMessage = false)
    {
        pVTable = CRecipientFilterVtable.pCRecipientFilterVTable;
        RecipientFilters = new();
        InitMessage = bInitMessage;
        BufferType = BufType;
    }

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

internal static class CRecipientFilterVtable {

    public static nint pCRecipientFilterVTable;

    [UnmanagedCallersOnly]
    public unsafe static void Destructor(CRecipientFilter* filter) {
        // do nothing
    }

    [UnmanagedCallersOnly]
    public unsafe static NetChannelBufType_t GetNetworkBufType(CRecipientFilter* filter) {
        return filter->BufferType;
    }

    [UnmanagedCallersOnly]
    public unsafe static bool IsInitMessage(CRecipientFilter* filter) {
        return filter->InitMessage;
    }

    [UnmanagedCallersOnly]
    public unsafe static CBitVec64* GetRecipients(CRecipientFilter* filter) {
        return &filter->RecipientFilters;
    }

    static unsafe CRecipientFilterVtable() {
        pCRecipientFilterVTable = Marshal.AllocHGlobal(sizeof(nint) * 4);
        Span<nint> vtable = new((void*)pCRecipientFilterVTable, 4);
        vtable[0] = (nint)(delegate* unmanaged<CRecipientFilter*, void>)(&Destructor);
        vtable[1] = (nint)(delegate* unmanaged<CRecipientFilter*, NetChannelBufType_t>)(&GetNetworkBufType);
        vtable[2] = (nint)(delegate* unmanaged<CRecipientFilter*, bool>)(&IsInitMessage);
        vtable[3] = (nint)(delegate* unmanaged<CRecipientFilter*, CBitVec64*>)(&GetRecipients);
    }
}