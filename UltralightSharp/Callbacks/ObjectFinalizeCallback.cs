using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace ImpromptuNinjas.UltralightSharp {

  [PublicAPI]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public unsafe delegate void ObjectFinalizeCallback([NativeTypeName("JSObjectRef")] JsValue* @object);

  namespace Safe {

    [PublicAPI]
    public delegate void ObjectFinalizeCallback(JsObject @object);

  }

}