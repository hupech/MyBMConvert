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


public class HEventManager : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public HEventManager(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HEventManager obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  
  public void owns_memory(bool ownMemory) {
	swigCMemOwn = ownMemory;
  }

  ~HEventManager() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSMVOPINVOKE.delete_HEventManager(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public HEventManager() : this(HCSMVOPINVOKE.new_HEventManager(), true) {
  }

  public void RegisterHandler(HEventListener listener, string eventtype, int priority) {
    HCSMVOPINVOKE.HEventManager_RegisterHandler__SWIG_0(swigCPtr, HEventListener.getCPtr(listener), eventtype, priority);
  }

  public void RegisterHandler(HEventListener listener, HEventListenerType eventtype, int priority) {
    HCSMVOPINVOKE.HEventManager_RegisterHandler__SWIG_1(swigCPtr, HEventListener.getCPtr(listener), (int)eventtype, priority);
  }

  public HEventListener GetEventListenerManager(string eventtype) {
    IntPtr cPtr = HCSMVOPINVOKE.HEventManager_GetEventListenerManager__SWIG_0(swigCPtr, eventtype);
    HEventListener ret = (cPtr == IntPtr.Zero) ? null : new HEventListener(cPtr, false);
    return ret;
  }

  public HEventListener GetEventListenerManager(HEventListenerType eventtype) {
    IntPtr cPtr = HCSMVOPINVOKE.HEventManager_GetEventListenerManager__SWIG_1(swigCPtr, (int)eventtype);
    HEventListener ret = (cPtr == IntPtr.Zero) ? null : new HEventListener(cPtr, false);
    return ret;
  }

  public bool UnRegisterHandler(HEventListener listener, string eventtype) {
    bool ret = HCSMVOPINVOKE.HEventManager_UnRegisterHandler__SWIG_0(swigCPtr, HEventListener.getCPtr(listener), eventtype);
    return ret;
  }

  public bool UnRegisterHandler(HEventListener listener, HEventListenerType eventtype) {
    bool ret = HCSMVOPINVOKE.HEventManager_UnRegisterHandler__SWIG_1(swigCPtr, HEventListener.getCPtr(listener), (int)eventtype);
    return ret;
  }

  public void UnRegisterHandler(HEventListener listener) {
    HCSMVOPINVOKE.HEventManager_UnRegisterHandler__SWIG_2(swigCPtr, HEventListener.getCPtr(listener));
  }

}
