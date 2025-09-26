using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Shared.Sounds;

public class SoundEvent : AllocableNativeHandle, IDisposable {


  /// <summary>
  /// The sound event name.
  /// </summary>
  public string Name 
  {
    get => NativeSounds.GetName(GetHandle());
    set => NativeSounds.SetName(GetHandle(), value);
  }

  /// <summary>
  /// The index of the entity that this sound event is emitted from.
  /// Setting to -1 (default) will emit the sound from the recipient location.
  /// </summary>
  public int SourceEntityIndex
  {
    get => NativeSounds.GetSourceEntityIndex(GetHandle());
    set => NativeSounds.SetSourceEntityIndex(GetHandle(), value);
  }

  /// <summary>
  /// The volume of the sound event.
  /// </summary>
  public float Volume
  {
    get => NativeSounds.GetFloat(GetHandle(), "public.volume");
    set => NativeSounds.SetFloat(GetHandle(), "public.volume", value);
  }

  /// <summary>
  /// The pitch of the sound event.
  /// </summary>
  public float Pitch
  {
    get => NativeSounds.GetFloat(GetHandle(), "public.pitch");
    set => NativeSounds.SetFloat(GetHandle(), "public.pitch", value);
  }

  /// <summary>
  /// The recipients of the sound event.
  /// </summary>
  public CRecipientFilter Recipients { get; set; } = new();

  public SoundEvent(): base(NativeSounds.CreateSoundEvent(), ownsHandle: true) {
    Volume = 1.0f;
    Pitch = 1.0f;
  }


  public SoundEvent(string name, float volume = 1.0f, float pitch = 1.0f) : base(NativeSounds.CreateSoundEvent(), ownsHandle: true)
  {
    Name = name;
    Volume = volume;
    Pitch = pitch;
  }

  public void SetSourceEntity(CEntityInstance entity)
  {
    SourceEntityIndex = (int)entity.Index;
  }

  public void SetBool(string fieldName, bool value)
  {
    NativeSounds.SetBool(GetHandle(), fieldName, value);
  }

  public bool GetBool(string fieldName)
  {
    return NativeSounds.GetBool(GetHandle(), fieldName);
  }

  public void SetInt32(string fieldName, int value)
  {
    NativeSounds.SetInt32(GetHandle(), fieldName, value);
  }

  public int GetInt32(string fieldName)
  {
    return NativeSounds.GetInt32(GetHandle(), fieldName);
  }

  public void SetUInt32(string fieldName, uint value)
  {
    NativeSounds.SetUInt32(GetHandle(), fieldName, value);
  }

  public uint GetUInt32(string fieldName)
  {
    return NativeSounds.GetUInt32(GetHandle(), fieldName);
  }

  public void SetFloat(string fieldName, float value)
  {
    NativeSounds.SetFloat(GetHandle(), fieldName, value);
  }

  public float GetFloat(string fieldName)
  {
    return NativeSounds.GetFloat(GetHandle(), fieldName);
  }

  public void SetFloat3(string fieldName, float x, float y, float z)
  {
    Vector vec = new(x, y, z);
    NativeSounds.SetFloat3(GetHandle(), fieldName, vec);
  }

  public void SetFloat3(string fieldName, Vector vec)
  {
    NativeSounds.SetFloat3(GetHandle(), fieldName, vec);
  }

  public Vector GetFloat3(string fieldName)
  {
    return NativeSounds.GetFloat3(GetHandle(), fieldName);
  }

  /// <summary>
  /// Emit the sound event.
  /// </summary>
  public void Emit()
  {
    NativeSounds.SetClients(GetHandle(), Recipients.ToMask());
    NativeSounds.Emit(GetHandle());
  }

  protected override bool Free() {
    NativeSounds.DestroySoundEvent(GetHandle());
    return true;
  }
}