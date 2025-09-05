using System.Drawing;

namespace SwiftlyS2.Shared.Natives.Handles;

/// <summary>
/// A handle to game tier0 CUtlVector object.
/// </summary>
public interface IUtlVectorHandle : INativeHandle {

  /// <summary>
  /// Get the element amount of the vector.
  /// </summary>
  /// <returns>The element amount of the vector.</returns>
  public int Count { get; }

  /// <summary>
  /// Get the size of the element type.
  /// </summary>
  /// <returns>The size of the element type.</returns>
  public int ElementSize { get; }

  /// <summary>
  /// Get the raw pointer to the element at the given index.
  /// Will throw an exception if the index is out of bounds.
  /// </summary>
  /// <param name="index">The index of the element to get.</param>
  /// <returns>The raw pointer to the element at the given index.</returns>
  public nint GetRawElementPointer(int index);
}

/// <summary>
/// A handle to game tier0 CUtlVector object for a specific unmanaged element type.
/// </summary>
/// <typeparam name="T">The type of the unmanaged type.</typeparam>
public interface IUtlVectorHandle<T> : IUtlVectorHandle where T : unmanaged{

  /// <summary>
  /// Get the reference to the element at the given index.
  /// Will throw an exception if the index is out of bounds.
  /// </summary>
  /// <param name="index">The index of the element to get.</param>
  /// <returns>The reference to the element at the given index.</returns>
  public ref T GetElement(int index);

  /// <summary>
  /// Set the element at the given index to the given value.
  /// Will throw an exception if the index is out of bounds.
  /// </summary>
  /// <param name="index">The index of the element to set.</param>
  /// <param name="value">The value to set the element to.</param>
  public void SetElement(int index, T value);
}


/// <summary>
/// A handle to game tier0 CUtlVector object with pointers.
/// </summary>
/// <typeparam name="T">The type of the pointer.</typeparam>
public interface IUtlVectorWithPointerHandle<T> : IUtlVectorHandle where T : INativeHandle
{

  /// <summary>
  /// Get the handle to the element at the given index.
  /// Will throw an exception if the index is out of bounds.
  /// </summary>
  /// <param name="index">The index of the element to get.</param>
  /// <returns>The handle to the element at the given index.</returns>
  public T GetElement(int index);
}