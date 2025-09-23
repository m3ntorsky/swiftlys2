namespace SwiftlyS2.Shared.Events;

[Flags]
public enum GameButtonFlags: ulong
{
    None = 0,
    Mouse1 = 1UL << 0,
    Space = 1UL << 1,
    Ctrl = 1UL << 2,
    W = 1UL << 3,
    S = 1UL << 4,
    E = 1UL << 5,
    Esc = 1UL << 6,
    A = 1UL << 7,
    D = 1UL << 8,
    A2 = 1UL << 9,
    D2 = 1UL << 10,
    Mouse2 = 1UL << 11,
    UnknownKeyRun = 1UL << 12,
    R = 1UL << 13,
    Alt = 1UL << 14,
    Alt2 = 1UL << 15,
    Shift = 1UL << 16,
    UnknownKeySpeed = 1UL << 17,
    Shift2 = 1UL << 18,
    UnknownKeyHudzoom = 1UL << 19,
    UnknownKeyWeapon1 = 1UL << 20,
    UnknownKeyWeapon2 = 1UL << 21,
    UnknownKeyBullrush = 1UL << 22,
    UnknownKeyGrenade1 = 1UL << 23,
    UnknownKeyGrenade2 = 1UL << 24,
    UnknownKeyLookspin = 1UL << 25,
    UnknownKey26 = 1UL << 26,
    UnknownKey27 = 1UL << 27,
    UnknownKey28 = 1UL << 28,
    UnknownKey29 = 1UL << 29,
    UnknownKey30 = 1UL << 30,
    UnknownKey31 = 1UL << 31,
    UnknownKey32 = 1UL << 32,
    Tab = 1UL << 33,
    UnknownKey34 = 1UL << 34,
    F = 1UL << 35,
    UnknownKey36 = 1UL << 36,
    UnknownKey37 = 1UL << 37,
    UnknownKey38 = 1UL << 38,
    UnknownKey39 = 1UL << 39,
    UnknownKey40 = 1UL << 40,
    UnknownKey41 = 1UL << 41,
    UnknownKey42 = 1UL << 42,
    UnknownKey43 = 1UL << 43,
    UnknownKey44 = 1UL << 44,
    UnknownKey45 = 1UL << 45,
    UnknownKey46 = 1UL << 46,
    UnknownKey47 = 1UL << 47,
    UnknownKey48 = 1UL << 48,
    UnknownKey49 = 1UL << 49,
    UnknownKey50 = 1UL << 50,
    UnknownKey51 = 1UL << 51,
    UnknownKey52 = 1UL << 52,
    UnknownKey53 = 1UL << 53,
    UnknownKey54 = 1UL << 54,
    UnknownKey55 = 1UL << 55,
    UnknownKey56 = 1UL << 56,
    UnknownKey57 = 1UL << 57,
    UnknownKey58 = 1UL << 58,
    UnknownKey59 = 1UL << 59,
    UnknownKey60 = 1UL << 60,
    UnknownKey61 = 1UL << 61,
    UnknownKey62 = 1UL << 62,
    UnknownKey63 = 1UL << 63,
}

public enum GameButtons : int
{

  Mouse1 = 0,

  Space = 1,

  Ctrl = 2,

  W = 3,

  S = 4,

  E = 5,

  Esc = 6,

  A = 7,

  D = 8,

  A2 = 9,

  D2 = 10,

  Mouse2 = 11,

  UnknownKeyRun = 12,

  R = 13,

  Alt = 14,

  Alt2 = 15,

  Shift = 16,

  UnknownKeySpeed = 17,

  Shift2 = 18,

  UnknownKeyHudzoom = 19,

  UnknownKeyWeapon1 = 20,

  UnknownKeyWeapon2 = 21,

  UnknownKeyBullrush = 22,

  UnknownKeyGrenade1 = 23,

  UnknownKeyGrenade2 = 24,

  UnknownKeyLookspin = 25,

  UnknownKey26 = 26,

  UnknownKey27 = 27,

  UnknownKey28 = 28,

  UnknownKey29 = 29,

  UnknownKey30 = 30,

  UnknownKey31 = 31,

  UnknownKey32 = 32,

  Tab = 33,

  UnknownKey34 = 34,

  F = 35,

  UnknownKey36 = 36,

  UnknownKey37 = 37,

  UnknownKey38 = 38,

  UnknownKey39 = 39,

  UnknownKey40 = 40,

  UnknownKey41 = 41,

  UnknownKey42 = 42,

  UnknownKey43 = 43,

  UnknownKey44 = 44,

  UnknownKey45 = 45,

  UnknownKey46 = 46,

  UnknownKey47 = 47,

  UnknownKey48 = 48,

  UnknownKey49 = 49,

  UnknownKey50 = 50,

  UnknownKey51 = 51,

  UnknownKey52 = 52,

  UnknownKey53 = 53,

  UnknownKey54 = 54,

  UnknownKey55 = 55,

  UnknownKey56 = 56,

  UnknownKey57 = 57,

  UnknownKey58 = 58,

  UnknownKey59 = 59,

  UnknownKey60 = 60,

  UnknownKey61 = 61,

  UnknownKey62 = 62,

  UnknownKey63 = 63,
}

internal static class GameKeyKindExtensions {
  public static KeyKind ToKeyKind(this GameButtons keyKind) {
    return keyKind switch {
      GameButtons.Mouse1 => KeyKind.Mouse1,
      GameButtons.Mouse2 => KeyKind.Mouse2,
      GameButtons.Space => KeyKind.Space,
      GameButtons.Ctrl => KeyKind.Ctrl,
      GameButtons.W => KeyKind.W,
      GameButtons.S => KeyKind.S,
      GameButtons.E => KeyKind.E,
      GameButtons.Esc => KeyKind.Esc,
      GameButtons.A => KeyKind.A,
      GameButtons.A2 => KeyKind.A,
      GameButtons.D => KeyKind.D,
      GameButtons.D2 => KeyKind.D,
      GameButtons.R => KeyKind.R,
      GameButtons.Alt => KeyKind.Alt,
      GameButtons.Shift => KeyKind.Shift,
      GameButtons.UnknownKeyWeapon1 => KeyKind.Weapon1,
      GameButtons.UnknownKeyWeapon2 => KeyKind.Weapon2,
      GameButtons.UnknownKeyGrenade1 => KeyKind.Grenade1,
      GameButtons.UnknownKeyGrenade2 => KeyKind.Grenade2,
      GameButtons.Tab => KeyKind.Tab,
      GameButtons.F => KeyKind.F,
      _ => throw new ArgumentException($"Unknown key kind: {keyKind}. Please report this to the SwiftlyS2 team.")
    };
  }
}