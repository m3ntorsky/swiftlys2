using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential)]
public struct CUtlString {

  private CUtlBinaryBlock _storage;

  public string Value; // TODO: Implement with natives
}