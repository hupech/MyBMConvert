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


public class HOpCameraPanTouch : HBaseOperator {
  private HandleRef swigCPtr;

  public HOpCameraPanTouch(IntPtr cPtr, bool cMemoryOwn) : base(HCSMVOPINVOKE.HOpCameraPanTouchUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HOpCameraPanTouch obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HOpCameraPanTouch() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSMVOPINVOKE.delete_HOpCameraPanTouch(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HOpCameraPanTouch(HBaseView view, int DoRepeat, int DoCapture) : this(HCSMVOPINVOKE.new_HOpCameraPanTouch__SWIG_0(HBaseView.getCPtr(view), DoRepeat, DoCapture), true) {
  }

  public HOpCameraPanTouch(HBaseView view, int DoRepeat) : this(HCSMVOPINVOKE.new_HOpCameraPanTouch__SWIG_1(HBaseView.getCPtr(view), DoRepeat), true) {
  }

  public HOpCameraPanTouch(HBaseView view) : this(HCSMVOPINVOKE.new_HOpCameraPanTouch__SWIG_2(HBaseView.getCPtr(view)), true) {
  }

  public override string GetName() {
    string ret = HCSMVOPINVOKE.HOpCameraPanTouch_GetName(swigCPtr);
    return ret;
  }

  public override int OnTouchesDown(HEventInfo hevent) {
    int ret = HCSMVOPINVOKE.HOpCameraPanTouch_OnTouchesDown(swigCPtr, HEventInfo.getCPtr(hevent));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int OnTouchesMove(HEventInfo hevent) {
    int ret = HCSMVOPINVOKE.HOpCameraPanTouch_OnTouchesMove(swigCPtr, HEventInfo.getCPtr(hevent));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int OnTouchesUp(HEventInfo hevent) {
    int ret = HCSMVOPINVOKE.HOpCameraPanTouch_OnTouchesUp(swigCPtr, HEventInfo.getCPtr(hevent));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLightFollowsCamera(bool follow) {
    HCSMVOPINVOKE.HOpCameraPanTouch_SetLightFollowsCamera(swigCPtr, follow);
  }

  public bool GetLightFollowsCamera() {
    bool ret = HCSMVOPINVOKE.HOpCameraPanTouch_GetLightFollowsCamera(swigCPtr);
    return ret;
  }

  public override HBaseOperator Clone() {
    IntPtr cPtr = HCSMVOPINVOKE.HOpCameraPanTouch_Clone(swigCPtr);
    HBaseOperator ret = (cPtr == IntPtr.Zero) ? null : new HBaseOperator(cPtr, false);
    return ret;
  }

}
