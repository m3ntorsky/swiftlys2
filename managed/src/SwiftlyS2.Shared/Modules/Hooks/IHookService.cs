namespace SwiftlyS2.Shared.Hooks;

public interface IHookService {

  /// <summary>
  /// Hook a native function at the specified address with a managed callback.
  /// The <paramref name="callbackBuilder"/> receives the pointer to the "next" function in the chain
  /// (previous callback if any, or the original function pointer if this is the first callback),
  /// and must return a delegate matching the native function signature with proper calling convention.
  /// </summary>
  /// <typeparam name="TDelegate">Delegate type that matches the native function signature.</typeparam>
  /// <param name="functionAddress">Absolute address of the native function to hook.</param>
  /// <param name="callbackBuilder">Builder that receives the next function pointer and returns the managed callback.</param>
  /// <returns>a guid for the hook.</returns>
  public Guid Hook<TDelegate>(nint functionAddress, Func<Func<TDelegate>, TDelegate> callbackBuilder) where TDelegate : Delegate;

  /// <summary>
  /// Hook a vtable function at the specified address with a managed callback.
  /// The <paramref name="callbackBuilder"/> receives the pointer to the "next" function in the chain
  /// (previous callback if any, or the original function pointer if this is the first callback),
  /// and must return a delegate matching the native function signature with proper calling convention.
  /// </summary>
  /// <typeparam name="TDelegate">Delegate type that matches the native function signature.</typeparam>
  /// <param name="vtableAddress">Absolute address of the vtable to hook.</param>
  /// <param name="index">Index of the function to hook.</param>
  /// <param name="callbackBuilder">Builder that receives the next function pointer and returns the managed callback.</param>
  /// <returns>a guid for the hook.</returns>
  public Guid VHook<TDelegate>(nint vtableAddress, int index, Func<Func<TDelegate>, TDelegate> callbackBuilder) where TDelegate : Delegate; 

  /// <summary>
  /// Unhook a hook by its id.
  /// </summary>
  /// <param name="id">The id of the hook to unhook.</param>
  public void Unhook(Guid id);
} 