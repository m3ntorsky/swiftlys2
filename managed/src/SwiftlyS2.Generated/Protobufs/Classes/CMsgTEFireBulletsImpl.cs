
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgTEFireBulletsImpl : NetMessage<CMsgTEFireBullets>, CMsgTEFireBullets
{
  public CMsgTEFireBulletsImpl(nint handle): base(handle)
  {
  }


  public Vector Origin
  { get => Accessor.GetVector("origin"); set => Accessor.SetVector("origin", value); }


  public QAngle Angles
  { get => Accessor.GetQAngle("angles"); set => Accessor.SetQAngle("angles", value); }


  public uint WeaponId
  { get => Accessor.GetUInt32("weapon_id"); set => Accessor.SetUInt32("weapon_id", value); }


  public uint Mode
  { get => Accessor.GetUInt32("mode"); set => Accessor.SetUInt32("mode", value); }


  public uint Seed
  { get => Accessor.GetUInt32("seed"); set => Accessor.SetUInt32("seed", value); }


  public int Player
  { get => Accessor.GetInt32("player"); set => Accessor.SetInt32("player", value); }


  public float Inaccuracy
  { get => Accessor.GetFloat("inaccuracy"); set => Accessor.SetFloat("inaccuracy", value); }


  public float RecoilIndex
  { get => Accessor.GetFloat("recoil_index"); set => Accessor.SetFloat("recoil_index", value); }


  public float Spread
  { get => Accessor.GetFloat("spread"); set => Accessor.SetFloat("spread", value); }


  public int SoundType
  { get => Accessor.GetInt32("sound_type"); set => Accessor.SetInt32("sound_type", value); }


  public uint ItemDefIndex
  { get => Accessor.GetUInt32("item_def_index"); set => Accessor.SetUInt32("item_def_index", value); }


  public int SoundDspEffect
  { get => Accessor.GetInt32("sound_dsp_effect"); set => Accessor.SetInt32("sound_dsp_effect", value); }


  public Vector EntOrigin
  { get => Accessor.GetVector("ent_origin"); set => Accessor.SetVector("ent_origin", value); }


  public uint NumBulletsRemaining
  { get => Accessor.GetUInt32("num_bullets_remaining"); set => Accessor.SetUInt32("num_bullets_remaining", value); }


  public uint AttackType
  { get => Accessor.GetUInt32("attack_type"); set => Accessor.SetUInt32("attack_type", value); }

}
