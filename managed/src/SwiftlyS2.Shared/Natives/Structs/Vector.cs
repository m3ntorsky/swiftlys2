using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SwiftlyS2.Shared.Natives;

/// <summary>
/// 3-Dimensional vector for source 2.
/// 
/// No more cssharp chaos.
/// </summary>
[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 12)]
public struct Vector {
  public float X;
  public float Y;
  public float Z;

  public Vector(float x, float y, float z) {
    X = x;
    Y = y;
    Z = z;
  }

  public Vector(Vector other) {
    X = other.X;
    Y = other.Y;
    Z = other.Z;
  }

  public System.Numerics.Vector3 ToBuiltin()
  {
    return new(X, Y, Z);
  }

  public static Vector FromBuiltin(System.Numerics.Vector3 vector)
  {
    return new(vector.X, vector.Y, vector.Z);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float Length() => (float)Math.Sqrt(X * X + Y * Y + Z * Z);


  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float LengthSquared() => X * X + Y * Y + Z * Z;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float Distance(Vector other) => (this - other).Length();


  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float DistanceSquared(Vector other) => (this - other).LengthSquared();


  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Vector Cross(Vector other) => new(Y * other.Z - Z * other.Y, Z * other.X - X * other.Z, X * other.Y - Y * other.X);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Dot(Vector a, Vector b) => a.X * b.X + a.Y * b.Y + a.Z * b.Z;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public float Dot(Vector other) => Dot(this, other);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Normalize() {
    var len = Length();
    if (len > 0f) {
      var inv = 1.0f / len;
      X *= inv;
      Y *= inv;
      Z *= inv;
    }
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Vector Normalized() {
    var len = Length();
    if (len > 0f) {
      var inv = 1.0f / len;
      return new(X * inv, Y * inv, Z * inv);
    }
    return Zero;
  }

  public void Deconstruct(out float x, out float y, out float z) {
    x = X;
    y = Y;
    z = Z;
  }


  public override bool Equals(object? obj) => obj is Vector vector && this == vector;
  public override int GetHashCode() => HashCode.Combine(X, Y, Z);
  public override string ToString() => $"Vector({X}, {Y}, {Z})";

  public static Vector Zero => new(0, 0, 0);

  public static Vector One => new(1, 1, 1);


  [MethodImpl(MethodImplOptions.AggressiveInlining)]

  public static Vector operator +(Vector a, Vector b) => new(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector operator -(Vector a, Vector b) => new(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector operator *(Vector a, Vector b) => new(a.X * b.X, a.Y * b.Y, a.Z * b.Z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector operator /(Vector a, Vector b) => new(a.X / b.X, a.Y / b.Y, a.Z / b.Z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector operator *(Vector a, float b) => new(a.X * b, a.Y * b, a.Z * b);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector operator *(float b, Vector a) => new(a.X * b, a.Y * b, a.Z * b);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector operator /(Vector a, float b) {
    if (b == 0) {
      throw new DivideByZeroException();
    }
    var oofl = 1.0f / b;
    return new(a.X * oofl, a.Y * oofl, a.Z * oofl);
  }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector operator -(Vector a) => new(-a.X, -a.Y, -a.Z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool operator ==(Vector a, Vector b) => a.X == b.X && a.Y == b.Y && a.Z == b.Z;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool operator !=(Vector a, Vector b) => a.X != b.X || a.Y != b.Y || a.Z != b.Z;

}