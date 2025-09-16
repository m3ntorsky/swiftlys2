using SwiftlyS2.Shared.SchemaDefinitions;

namespace SwiftlyS2.Shared.GameEvents;

public interface IGameEvent<T> where T : IGameEvent<T>
{
  internal static abstract T FromAllocated(nint ptr);

  internal static abstract T FromExternal(nint ptr);
  
  internal static abstract string GetName();

  public bool DontBroadcast { get; set; }

  public void Fire();

  public void FireToClient(int clientId);

  public void SetBool(string key, bool value);

  public bool GetBool(string key);

  public void SetInt(string key, int value);

  public int GetInt(string key);

  public void SetUint64(string key, ulong value);

  public void SetFloat(string key, float value);

  public void SetString(string key, string value);

  public string GetString(string key);

  public void SetEntity<K>(string key, K value) where K : CEntityInstance;

  public K GetEntity<K>(string key) where K : CEntityInstance;

  public void SetEntityIndex(string key, int value);

  public int GetEntityIndex(string key);

  public void SetPlayerSlot(string key, int value);

  public int GetPlayerSlot(string key);

  public CCSPlayerController GetPlayerController(string key);

  public CCSPlayerPawn GetPlayerPawn(string key);

  public void SetPtr(string key, nint value);

  public nint GetPtr(string key);

  public int GetPawnEntityIndex(string key);

  public bool IsReliable();

  public bool IsLocal();
  
  
}