using Spectre.Console;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class GameFunctions {

  public static unsafe delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, void> pCTakeDamageInfo_Constructor;
  public static unsafe delegate* unmanaged<nint, Ray_t, Vector, Vector, CTraceFilter*, CGameTrace*, void> pTraceShape;
  public static unsafe delegate* unmanaged<Vector, Vector, BBox_t, CTraceFilter*, CGameTrace*, void> pTracePlayerBBox;

  public static void Initialize() {
    unsafe {
      pCTakeDamageInfo_Constructor = (delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, void>)NativeSignatures.Fetch("CTakeDamageInfo::Constructor");
      pTraceShape = (delegate* unmanaged<nint, Ray_t, Vector, Vector, CTraceFilter*, CGameTrace*, void>)NativeSignatures.Fetch("TraceShape");
      pTracePlayerBBox = (delegate* unmanaged<Vector, Vector, BBox_t, CTraceFilter*, CGameTrace*, void>)NativeSignatures.Fetch("TracePlayerBBox");
    }
  }

  public unsafe static void TracePlayerBBox(
    Vector vecStart,
    Vector vecEnd,
    BBox_t bounds,
    CTraceFilter* pFilter,
    CGameTrace* pTrace
  )
  {
    try {
      unsafe {
        pTracePlayerBBox(vecStart, vecEnd, bounds, pFilter, pTrace);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void TraceShape(
    nint pEngineTrace,
    Ray_t ray,
    Vector vecStart,
    Vector vecEnd,
    CTraceFilter* pFilter,
    CGameTrace* pTrace
  )
  {
    try {
      unsafe {
        pTraceShape(pEngineTrace, ray, vecStart, vecEnd, pFilter, pTrace);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void CTakeDamageInfoConstructor(
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
        pCTakeDamageInfo_Constructor(pThis, pInflictor, pAttacker, pAbility, vecDamageForce, vecDamagePosition, flDamage, bitsDamageType, iCustomDamage, a10);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }
}