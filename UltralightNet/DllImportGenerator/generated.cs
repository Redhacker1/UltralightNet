// Until https://github.com/dotnet/runtimelab/issues/925
// + (side story) https://github.com/dotnet/runtimelab/issues/938


#if (!NET5_0) || (!NET5_0_OR_GREATER) // just to make sure xD

using System;

#pragma warning disable IDE0059

namespace System.Runtime.CompilerServices
{
	internal class SkipLocalsInitAttribute: Attribute
	{

	}
}

namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulSessionIsPersistent(global::System.IntPtr session)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulSessionIsPersistent__PInvoke__(session);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulSessionIsPersistent")]
        extern private static unsafe byte ulSessionIsPersistent__PInvoke__(global::System.IntPtr session);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial ulong ulSessionGetId(global::System.IntPtr session)
        {
            unsafe
            {
                ulong __retVal = default;
                //
                // Invoke
                //
                __retVal = ulSessionGetId__PInvoke__(session);
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulSessionGetId")]
        extern private static unsafe ulong ulSessionGetId__PInvoke__(global::System.IntPtr session);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::System.IntPtr ulCreateBitmapFromPixels(uint width, uint height, global::UltralightNet.ULBitmapFormat format, uint row_bytes, global::System.IntPtr pixels, uint size, bool should_copy)
        {
            unsafe
            {
                byte __should_copy_gen_native = default;
                global::System.IntPtr __retVal = default;
                //
                // Marshal
                //
                __should_copy_gen_native = (byte)(should_copy ? 1 : 0);
                //
                // Invoke
                //
                __retVal = ulCreateBitmapFromPixels__PInvoke__(width, height, format, row_bytes, pixels, size, __should_copy_gen_native);
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulCreateBitmapFromPixels")]
        extern private static unsafe global::System.IntPtr ulCreateBitmapFromPixels__PInvoke__(uint width, uint height, global::UltralightNet.ULBitmapFormat format, uint row_bytes, global::System.IntPtr pixels, uint size, byte should_copy);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulBitmapOwnsPixels(global::System.IntPtr bitmap)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulBitmapOwnsPixels__PInvoke__(bitmap);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulBitmapOwnsPixels")]
        extern private static unsafe byte ulBitmapOwnsPixels__PInvoke__(global::System.IntPtr bitmap);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulBitmapIsEmpty(global::System.IntPtr bitmap)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulBitmapIsEmpty__PInvoke__(bitmap);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulBitmapIsEmpty")]
        extern private static unsafe byte ulBitmapIsEmpty__PInvoke__(global::System.IntPtr bitmap);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulBitmapWritePNG(global::System.IntPtr bitmap, string path)
        {
#if NET5_0_OR_GREATER
			unsafe
            {
                byte *__path_gen_native = default;
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Setup
                //
                bool path__allocated = false;
                try
                {
                    //
                    // Marshal
                    //
                    if (path != null)
                    {
                        int path__bytelen = (path.Length + 1) * 3 + 1;
                        if (path__bytelen > 260)
                        {
                            __path_gen_native = (byte *)System.Runtime.InteropServices.Marshal.StringToCoTaskMemUTF8(path);
                            path__allocated = true;
                        }
                        else
                        {
                            byte *path__stackptr = stackalloc byte[path__bytelen];
                            {
                                path__bytelen = System.Text.Encoding.UTF8.GetBytes(path, new System.Span<byte>(path__stackptr, path__bytelen));
                                path__stackptr[path__bytelen] = 0;
                            }

                            __path_gen_native = (byte *)path__stackptr;
                        }
                    }

                    //
                    // Invoke
                    //
                    __retVal_gen_native = ulBitmapWritePNG__PInvoke__(bitmap, __path_gen_native);
                    //
                    // Unmarshal
                    //
                    __retVal = __retVal_gen_native != 0;
                }
                finally
                {
                    //
                    // Cleanup
                    //
                    if (path__allocated)
                    {
                        System.Runtime.InteropServices.Marshal.FreeCoTaskMem((System.IntPtr)__path_gen_native);
                    }
                }

                return __retVal;
            }
#endif
			throw new PlatformNotSupportedException();
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", CharSet = System.Runtime.InteropServices.CharSet.Ansi, EntryPoint = "ulBitmapWritePNG")]
        extern private static unsafe byte ulBitmapWritePNG__PInvoke__(global::System.IntPtr bitmap, byte *path);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetUseGPURenderer(global::System.IntPtr config, bool use_gpu)
        {
            unsafe
            {
                byte __use_gpu_gen_native = default;
                //
                // Marshal
                //
                __use_gpu_gen_native = (byte)(use_gpu ? 1 : 0);
                //
                // Invoke
                //
                ulConfigSetUseGPURenderer__PInvoke__(config, __use_gpu_gen_native);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetUseGPURenderer")]
        extern private static unsafe void ulConfigSetUseGPURenderer__PInvoke__(global::System.IntPtr config, byte use_gpu);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetDeviceScale(global::System.IntPtr config, double value)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulConfigSetDeviceScale__PInvoke__(config, value);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetDeviceScale")]
        extern private static unsafe void ulConfigSetDeviceScale__PInvoke__(global::System.IntPtr config, double value);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetFaceWinding(global::System.IntPtr config, global::UltralightNet.ULFaceWinding winding)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulConfigSetFaceWinding__PInvoke__(config, winding);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetFaceWinding")]
        extern private static unsafe void ulConfigSetFaceWinding__PInvoke__(global::System.IntPtr config, global::UltralightNet.ULFaceWinding winding);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetEnableImages(global::System.IntPtr config, bool enabled)
        {
            unsafe
            {
                byte __enabled_gen_native = default;
                //
                // Marshal
                //
                __enabled_gen_native = (byte)(enabled ? 1 : 0);
                //
                // Invoke
                //
                ulConfigSetEnableImages__PInvoke__(config, __enabled_gen_native);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetEnableImages")]
        extern private static unsafe void ulConfigSetEnableImages__PInvoke__(global::System.IntPtr config, byte enabled);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetEnableJavaScript(global::System.IntPtr config, bool enabled)
        {
            unsafe
            {
                byte __enabled_gen_native = default;
                //
                // Marshal
                //
                __enabled_gen_native = (byte)(enabled ? 1 : 0);
                //
                // Invoke
                //
                ulConfigSetEnableJavaScript__PInvoke__(config, __enabled_gen_native);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetEnableJavaScript")]
        extern private static unsafe void ulConfigSetEnableJavaScript__PInvoke__(global::System.IntPtr config, byte enabled);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetFontHinting(global::System.IntPtr config, global::UltralightNet.ULFontHinting font_hinting)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulConfigSetFontHinting__PInvoke__(config, font_hinting);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetFontHinting")]
        extern private static unsafe void ulConfigSetFontHinting__PInvoke__(global::System.IntPtr config, global::UltralightNet.ULFontHinting font_hinting);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetFontGamma(global::System.IntPtr config, double font_gamma)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulConfigSetFontGamma__PInvoke__(config, font_gamma);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetFontGamma")]
        extern private static unsafe void ulConfigSetFontGamma__PInvoke__(global::System.IntPtr config, double font_gamma);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetForceRepaint(global::System.IntPtr config, bool enabled)
        {
            unsafe
            {
                byte __enabled_gen_native = default;
                //
                // Marshal
                //
                __enabled_gen_native = (byte)(enabled ? 1 : 0);
                //
                // Invoke
                //
                ulConfigSetForceRepaint__PInvoke__(config, __enabled_gen_native);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetForceRepaint")]
        extern private static unsafe void ulConfigSetForceRepaint__PInvoke__(global::System.IntPtr config, byte enabled);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetAnimationTimerDelay(global::System.IntPtr config, double delay)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulConfigSetAnimationTimerDelay__PInvoke__(config, delay);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetAnimationTimerDelay")]
        extern private static unsafe void ulConfigSetAnimationTimerDelay__PInvoke__(global::System.IntPtr config, double delay);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetScrollTimerDelay(global::System.IntPtr config, double delay)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulConfigSetScrollTimerDelay__PInvoke__(config, delay);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetScrollTimerDelay")]
        extern private static unsafe void ulConfigSetScrollTimerDelay__PInvoke__(global::System.IntPtr config, double delay);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulConfigSetRecycleDelay(global::System.IntPtr config, double delay)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulConfigSetRecycleDelay__PInvoke__(config, delay);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulConfigSetRecycleDelay")]
        extern private static unsafe void ulConfigSetRecycleDelay__PInvoke__(global::System.IntPtr config, double delay);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulIntRectIsEmpty(global::UltralightNet.ULIntRect rect)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulIntRectIsEmpty__PInvoke__(rect);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulIntRectIsEmpty")]
        extern private static unsafe byte ulIntRectIsEmpty__PInvoke__(global::UltralightNet.ULIntRect rect);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::UltralightNet.ULIntRect ulIntRectMakeEmpty()
        {
            unsafe
            {
                global::UltralightNet.ULIntRect __retVal = default;
                //
                // Invoke
                //
                __retVal = ulIntRectMakeEmpty__PInvoke__();
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulIntRectMakeEmpty")]
        extern private static unsafe global::UltralightNet.ULIntRect ulIntRectMakeEmpty__PInvoke__();
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulRectIsEmpty(global::UltralightNet.ULRect rect)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulRectIsEmpty__PInvoke__(rect);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulRectIsEmpty")]
        extern private static unsafe byte ulRectIsEmpty__PInvoke__(global::UltralightNet.ULRect rect);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::UltralightNet.ULRect ulRectMakeEmpty()
        {
            unsafe
            {
                global::UltralightNet.ULRect __retVal = default;
                //
                // Invoke
                //
                __retVal = ulRectMakeEmpty__PInvoke__();
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulRectMakeEmpty")]
        extern private static unsafe global::UltralightNet.ULRect ulRectMakeEmpty__PInvoke__();
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::System.IntPtr ulCreateString(string str)
        {
#if NET5_0_OR_GREATER
			unsafe
            {
                byte *__str_gen_native = default;
                global::System.IntPtr __retVal = default;
                //
                // Setup
                //
                bool str__allocated = false;
                try
                {
                    //
                    // Marshal
                    //
                    if (System.OperatingSystem.IsWindows())
                    {
                        __str_gen_native = (byte *)System.Runtime.InteropServices.Marshal.StringToCoTaskMemAnsi(str);
                        str__allocated = true;
                    }
                    else
                    {
                        if (str != null)
                        {
                            int str__bytelen = (str.Length + 1) * 3 + 1;
                            if (str__bytelen > 260)
                            {
                                __str_gen_native = (byte *)System.Runtime.InteropServices.Marshal.StringToCoTaskMemUTF8(str);
                                str__allocated = true;
                            }
                            else
                            {
                                byte *str__stackptr = stackalloc byte[str__bytelen];
                                {
                                    str__bytelen = System.Text.Encoding.UTF8.GetBytes(str, new System.Span<byte>(str__stackptr, str__bytelen));
                                    str__stackptr[str__bytelen] = 0;
                                }

                                __str_gen_native = (byte *)str__stackptr;
                            }
                        }
                    }

                    //
                    // Invoke
                    //
                    __retVal = ulCreateString__PInvoke__(__str_gen_native);
                }
                finally
                {
                    //
                    // Cleanup
                    //
                    if (str__allocated)
                    {
                        System.Runtime.InteropServices.Marshal.FreeCoTaskMem((System.IntPtr)__str_gen_native);
                    }
                }

                return __retVal;
            }
#endif
			throw new PlatformNotSupportedException();

		}

		[System.Runtime.InteropServices.DllImportAttribute("Ultralight", CharSet = System.Runtime.InteropServices.CharSet.Ansi, EntryPoint = "ulCreateString")]
        extern private static unsafe global::System.IntPtr ulCreateString__PInvoke__(byte *str);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::System.IntPtr ulCreateStringUTF8(string str, uint len)
        {
#if NET5_0_OR_GREATER
			unsafe
            {
                byte *__str_gen_native = default;
                global::System.IntPtr __retVal = default;
                //
                // Setup
                //
                bool str__allocated = false;
                try
                {
                    //
                    // Marshal
                    //
                    if (str != null)
                    {
                        int str__bytelen = (str.Length + 1) * 3 + 1;
                        if (str__bytelen > 260)
                        {
                            __str_gen_native = (byte *)System.Runtime.InteropServices.Marshal.StringToCoTaskMemUTF8(str);
                            str__allocated = true;
                        }
                        else
                        {
                            byte *str__stackptr = stackalloc byte[str__bytelen];
                            {
                                str__bytelen = System.Text.Encoding.UTF8.GetBytes(str, new System.Span<byte>(str__stackptr, str__bytelen));
                                str__stackptr[str__bytelen] = 0;
                            }

                            __str_gen_native = (byte *)str__stackptr;
                        }
                    }

                    //
                    // Invoke
                    //
                    __retVal = ulCreateStringUTF8__PInvoke__(__str_gen_native, len);
                }
                finally
                {
                    //
                    // Cleanup
                    //
                    if (str__allocated)
                    {
                        System.Runtime.InteropServices.Marshal.FreeCoTaskMem((System.IntPtr)__str_gen_native);
                    }
                }

                return __retVal;
            }
#endif
			throw new PlatformNotSupportedException();

		}

		[System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulCreateStringUTF8")]
        extern private static unsafe global::System.IntPtr ulCreateStringUTF8__PInvoke__(byte *str, uint len);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::System.IntPtr ulCreateStringUTF16(string str, uint len)
        {
            unsafe
            {
                ushort *__str_gen_native = default;
                global::System.IntPtr __retVal = default;
                //
                // Invoke
                //
                fixed (char *__str_gen_native__pinned = str)
                    __retVal = ulCreateStringUTF16__PInvoke__((ushort *)__str_gen_native__pinned, len);
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", CharSet = System.Runtime.InteropServices.CharSet.Unicode, EntryPoint = "ulCreateStringUTF16")]
        extern private static unsafe global::System.IntPtr ulCreateStringUTF16__PInvoke__(ushort *str, uint len);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial string ulStringGetData(global::System.IntPtr str)
        {
            unsafe
            {
                string __retVal = default;
                ushort *__retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulStringGetData__PInvoke__(str);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native == null ? null : new string ((char *)__retVal_gen_native);
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", CharSet = System.Runtime.InteropServices.CharSet.Unicode, EntryPoint = "ulStringGetData")]
        extern private static unsafe ushort *ulStringGetData__PInvoke__(global::System.IntPtr str);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial uint ulStringGetLength(global::System.IntPtr str)
        {
            unsafe
            {
                uint __retVal = default;
                //
                // Invoke
                //
                __retVal = ulStringGetLength__PInvoke__(str);
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulStringGetLength")]
        extern private static unsafe uint ulStringGetLength__PInvoke__(global::System.IntPtr str);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulStringIsEmpty(global::System.IntPtr str)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulStringIsEmpty__PInvoke__(str);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulStringIsEmpty")]
        extern private static unsafe byte ulStringIsEmpty__PInvoke__(global::System.IntPtr str);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulStringAssignCString(global::System.IntPtr str, string c_str)
        {
#if NET5_0_OR_GREATER
			unsafe
            {
                byte *__c_str_gen_native = default;
                //
                // Setup
                //
                bool c_str__allocated = false;
                try
                {
                    //
                    // Marshal
                    //
                    if (c_str != null)
                    {
                        int c_str__bytelen = (c_str.Length + 1) * 3 + 1;
                        if (c_str__bytelen > 260)
                        {
                            __c_str_gen_native = (byte *)System.Runtime.InteropServices.Marshal.StringToCoTaskMemUTF8(c_str);
                            c_str__allocated = true;
                        }
                        else
                        {
                            byte *c_str__stackptr = stackalloc byte[c_str__bytelen];
                            {
                                c_str__bytelen = System.Text.Encoding.UTF8.GetBytes(c_str, new System.Span<byte>(c_str__stackptr, c_str__bytelen));
                                c_str__stackptr[c_str__bytelen] = 0;
                            }

                            __c_str_gen_native = (byte *)c_str__stackptr;
                        }
                    }

                    //
                    // Invoke
                    //
                    ulStringAssignCString__PInvoke__(str, __c_str_gen_native);
                }
                finally
                {
                    //
                    // Cleanup
                    //
                    if (c_str__allocated)
                    {
                        System.Runtime.InteropServices.Marshal.FreeCoTaskMem((System.IntPtr)__c_str_gen_native);
                    }
                }
            }
#endif
			throw new PlatformNotSupportedException();

		}

		[System.Runtime.InteropServices.DllImportAttribute("Ultralight", CharSet = System.Runtime.InteropServices.CharSet.Ansi, EntryPoint = "ulStringAssignCString")]
        extern private static unsafe void ulStringAssignCString__PInvoke__(global::System.IntPtr str, byte *c_str);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulSurfaceSetDirtyBounds(global::System.IntPtr surface, global::UltralightNet.ULIntRect bounds)
        {
            unsafe
            {
                //
                // Invoke
                //
                ulSurfaceSetDirtyBounds__PInvoke__(surface, bounds);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulSurfaceSetDirtyBounds")]
        extern private static unsafe void ulSurfaceSetDirtyBounds__PInvoke__(global::System.IntPtr surface, global::UltralightNet.ULIntRect bounds);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::UltralightNet.ULIntRect ulSurfaceGetDirtyBounds(global::System.IntPtr surface)
        {
            unsafe
            {
                global::UltralightNet.ULIntRect __retVal = default;
                //
                // Invoke
                //
                __retVal = ulSurfaceGetDirtyBounds__PInvoke__(surface);
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulSurfaceGetDirtyBounds")]
        extern private static unsafe global::UltralightNet.ULIntRect ulSurfaceGetDirtyBounds__PInvoke__(global::System.IntPtr surface);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::System.IntPtr ulCreateView(global::System.IntPtr renderer, uint width, uint height, bool transparent, global::System.IntPtr session, bool force_cpu_renderer)
        {
            unsafe
            {
                byte __transparent_gen_native = default;
                byte __force_cpu_renderer_gen_native = default;
                global::System.IntPtr __retVal = default;
                //
                // Marshal
                //
                __transparent_gen_native = (byte)(transparent ? 1 : 0);
                __force_cpu_renderer_gen_native = (byte)(force_cpu_renderer ? 1 : 0);
                //
                // Invoke
                //
                __retVal = ulCreateView__PInvoke__(renderer, width, height, __transparent_gen_native, session, __force_cpu_renderer_gen_native);
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulCreateView")]
        extern private static unsafe global::System.IntPtr ulCreateView__PInvoke__(global::System.IntPtr renderer, uint width, uint height, byte transparent, global::System.IntPtr session, byte force_cpu_renderer);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulViewIsLoading(global::System.IntPtr view)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulViewIsLoading__PInvoke__(view);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewIsLoading")]
        extern private static unsafe byte ulViewIsLoading__PInvoke__(global::System.IntPtr view);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial global::UltralightNet.RenderTarget ulViewGetRenderTarget(global::System.IntPtr view)
        {
            unsafe
            {
                global::UltralightNet.RenderTarget __retVal = default;
                global::UltralightNet.RenderTargetNative __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulViewGetRenderTarget__PInvoke__(view);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native.ToManaged();
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewGetRenderTarget")]
        extern private static unsafe global::UltralightNet.RenderTargetNative ulViewGetRenderTarget__PInvoke__(global::System.IntPtr view);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulViewCanGoBack(global::System.IntPtr view)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulViewCanGoBack__PInvoke__(view);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewCanGoBack")]
        extern private static unsafe byte ulViewCanGoBack__PInvoke__(global::System.IntPtr view);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulViewCanGoForward(global::System.IntPtr view)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulViewCanGoForward__PInvoke__(view);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewCanGoForward")]
        extern private static unsafe byte ulViewCanGoForward__PInvoke__(global::System.IntPtr view);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulViewHasFocus(global::System.IntPtr view)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulViewHasFocus__PInvoke__(view);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewHasFocus")]
        extern private static unsafe byte ulViewHasFocus__PInvoke__(global::System.IntPtr view);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulViewHasInputFocus(global::System.IntPtr view)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulViewHasInputFocus__PInvoke__(view);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewHasInputFocus")]
        extern private static unsafe byte ulViewHasInputFocus__PInvoke__(global::System.IntPtr view);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulViewFireMouseEvent(global::System.IntPtr view, global::UltralightNet.ULMouseEvent mouse_event)
        {
            unsafe
            {
                global::UltralightNet.ULMouseEventNative __mouse_event_gen_native = default;
                //
                // Marshal
                //
                __mouse_event_gen_native = new global::UltralightNet.ULMouseEventNative(mouse_event);
                //
                // Invoke
                //
                ulViewFireMouseEvent__PInvoke__(view, __mouse_event_gen_native);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewFireMouseEvent")]
        extern private static unsafe void ulViewFireMouseEvent__PInvoke__(global::System.IntPtr view, global::UltralightNet.ULMouseEventNative mouse_event);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulViewFireScrollEvent(global::System.IntPtr view, global::UltralightNet.ULScrollEvent scroll_event)
        {
            unsafe
            {
                global::UltralightNet.ULScrollEventNative __scroll_event_gen_native = default;
                //
                // Marshal
                //
                __scroll_event_gen_native = new global::UltralightNet.ULScrollEventNative(scroll_event);
                //
                // Invoke
                //
                ulViewFireScrollEvent__PInvoke__(view, __scroll_event_gen_native);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewFireScrollEvent")]
        extern private static unsafe void ulViewFireScrollEvent__PInvoke__(global::System.IntPtr view, global::UltralightNet.ULScrollEventNative scroll_event);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial void ulViewSetNeedsPaint(global::System.IntPtr view, bool needs_paint)
        {
            unsafe
            {
                byte __needs_paint_gen_native = default;
                //
                // Marshal
                //
                __needs_paint_gen_native = (byte)(needs_paint ? 1 : 0);
                //
                // Invoke
                //
                ulViewSetNeedsPaint__PInvoke__(view, __needs_paint_gen_native);
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewSetNeedsPaint")]
        extern private static unsafe void ulViewSetNeedsPaint__PInvoke__(global::System.IntPtr view, byte needs_paint);
    }
}
namespace UltralightNet
{
    public static partial class Methods
    {
        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        public static partial bool ulViewGetNeedsPaint(global::System.IntPtr view)
        {
            unsafe
            {
                bool __retVal = default;
                byte __retVal_gen_native = default;
                //
                // Invoke
                //
                __retVal_gen_native = ulViewGetNeedsPaint__PInvoke__(view);
                //
                // Unmarshal
                //
                __retVal = __retVal_gen_native != 0;
                return __retVal;
            }
        }

        [System.Runtime.InteropServices.DllImportAttribute("Ultralight", EntryPoint = "ulViewGetNeedsPaint")]
        extern private static unsafe byte ulViewGetNeedsPaint__PInvoke__(global::System.IntPtr view);
    }
}

#pragma warning restore IDE0059

#endif
