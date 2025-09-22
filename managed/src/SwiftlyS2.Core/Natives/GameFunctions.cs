using System.Runtime.InteropServices;
using Spectre.Console;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class GameFunctions {

  public static unsafe delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, int> pCTakeDamageInfo_Constructor;

  public static void Initialize() {
    unsafe {
      pCTakeDamageInfo_Constructor = (delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, int>)NativeSignatures.Fetch("CTakeDamageInfo::Constructor");
    }
  }

  public unsafe static nint CTakeDamageInfoConstructor(
    CTakeDamageInfo* pThis,
    nint pInflictor,
    nint pAttacker,
    nint pAbility,
    Vector* vecDamageForce,
    Vector* vecDamagePosition,
    float flDamage,
    int bitsDamageType,
    int iCustomDamage,
    void* a10
  )
  {
    try {
      unsafe {
        return pCTakeDamageInfo_Constructor(pThis, pInflictor, pAttacker, pAbility, vecDamageForce, vecDamagePosition, flDamage, bitsDamageType, iCustomDamage, a10);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
      return 0;
    }
  }
}