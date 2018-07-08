/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

#if _M_X64
using HLONG = System.Int64;
using ID_Key = System.Int64;
#else
using HLONG = System.Int32;
using ID_Key = System.Int32;
#endif


public class eb_decompress_configs : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public eb_decompress_configs(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(eb_decompress_configs obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~eb_decompress_configs() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_eb_decompress_configs(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public ET_Bounding bounding {
    set {
      HCSSTREAMPINVOKE.eb_decompress_configs_bounding_set(swigCPtr, ET_Bounding.getCPtr(value));
    } 
    get {
      IntPtr cPtr = HCSSTREAMPINVOKE.eb_decompress_configs_bounding_get(swigCPtr);
      ET_Bounding ret = (cPtr == IntPtr.Zero) ? null : new ET_Bounding(cPtr, false);
      return ret;
    } 
  }

  public eb_decompress_configs() : this(HCSSTREAMPINVOKE.new_eb_decompress_configs(), true) {
  }

}
