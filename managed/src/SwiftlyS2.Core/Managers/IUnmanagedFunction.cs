namespace SwiftlyS2.Core.Managers;

public interface IUnmanagedFunctionManager {

  public IUnmanagedFunction<T> FromSignature<T>(string signature) where T: Delegate;
}

public interface IUnmanagedFunction<T> where T: Delegate {

  public T Function { get; }

  public void AddHook(Action<nint> handler);

}