namespace SwiftlyS2.Shared.Natives;

public interface INativeObject : IDisposable {

  public unsafe nint GetPtr();

}