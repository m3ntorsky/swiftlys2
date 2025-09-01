using System.Reflection;
using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives.Tables;

namespace SwiftlyS2.Core.Natives;
internal class NativeBinding
{
  public static void BindNatives(IntPtr nativeTable, int nativeTableSize)
  {
    unsafe
    {

      try {
        var pNativeTables = (NativeFunction*)nativeTable;

        for (int i = 0; i < nativeTableSize; i++)
        {
          var name = Marshal.PtrToStringUTF8(pNativeTables[i].Name)!;

          var names = name.Split('.');
          var className = names[0];
          var funcName = names[1];

          // TODO: might need nested namespace support.
          var nativeNameSpace = "SwiftlyS2.Natives.Tables." + className;

          var nativeClass = Type.GetType(nativeNameSpace)!;
          var nativeStaticField = nativeClass.GetField("_"+funcName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
          nativeStaticField!.SetValue(null, pNativeTables[i].Function);
        }
      } catch (Exception e)
      {
        Console.WriteLine(e);
      } 
    }
  }

}
