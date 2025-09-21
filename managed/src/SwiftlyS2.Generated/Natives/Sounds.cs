#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeSounds {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<nint> _CreateSoundEvent;
  public unsafe static nint CreateSoundEvent() {
    try {
    var ret = _CreateSoundEvent();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _DestroySoundEvent;
  public unsafe static void DestroySoundEvent(nint soundEvent) {
    try {
    _DestroySoundEvent(soundEvent);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, uint> _Emit;
  public unsafe static uint Emit(nint soundEvent) {
    if (Thread.CurrentThread.ManagedThreadId != _MainThreadID) {
      throw new InvalidOperationException("This method can only be called from the main thread.");
    }
    try {
    var ret = _Emit(soundEvent);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, void> _SetName;
  public unsafe static void SetName(nint soundEvent, string name) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var nameLength = Encoding.UTF8.GetByteCount(name);
    var nameBuffer = pool.Rent(nameLength + 1);
    Encoding.UTF8.GetBytes(name, nameBuffer);
    nameBuffer[nameLength] = 0;
    fixed (byte* nameBufferPtr = nameBuffer) {
        _SetName(soundEvent, nameBufferPtr);
    pool.Return(nameBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<byte*, nint, int> _GetName;
  public unsafe static string GetName(nint soundEvent) {
    try {
    var ret = _GetName(null, soundEvent);
    var pool = ArrayPool<byte>.Shared;
    var retBuffer = pool.Rent(ret+1);
    fixed (byte* retBufferPtr = retBuffer) {
        ret = _GetName(retBufferPtr, soundEvent);
    var retString = Encoding.UTF8.GetString(retBufferPtr, ret);
    pool.Return(retBuffer);

    return retString;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, int, void> _SetSourceEntityIndex;
  public unsafe static void SetSourceEntityIndex(nint soundEvent, int index) {
    try {
    _SetSourceEntityIndex(soundEvent, index);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, int> _GetSourceEntityIndex;
  public unsafe static int GetSourceEntityIndex(nint soundEvent) {
    try {
    var ret = _GetSourceEntityIndex(soundEvent);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, int, void> _AddClient;
  public unsafe static void AddClient(nint soundEvent, int playerid) {
    try {
    _AddClient(soundEvent, playerid);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, int, void> _RemoveClient;
  public unsafe static void RemoveClient(nint soundEvent, int playerid) {
    try {
    _RemoveClient(soundEvent, playerid);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _ClearClients;
  public unsafe static void ClearClients(nint soundEvent) {
    try {
    _ClearClients(soundEvent);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _AddAllClients;
  public unsafe static void AddAllClients(nint soundEvent) {
    try {
    _AddAllClients(soundEvent);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, bool> _HasField;
  public unsafe static bool HasField(nint soundEvent, string fieldName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        var ret = _HasField(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, bool, void> _SetBool;
  public unsafe static void SetBool(nint soundEvent, string fieldName, bool value) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        _SetBool(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, bool> _GetBool;
  public unsafe static bool GetBool(nint soundEvent, string fieldName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        var ret = _GetBool(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, int, void> _SetInt32;
  public unsafe static void SetInt32(nint soundEvent, string fieldName, int value) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        _SetInt32(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, int> _GetInt32;
  public unsafe static int GetInt32(nint soundEvent, string fieldName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        var ret = _GetInt32(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, uint, void> _SetUInt32;
  public unsafe static void SetUInt32(nint soundEvent, string fieldName, uint value) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        _SetUInt32(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, uint> _GetUInt32;
  public unsafe static uint GetUInt32(nint soundEvent, string fieldName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        var ret = _GetUInt32(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, ulong, void> _SetUInt64;
  public unsafe static void SetUInt64(nint soundEvent, string fieldName, ulong value) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        _SetUInt64(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, ulong> _GetUInt64;
  public unsafe static ulong GetUInt64(nint soundEvent, string fieldName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        var ret = _GetUInt64(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, float, void> _SetFloat;
  public unsafe static void SetFloat(nint soundEvent, string fieldName, float value) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        _SetFloat(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, float> _GetFloat;
  public unsafe static float GetFloat(nint soundEvent, string fieldName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        var ret = _GetFloat(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, Vector, void> _SetFloat3;
  public unsafe static void SetFloat3(nint soundEvent, string fieldName, Vector value) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        _SetFloat3(soundEvent, fieldNameBufferPtr, value);
    pool.Return(fieldNameBuffer);

  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, byte*, Vector> _GetFloat3;
  public unsafe static Vector GetFloat3(nint soundEvent, string fieldName) {
    try {
    var pool = ArrayPool<byte>.Shared;
    var fieldNameLength = Encoding.UTF8.GetByteCount(fieldName);
    var fieldNameBuffer = pool.Rent(fieldNameLength + 1);
    Encoding.UTF8.GetBytes(fieldName, fieldNameBuffer);
    fieldNameBuffer[fieldNameLength] = 0;
    fixed (byte* fieldNameBufferPtr = fieldNameBuffer) {
        var ret = _GetFloat3(soundEvent, fieldNameBufferPtr);
    pool.Return(fieldNameBuffer);

    return ret;
  }
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, ulong> _GetClients;
  /// <summary>
  /// returns player mask
  /// </summary>
  public unsafe static ulong GetClients(nint soundEvent) {
    try {
    var ret = _GetClients(soundEvent);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, ulong, void> _SetClients;
  public unsafe static void SetClients(nint soundEvent, ulong playermask) {
    try {
    _SetClients(soundEvent, playermask);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
