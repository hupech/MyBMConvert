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
using MVO_POINTER_SIZED_INT = System.Int64;
using MVO_POINTER_SIZED_UINT = System.UInt64;
using ID_Key = System.Int64;
#else
using MVO_POINTER_SIZED_INT = System.Int32;
using MVO_POINTER_SIZED_UINT = System.UInt32;
using ID_Key = System.Int32;
#endif


public class ShellInfo : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public ShellInfo(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(ShellInfo obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  
  public void owns_memory(bool ownMemory) {
	swigCMemOwn = ownMemory;
  }

  ~ShellInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSMVOPINVOKE.delete_ShellInfo(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public MVO_POINTER_SIZED_INT key {
	set { HCSMVOPINVOKE.ShellInfo_key_set(swigCPtr, value); } 
	get { return HCSMVOPINVOKE.ShellInfo_key_get(swigCPtr); } 
  }

  public MVO_POINTER_SIZED_INT offset {
	set { HCSMVOPINVOKE.ShellInfo_offset_set(swigCPtr, value); } 
	get { return HCSMVOPINVOKE.ShellInfo_offset_get(swigCPtr); } 
  }

  public ShellInfo() : this(HCSMVOPINVOKE.new_ShellInfo(), true) {
  }

}
