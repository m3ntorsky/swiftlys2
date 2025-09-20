using SwiftlyS2.Shared.Misc;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

public enum CollisionGroup: byte
{
    /// <summary>
    /// Default layer, always collides with everything.
    /// </summary>
    Always = 0,
    /// <summary>
    /// This is how you turn off all collisions for an object - move it to this group
    /// </summary>
    Nonphysical,
    /// <summary>
    /// Trigger layer, never collides with anything, only triggers/interacts.  Use when querying for interaction layers.
    /// </summary>
    Trigger,
    /// <summary>
    /// Conditionally solid means that the collision response will be zero or as defined in the table when there are matching interactions
    /// </summary>
    ConditionallySolid,
    /// <summary>
    /// First unreserved collision layer index.
    /// </summary>
    FirstUser,
    Default = FirstUser,
    /// <summary>
    /// Collides with nothing but world, static stuff and triggers
    /// </summary>
    Debris,
    /// <summary>
    /// Collides with everything except other interactive debris or debris
    /// </summary>
    InteractiveDebris,
    /// <summary>
    /// Collides with everything except interactive debris or debris
    /// </summary>
    Interactive,
    Player,
    BreakableGlass,
    Vehicle,
    /// <summary>
    /// For HL2, same as Collision_Group_Player, for TF2, this filters out other players and CBaseObjects
    /// </summary>
    PlayerMovement,
    /// <summary>
    /// Generic NPC group
    /// </summary>
    NPC,
    /// <summary>
    /// for any entity inside a vehicle
    /// </summary>
    InVehicle,
    /// <summary>
    /// for any weapons that need collision detection
    /// </summary>
    Weapon,
    /// <summary>
    /// vehicle clip brush to restrict vehicle movement
    /// </summary>
    VehicleClip,
    /// <summary>
    /// Projectiles!
    /// </summary>
    Projectile,
    /// <summary>
    /// Blocks entities not permitted to get near moving doors
    /// </summary>
    DoorBlocker,
    /// <summary>
    /// Doors that the player shouldn't collide with
    /// </summary>
    PassableDoor,
    /// <summary>
    /// Things that are dissolving are in this group
    /// </summary>
    Dissolving,
    /// <summary>
    /// Nonsolid on client and server, pushaway in player code
    /// </summary>
    Pushaway,
    /// <summary>
    /// Used so NPCs in scripts ignore the player.
    /// </summary>
    NPCActor,
    /// <summary>
    /// Used for NPCs in scripts that should not collide with each other
    /// </summary>
    NPCScripted,
    PZClip,
    Props,
    LastSharedCollisionGroup,
    MaxAllowed = 64
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct RnQueryShapeAttr_t
{
    public ulong InteractsWith;
    public ulong InteractsExclude;
    public ulong InteractsAs;
    public fixed uint EntityIdsToIgnore[2];
    public fixed uint OwnerIdsToIgnore[2];
    public fixed ushort HierarchyIds[2];
    public byte ObjectSetMask;
    public CollisionGroup CollisionGroup;

    private byte data;

    public bool HitSolid
    {
        get => BitFieldHelper.GetBit(ref data, 0);
        set => BitFieldHelper.SetBit(ref data, 0, value);
    }

    public bool HitSolidRequiresGenerateContacts
    {
        get => BitFieldHelper.GetBit(ref data, 1);
        set => BitFieldHelper.SetBit(ref data, 1, value);
    }

    public bool HitTrigger
    {
        get => BitFieldHelper.GetBit(ref data, 2);
        set => BitFieldHelper.SetBit(ref data, 2, value);
    }

    public bool ShouldIgnoreDisabledPairs
    {
        get => BitFieldHelper.GetBit(ref data, 3);
        set => BitFieldHelper.SetBit(ref data, 3, value);
    }

    public bool IgnoreIfBothInteractWithHitboxes
    {
        get => BitFieldHelper.GetBit(ref data, 4);
        set => BitFieldHelper.SetBit(ref data, 4, value);
    }

    public bool ForceHitEverything
    {
        get => BitFieldHelper.GetBit(ref data, 5);
        set => BitFieldHelper.SetBit(ref data, 5, value);
    }

    public bool Unknown
    {
        get => BitFieldHelper.GetBit(ref data, 6);
        set => BitFieldHelper.SetBit(ref data, 6, value);
    }
}