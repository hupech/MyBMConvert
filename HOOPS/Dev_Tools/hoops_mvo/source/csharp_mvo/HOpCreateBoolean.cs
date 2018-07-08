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


public class HOpCreateBoolean : HBaseOperator {
  private HandleRef swigCPtr;

  public HOpCreateBoolean(IntPtr cPtr, bool cMemoryOwn) : base(HCSMVOPINVOKE.HOpCreateBooleanUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HOpCreateBoolean obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HOpCreateBoolean() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSMVOPINVOKE.delete_HOpCreateBoolean(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HOpCreateBoolean(HBaseView view, int nBooleanType, int DoRepeat, int DoCapture) : this(HCSMVOPINVOKE.new_HOpCreateBoolean__SWIG_0(HBaseView.getCPtr(view), nBooleanType, DoRepeat, DoCapture), true) {
    SwigDirectorConnect();
  }

  public HOpCreateBoolean(HBaseView view, int nBooleanType, int DoRepeat) : this(HCSMVOPINVOKE.new_HOpCreateBoolean__SWIG_1(HBaseView.getCPtr(view), nBooleanType, DoRepeat), true) {
    SwigDirectorConnect();
  }

  public HOpCreateBoolean(HBaseView view, int nBooleanType) : this(HCSMVOPINVOKE.new_HOpCreateBoolean__SWIG_2(HBaseView.getCPtr(view), nBooleanType), true) {
    SwigDirectorConnect();
  }

  public override string GetName() {
    string ret = ((this.GetType() == typeof(HOpCreateBoolean)) ? HCSMVOPINVOKE.HOpCreateBoolean_GetName(swigCPtr) : HCSMVOPINVOKE.HOpCreateBoolean_GetNameSwigExplicitHOpCreateBoolean(swigCPtr));
    return ret;
  }

  public override int OnLButtonDown(HEventInfo hevent) {
    int ret = ((this.GetType() == typeof(HOpCreateBoolean)) ? HCSMVOPINVOKE.HOpCreateBoolean_OnLButtonDown(swigCPtr, HEventInfo.getCPtr(hevent)) : HCSMVOPINVOKE.HOpCreateBoolean_OnLButtonDownSwigExplicitHOpCreateBoolean(swigCPtr, HEventInfo.getCPtr(hevent)));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override HBaseOperator Clone() {
    IntPtr cPtr = ((this.GetType() == typeof(HOpCreateBoolean)) ? HCSMVOPINVOKE.HOpCreateBoolean_Clone(swigCPtr) : HCSMVOPINVOKE.HOpCreateBoolean_CloneSwigExplicitHOpCreateBoolean(swigCPtr));
    HBaseOperator ret = (cPtr == IntPtr.Zero) ? null : new HBaseOperator(cPtr, false);
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("CreateListenerManager", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateHOpCreateBoolean_0(SwigDirectorCreateListenerManager);
    if (SwigDerivedClassHasMethod("OnLButtonDown", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateHOpCreateBoolean_1(SwigDirectorOnLButtonDown);
    if (SwigDerivedClassHasMethod("OnMouseMove", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateHOpCreateBoolean_2(SwigDirectorOnMouseMove);
    if (SwigDerivedClassHasMethod("OnLButtonUp", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateHOpCreateBoolean_3(SwigDirectorOnLButtonUp);
    if (SwigDerivedClassHasMethod("OnLButtonDblClk", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateHOpCreateBoolean_4(SwigDirectorOnLButtonDblClk);
    if (SwigDerivedClassHasMethod("OnMButtonDown", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateHOpCreateBoolean_5(SwigDirectorOnMButtonDown);
    if (SwigDerivedClassHasMethod("OnMButtonUp", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateHOpCreateBoolean_6(SwigDirectorOnMButtonUp);
    if (SwigDerivedClassHasMethod("OnMButtonDblClk", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateHOpCreateBoolean_7(SwigDirectorOnMButtonDblClk);
    if (SwigDerivedClassHasMethod("OnRButtonDown", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateHOpCreateBoolean_8(SwigDirectorOnRButtonDown);
    if (SwigDerivedClassHasMethod("OnRButtonUp", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateHOpCreateBoolean_9(SwigDirectorOnRButtonUp);
    if (SwigDerivedClassHasMethod("OnRButtonDblClk", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateHOpCreateBoolean_10(SwigDirectorOnRButtonDblClk);
    if (SwigDerivedClassHasMethod("OnMouseWheel", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateHOpCreateBoolean_11(SwigDirectorOnMouseWheel);
    if (SwigDerivedClassHasMethod("OnKeyDown", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateHOpCreateBoolean_12(SwigDirectorOnKeyDown);
    if (SwigDerivedClassHasMethod("OnKeyUp", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateHOpCreateBoolean_13(SwigDirectorOnKeyUp);
    if (SwigDerivedClassHasMethod("OnTouchesDown", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateHOpCreateBoolean_14(SwigDirectorOnTouchesDown);
    if (SwigDerivedClassHasMethod("OnTouchesMove", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateHOpCreateBoolean_15(SwigDirectorOnTouchesMove);
    if (SwigDerivedClassHasMethod("OnTouchesUp", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateHOpCreateBoolean_16(SwigDirectorOnTouchesUp);
    if (SwigDerivedClassHasMethod("Clone", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateHOpCreateBoolean_17(SwigDirectorClone);
    if (SwigDerivedClassHasMethod("OperatorStarted", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateHOpCreateBoolean_18(SwigDirectorOperatorStarted);
    if (SwigDerivedClassHasMethod("GetName", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateHOpCreateBoolean_19(SwigDirectorGetName);
    if (SwigDerivedClassHasMethod("OnLButtonDownAndMove", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateHOpCreateBoolean_20(SwigDirectorOnLButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnMButtonDownAndMove", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateHOpCreateBoolean_21(SwigDirectorOnMButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnRButtonDownAndMove", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateHOpCreateBoolean_22(SwigDirectorOnRButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnLRButtonDownAndMove", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateHOpCreateBoolean_23(SwigDirectorOnLRButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnNoButtonDownAndMove", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateHOpCreateBoolean_24(SwigDirectorOnNoButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnTimer", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateHOpCreateBoolean_25(SwigDirectorOnTimer);
    HCSMVOPINVOKE.HOpCreateBoolean_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(HOpCreateBoolean));
    return hasDerivedMethod;
  }

  private IntPtr SwigDirectorCreateListenerManager() {
    return HEventListener.getCPtr(CreateListenerManager()).Handle;
  }

  private int SwigDirectorOnLButtonDown(IntPtr hevent) {
    return OnLButtonDown(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnMouseMove(IntPtr hevent) {
    return OnMouseMove(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnLButtonUp(IntPtr hevent) {
    return OnLButtonUp(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnLButtonDblClk(IntPtr hevent) {
    return OnLButtonDblClk(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnMButtonDown(IntPtr hevent) {
    return OnMButtonDown(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnMButtonUp(IntPtr hevent) {
    return OnMButtonUp(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnMButtonDblClk(IntPtr hevent) {
    return OnMButtonDblClk(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnRButtonDown(IntPtr hevent) {
    return OnRButtonDown(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnRButtonUp(IntPtr hevent) {
    return OnRButtonUp(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnRButtonDblClk(IntPtr hevent) {
    return OnRButtonDblClk(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnMouseWheel(IntPtr hevent) {
    return OnMouseWheel(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnKeyDown(IntPtr hevent) {
    return OnKeyDown(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnKeyUp(IntPtr hevent) {
    return OnKeyUp(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnTouchesDown(IntPtr hevent) {
    return OnTouchesDown(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnTouchesMove(IntPtr hevent) {
    return OnTouchesMove(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnTouchesUp(IntPtr hevent) {
    return OnTouchesUp(new HEventInfo(hevent, false));
  }

  private IntPtr SwigDirectorClone() {
    return HBaseOperator.getCPtr(Clone()).Handle;
  }

  private bool SwigDirectorOperatorStarted() {
    return OperatorStarted();
  }

  private string SwigDirectorGetName() {
    return GetName();
  }

  private int SwigDirectorOnLButtonDownAndMove(IntPtr hevent) {
    return OnLButtonDownAndMove(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnMButtonDownAndMove(IntPtr hevent) {
    return OnMButtonDownAndMove(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnRButtonDownAndMove(IntPtr hevent) {
    return OnRButtonDownAndMove(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnLRButtonDownAndMove(IntPtr hevent) {
    return OnLRButtonDownAndMove(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnNoButtonDownAndMove(IntPtr hevent) {
    return OnNoButtonDownAndMove(new HEventInfo(hevent, false));
  }

  private int SwigDirectorOnTimer(IntPtr hevent) {
    return OnTimer(new HEventInfo(hevent, false));
  }

  public delegate IntPtr SwigDelegateHOpCreateBoolean_0();
  public delegate int SwigDelegateHOpCreateBoolean_1(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_2(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_3(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_4(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_5(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_6(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_7(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_8(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_9(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_10(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_11(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_12(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_13(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_14(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_15(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_16(IntPtr hevent);
  public delegate IntPtr SwigDelegateHOpCreateBoolean_17();
  public delegate bool SwigDelegateHOpCreateBoolean_18();
  public delegate string SwigDelegateHOpCreateBoolean_19();
  public delegate int SwigDelegateHOpCreateBoolean_20(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_21(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_22(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_23(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_24(IntPtr hevent);
  public delegate int SwigDelegateHOpCreateBoolean_25(IntPtr hevent);

  private SwigDelegateHOpCreateBoolean_0 swigDelegate0;
  private SwigDelegateHOpCreateBoolean_1 swigDelegate1;
  private SwigDelegateHOpCreateBoolean_2 swigDelegate2;
  private SwigDelegateHOpCreateBoolean_3 swigDelegate3;
  private SwigDelegateHOpCreateBoolean_4 swigDelegate4;
  private SwigDelegateHOpCreateBoolean_5 swigDelegate5;
  private SwigDelegateHOpCreateBoolean_6 swigDelegate6;
  private SwigDelegateHOpCreateBoolean_7 swigDelegate7;
  private SwigDelegateHOpCreateBoolean_8 swigDelegate8;
  private SwigDelegateHOpCreateBoolean_9 swigDelegate9;
  private SwigDelegateHOpCreateBoolean_10 swigDelegate10;
  private SwigDelegateHOpCreateBoolean_11 swigDelegate11;
  private SwigDelegateHOpCreateBoolean_12 swigDelegate12;
  private SwigDelegateHOpCreateBoolean_13 swigDelegate13;
  private SwigDelegateHOpCreateBoolean_14 swigDelegate14;
  private SwigDelegateHOpCreateBoolean_15 swigDelegate15;
  private SwigDelegateHOpCreateBoolean_16 swigDelegate16;
  private SwigDelegateHOpCreateBoolean_17 swigDelegate17;
  private SwigDelegateHOpCreateBoolean_18 swigDelegate18;
  private SwigDelegateHOpCreateBoolean_19 swigDelegate19;
  private SwigDelegateHOpCreateBoolean_20 swigDelegate20;
  private SwigDelegateHOpCreateBoolean_21 swigDelegate21;
  private SwigDelegateHOpCreateBoolean_22 swigDelegate22;
  private SwigDelegateHOpCreateBoolean_23 swigDelegate23;
  private SwigDelegateHOpCreateBoolean_24 swigDelegate24;
  private SwigDelegateHOpCreateBoolean_25 swigDelegate25;

  private static Type[] swigMethodTypes0 = new Type[] {  };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes6 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes10 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes11 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes12 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes13 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes14 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes15 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes16 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes17 = new Type[] {  };
  private static Type[] swigMethodTypes18 = new Type[] {  };
  private static Type[] swigMethodTypes19 = new Type[] {  };
  private static Type[] swigMethodTypes20 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes21 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes22 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes23 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes24 = new Type[] { typeof(HEventInfo) };
  private static Type[] swigMethodTypes25 = new Type[] { typeof(HEventInfo) };
}
