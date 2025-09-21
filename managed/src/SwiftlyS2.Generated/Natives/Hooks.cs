#pragma warning disable CS0649
#pragma warning disable CS0169

using System.Buffers;
using System.Text;
using System.Threading;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class NativeHooks {
  private static int _MainThreadID;
  private unsafe static delegate* unmanaged<nint> _AllocateHook;
  public unsafe static nint AllocateHook() {
    try {
    var ret = _AllocateHook();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint> _AllocateVHook;
  public unsafe static nint AllocateVHook() {
    try {
    var ret = _AllocateVHook();
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _DeallocateHook;
  public unsafe static void DeallocateHook(nint hook) {
    try {
    _DeallocateHook(hook);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _DeallocateVHook;
  public unsafe static void DeallocateVHook(nint hook) {
    try {
    _DeallocateVHook(hook);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, nint, nint, void> _SetHook;
  /// <summary>
  /// the callback should receive the exact arguments as the function has, and to return the same amount of arguments
  /// </summary>
  public unsafe static void SetHook(nint hook, nint func, nint callback) {
    try {
    _SetHook(hook, func, callback);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, nint, int, nint, bool, void> _SetVHook;
  /// <summary>
  /// the callback should receive the exact arguments as the function has, and to return the same amount of arguments, plus the first argument needs to be the pointer to the original function
  /// </summary>
  public unsafe static void SetVHook(nint hook, nint entityOrVTable, int index, nint callback, bool isVtable) {
    try {
    _SetVHook(hook, entityOrVTable, index, callback, isVtable);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _EnableHook;
  public unsafe static void EnableHook(nint hook) {
    try {
    _EnableHook(hook);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _EnableVHook;
  public unsafe static void EnableVHook(nint hook) {
    try {
    _EnableVHook(hook);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _DisableHook;
  public unsafe static void DisableHook(nint hook) {
    try {
    _DisableHook(hook);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, void> _DisableVHook;
  public unsafe static void DisableVHook(nint hook) {
    try {
    _DisableVHook(hook);
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, bool> _IsHookEnabled;
  public unsafe static bool IsHookEnabled(nint hook) {
    try {
    var ret = _IsHookEnabled(hook);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, bool> _IsVHookEnabled;
  public unsafe static bool IsVHookEnabled(nint hook) {
    try {
    var ret = _IsVHookEnabled(hook);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, nint> _GetHookOriginal;
  public unsafe static nint GetHookOriginal(nint hook) {
    try {
    var ret = _GetHookOriginal(hook);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
  private unsafe static delegate* unmanaged<nint, nint> _GetVHookOriginal;
  public unsafe static nint GetVHookOriginal(nint hook) {
    try {
    var ret = _GetVHookOriginal(hook);
    return ret;
     } catch (Exception e) {
      Spectre.Console.AnsiConsole.WriteException(e);
      throw;
    }
  }
}
