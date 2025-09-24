using Spectre.Console;
using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal static class GameFunctions {

  public static unsafe delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, void> pCTakeDamageInfo_Constructor;
  public static unsafe delegate* unmanaged<nint, Ray_t, Vector, Vector, CTraceFilter*, CGameTrace*, void> pTraceShape;
  public static unsafe delegate* unmanaged<Vector, Vector, BBox_t, CTraceFilter*, CGameTrace*, void> pTracePlayerBBox;
  public static unsafe delegate* unmanaged<nint, Vector*, QAngle*, Vector*, void> pTeleport;
  public static unsafe delegate* unmanaged<nint, IntPtr, void> pSetModel;
  public static unsafe delegate* unmanaged<nint, nint, bool, bool, bool, bool, void> pSetPlayerControllerPawn;
  public static unsafe delegate* unmanaged<nint, bool, bool, void> pCommitSuicide;
  public static unsafe delegate* unmanaged<nint, nint> pSkeletonInstance;
  public static unsafe delegate* unmanaged<nint, nint, nint, nint> pFindPickerEntity;

  public static int TeleportOffset => NativeOffsets.Fetch("CBaseEntity::Teleport");
  public static int CommitSuicideOffset => NativeOffsets.Fetch("CBasePlayerPawn::CommitSuicide");
  public static int GetSkeletonInstanceOffset => NativeOffsets.Fetch("CGameSceneNode::GetSkeletonInstance");
  public static int FindPickerEntityOffset => NativeOffsets.Fetch("CGameRules::FindPickerEntity");

  public static void Initialize() {
    unsafe {
      pCTakeDamageInfo_Constructor = (delegate* unmanaged<CTakeDamageInfo*, nint, nint, nint, Vector*, Vector*, float, int, int, void*, void>)NativeSignatures.Fetch("CTakeDamageInfo::Constructor");
      pTraceShape = (delegate* unmanaged<nint, Ray_t, Vector, Vector, CTraceFilter*, CGameTrace*, void>)NativeSignatures.Fetch("TraceShape");
      pTracePlayerBBox = (delegate* unmanaged<Vector, Vector, BBox_t, CTraceFilter*, CGameTrace*, void>)NativeSignatures.Fetch("TracePlayerBBox");
      pSetModel = (delegate* unmanaged<nint, IntPtr, void>)NativeSignatures.Fetch("CBaseModelEntity::SetModel");
      pSetPlayerControllerPawn = (delegate* unmanaged<nint, nint, bool, bool, bool, bool, void>)NativeSignatures.Fetch("CBasePlayerController::SetPawn");
    }
  }

  public unsafe static nint FindPickerEntity(nint handle, nint controller)
  {
    try
    {
      unsafe
      {
        if (pFindPickerEntity == null)
        {
          void*** ppVTable = (void***)handle;
          pFindPickerEntity = (delegate* unmanaged<nint, nint, nint, nint>)ppVTable[0][FindPickerEntityOffset];
        }

        return pFindPickerEntity(handle, controller, IntPtr.Zero);
      }
    }
    catch (Exception e)
    {
      AnsiConsole.WriteException(e);
    }
    return 0;
  }

  public unsafe static nint GetSkeletonInstance(nint handle)
  {
    try
    {
      unsafe
      {
        if (pSkeletonInstance == null)
        {
          void*** ppVTable = (void***)handle;
          pSkeletonInstance = (delegate* unmanaged<nint, nint>)ppVTable[0][GetSkeletonInstanceOffset];
        }

        return pSkeletonInstance(handle);
      }
    }
    catch (Exception e)
    {
      AnsiConsole.WriteException(e);
    }
    return 0;
  }

  public unsafe static void PawnCommitSuicide(nint pPawn, bool bExplode, bool bForce)
  {
    try
    {
      unsafe
      {
        if (pCommitSuicide == null)
        {
          void*** ppVTable = (void***)pPawn;
          pCommitSuicide = (delegate* unmanaged<nint, bool, bool, void>)ppVTable[0][CommitSuicideOffset];
        }

        pCommitSuicide(pPawn, bExplode, bForce);
      }
    } catch (Exception e)
    {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void SetPlayerControllerPawn(nint pController, nint pPawn, bool b1, bool b2, bool b3, bool b4)
  {
    try {
      unsafe {
        pSetPlayerControllerPawn(pController, pPawn, b1, b2, b3, b4);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
  }

  public unsafe static void SetModel(nint pEntity, string model)
  {
    try {
      unsafe {
        fixed (char* pModel = model)
        {
          IntPtr ptrModel = (IntPtr)pModel;
          pSetModel(pEntity, ptrModel);
        }
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
    }
    }

    public unsafe static void Teleport(
    nint pEntity,
    Vector* vecPosition,
    QAngle* vecAngle,
    Vector* vecVelocity
  )
  {
    try {
      unsafe {
        if(pTeleport == null)
        {
          void*** ppVTable = (void***)pEntity;
          pTeleport = (delegate* unmanaged<nint, Vector*, QAngle*, Vector*, void>)ppVTable[0][TeleportOffset];
        }
        pTeleport(pEntity, vecPosition, vecAngle, vecVelocity);
      }
    } catch (Exception e) {
      AnsiConsole.WriteException(e);
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