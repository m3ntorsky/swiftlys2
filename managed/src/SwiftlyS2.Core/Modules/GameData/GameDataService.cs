using SwiftlyS2.Core.Natives;
using SwiftlyS2.Shared.Services;

namespace SwiftlyS2.Core.Services;

internal class GameDataService : IGameDataService {

  public bool HasSignature(string signatureName) {
    return NativeSignatures.Exists(signatureName);
  }

  public nint GetSignature(string signatureName) {
    return NativeSignatures.Fetch(signatureName);
  }

  public bool TryGetSignature(string signatureName, out nint signature) {
    signature = NativeSignatures.Fetch(signatureName);
    return signature != nint.Zero;
  }

  public bool HasOffset(string offsetName) {
    return NativeOffsets.Exists(offsetName);
  }

  public nint GetOffset(string offsetName) {
    return NativeOffsets.Fetch(offsetName);
  }

  public bool TryGetOffset(string offsetName, out nint offset) {
    offset = NativeOffsets.Fetch(offsetName);
    return offset != nint.Zero;
  }

  public bool HasPatch(string patchName) {
    return NativePatches.Exists(patchName);
  }

  public void ApplyPatch(string patchName) {
    NativePatches.Apply(patchName);
  } 

}
