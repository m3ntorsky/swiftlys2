using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int CTakeDamageInfo_Constructor(CTakeDamageInfo* pThis, nint pInflictor, nint pAttacker, nint pAbility, Vector* vecDamageForce, Vector* vecDamagePosition, float flDamage, int bitsDamageType, int iCustomDamage, void* a10);

[StructLayout(LayoutKind.Sequential)]
public struct AttackerInfo_t
{
    public bool NeedInit;
    public bool IsPawn;
    public bool IsWorld;
    public CHandle<CCSPlayerPawn> AttackerPawn;
    public int AttackerPlayerSlot;
    public int TeamChecked;
    public int Team;
};

[StructLayout(LayoutKind.Sequential)]
public unsafe struct CTakeDamageInfo
{
    public nint _pVTable;

    public Vector DamageForce;
    public Vector DamagePosition;
    public Vector ReportedPosition;
    public Vector DamageDirection;
    public CHandle<CEntityInstance> Inflictor;
    public CHandle<CEntityInstance> Attacker;
    public CHandle<CEntityInstance> Ability;
    public float Damage;
    public float TotalledDamage;
    public DamageTypes_t DamageType;
    public uint DamageCustom;
    public sbyte AmmoType;

    private fixed byte _padding1[0xb];

    public float OriginalDamage;
    public bool ShouldBleed;
    public bool ShouldSpark;

    private short _padding2;

    public CGameTrace* Trace;
    public TakeDamageFlags_t DamageFlags;
    public CString DamageSourceName;
    public HitGroup_t HitGroupId;
    public int NumObjectsPenetrated;
    public float FriendlyFireDamageReductionRatio;

    private fixed byte _padding3[0x5C];

    public void* ScriptInstance;
    public AttackerInfo_t AttackerInfo;
    public bool InTakeDamageFlow;

    private int Unknown;

    public CTakeDamageInfo()
    {
        var constructor = Marshal.GetDelegateForFunctionPointer<CTakeDamageInfo_Constructor>(NativeSignatures.Fetch("CTakeDamageInfo::Constructor"));
        Vector vec3_origin = new(0,0,0);

        fixed(CTakeDamageInfo* info = &this)
        {
            constructor(info, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, &vec3_origin, &vec3_origin, 0.0f, 0, 0, null);
        }
    }

    public CTakeDamageInfo(CBaseEntity inflictor, CBaseEntity attacker, CBaseEntity ability, float flDamage, DamageTypes_t bitsDamageType)
    {
        var constructor = Marshal.GetDelegateForFunctionPointer<CTakeDamageInfo_Constructor>(NativeSignatures.Fetch("CTakeDamageInfo::Constructor"));
        Vector vec3_origin = new(0, 0, 0);

        fixed (CTakeDamageInfo* info = &this)
        {
            constructor(info, inflictor.GetHandle(), attacker.GetHandle(), ability.GetHandle(), &vec3_origin, &vec3_origin, flDamage, (int)bitsDamageType, 0, null);
        }
    }

    public HitGroup_t ActualHitGroup => Trace->HitBox->m_nGroupId;
}