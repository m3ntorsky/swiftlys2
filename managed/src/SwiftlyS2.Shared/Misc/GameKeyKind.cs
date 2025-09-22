namespace SwiftlyS2.Shared.Events;

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