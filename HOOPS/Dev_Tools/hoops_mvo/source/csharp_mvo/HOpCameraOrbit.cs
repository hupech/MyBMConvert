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


public class HOpCameraOrbit : HBaseOperator {
  private HandleRef swigCPtr;

  public HOpCameraOrbit(IntPtr cPtr, bool cMemoryOwn) : base(HCSMVOPINVOKE.HOpCameraOrbitUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HOpCameraOrbit obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HOpCameraOrbit() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSMVOPINVOKE.delete_HOpCameraOrbit(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HOpCameraOrbit(HBaseView view, int DoRepeat, int DoCapture) : this(HCSMVOPINVOKE.new_HOpCameraOrbit__SWIG_0(HBaseView.getCPtr(view), DoRepeat, DoCapture), true) {
    SwigDirectorConnect();
  }

  public HOpCameraOrbit(HBaseView view, int DoRepeat) : this(HCSMVOPINVOKE.new_HOpCameraOrbit__SWIG_1(HBaseView.getCPtr(view), DoRepeat), true) {
    SwigDirectorConnect();
  }

  public HOpCameraOrbit(HBaseView view) : this(HCSMVOPINVOKE.new_HOpCameraOrbit__SWIG_2(HBaseView.getCPtr(view)), true) {
    SwigDirectorConnect();
  }

  public override string GetName() {
    string ret = ((this.GetType() == typeof(HOpCameraOrbit)) ? HCSMVOPINVOKE.HOpCameraOrbit_GetName(swigCPtr) : HCSMVOPINVOKE.HOpCameraOrbit_GetNameSwigExplicitHOpCameraOrbit(swigCPtr));
    return ret;
  }

  public override int OnLButtonDown(HEventInfo hevent) {
    int ret = ((this.GetType() == typeof(HOpCameraOrbit)) ? HCSMVOPINVOKE.HOpCameraOrbit_OnLButtonDown(swigCPtr, HEventInfo.getCPtr(hevent)) : HCSMVOPINVOKE.HOpCameraOrbit_OnLButtonDownSwigExplicitHOpCameraOrbit(swigCPtr, HEventInfo.getCPtr(hevent)));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int OnLButtonDownAndMove(HEventInfo hevent) {
    int ret = ((this.GetType() == typeof(HOpCameraOrbit)) ? HCSMVOPINVOKE.HOpCameraOrbit_OnLButtonDownAndMove(swigCPtr, HEventInfo.getCPtr(hevent)) : HCSMVOPINVOKE.HOpCameraOrbit_OnLButtonDownAndMoveSwigExplicitHOpCameraOrbit(swigCPtr, HEventInfo.getCPtr(hevent)));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int OnLButtonUp(HEventInfo hevent) {
    int ret = ((this.GetType() == typeof(HOpCameraOrbit)) ? HCSMVOPINVOKE.HOpCameraOrbit_OnLButtonUp(swigCPtr, HEventInfo.getCPtr(hevent)) : HCSMVOPINVOKE.HOpCameraOrbit_OnLButtonUpSwigExplicitHOpCameraOrbit(swigCPtr, HEventInfo.getCPtr(hevent)));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetLightFollowsCamera(bool follow) {
    HCSMVOPINVOKE.HOpCameraOrbit_SetLightFollowsCamera(swigCPtr, follow);
  }

  public bool GetLightFollowsCamera() {
    bool ret = HCSMVOPINVOKE.HOpCameraOrbit_GetLightFollowsCamera(swigCPtr);
    return ret;
  }

  public void SetSceneBoundingBoxVis(bool vis) {
    HCSMVOPINVOKE.HOpCameraOrbit_SetSceneBoundingBoxVis(swigCPtr, vis);
  }

  public bool GetSceneBoundingBoxVis() {
    bool ret = HCSMVOPINVOKE.HOpCameraOrbit_GetSceneBoundingBoxVis(swigCPtr);
    return ret;
  }

  public override HBaseOperator Clone() {
    IntPtr cPtr = ((this.GetType() == typeof(HOpCameraOrbit)) ? HCSMVOPINVOKE.HOpCameraOrbit_Clone(swigCPtr) : HCSMVOPINVOKE.HOpCameraOrbit_CloneSwigExplicitHOpCameraOrbit(swigCPtr));
    HBaseOperator ret = (cPtr == IntPtr.Zero) ? null : new HBaseOperator(cPtr, false);
    return ret;
  }

  public float m_Angle2 {
    set {
      HCSMVOPINVOKE.HOpCameraOrbit_m_Angle2_set(swigCPtr, value);
    } 
    get {
      float ret = HCSMVOPINVOKE.HOpCameraOrbit_m_Angle2_get(swigCPtr);
      return ret;
    } 
  }

  public float m_Angle1 {
    set {
      HCSMVOPINVOKE.HOpCameraOrbit_m_Angle1_set(swigCPtr, value);
    } 
    get {
      float ret = HCSMVOPINVOKE.HOpCameraOrbit_m_Angle1_get(swigCPtr);
      return ret;
    } 
  }

  public float m_Angle3 {
    set {
      HCSMVOPINVOKE.HOpCameraOrbit_m_Angle3_set(swigCPtr, value);
    } 
    get {
      float ret = HCSMVOPINVOKE.HOpCameraOrbit_m_Angle3_get(swigCPtr);
      return ret;
    } 
  }

  public bool GetSingleClick() {
    bool ret = HCSMVOPINVOKE.HOpCameraOrbit_GetSingleClick(swigCPtr);
    return ret;
  }

  protected bool m_bLightFollowsCamera {
    set {
      HCSMVOPINVOKE.HOpCameraOrbit_m_bLightFollowsCamera_set(swigCPtr, value);
    } 
    get {
      bool ret = HCSMVOPINVOKE.HOpCameraOrbit_m_bLightFollowsCamera_get(swigCPtr);
      return ret;
    } 
  }

  protected bool m_bSceneBoundingBoxVis {
    set {
      HCSMVOPINVOKE.HOpCameraOrbit_m_bSceneBoundingBoxVis_set(swigCPtr, value);
    } 
    get {
      bool ret = HCSMVOPINVOKE.HOpCameraOrbit_m_bSceneBoundingBoxVis_get(swigCPtr);
      return ret;
    } 
  }

  protected bool m_bSingleClick {
    set {
      HCSMVOPINVOKE.HOpCameraOrbit_m_bSingleClick_set(swigCPtr, value);
    } 
    get {
      bool ret = HCSMVOPINVOKE.HOpCameraOrbit_m_bSingleClick_get(swigCPtr);
      return ret;
    } 
  }

  protected HPoint m_ptRealOld {
    set {
      HCSMVOPINVOKE.HOpCameraOrbit_m_ptRealOld_set(swigCPtr, HPoint.getCPtr(value));
    } 
    get {
      IntPtr cPtr = HCSMVOPINVOKE.HOpCameraOrbit_m_ptRealOld_get(swigCPtr);
      HPoint ret = (cPtr == IntPtr.Zero) ? null : new HPoint(cPtr, false);
      return ret;
    } 
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("CreateListenerManager", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateHOpCameraOrbit_0(SwigDirectorCreateListenerManager);
    if (SwigDerivedClassHasMethod("OnLButtonDown", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateHOpCameraOrbit_1(SwigDirectorOnLButtonDown);
    if (SwigDerivedClassHasMethod("OnMouseMove", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateHOpCameraOrbit_2(SwigDirectorOnMouseMove);
    if (SwigDerivedClassHasMethod("OnLButtonUp", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateHOpCameraOrbit_3(SwigDirectorOnLButtonUp);
    if (SwigDerivedClassHasMethod("OnLButtonDblClk", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateHOpCameraOrbit_4(SwigDirectorOnLButtonDblClk);
    if (SwigDerivedClassHasMethod("OnMButtonDown", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateHOpCameraOrbit_5(SwigDirectorOnMButtonDown);
    if (SwigDerivedClassHasMethod("OnMButtonUp", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateHOpCameraOrbit_6(SwigDirectorOnMButtonUp);
    if (SwigDerivedClassHasMethod("OnMButtonDblClk", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateHOpCameraOrbit_7(SwigDirectorOnMButtonDblClk);
    if (SwigDerivedClassHasMethod("OnRButtonDown", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateHOpCameraOrbit_8(SwigDirectorOnRButtonDown);
    if (SwigDerivedClassHasMethod("OnRButtonUp", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateHOpCameraOrbit_9(SwigDirectorOnRButtonUp);
    if (SwigDerivedClassHasMethod("OnRButtonDblClk", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateHOpCameraOrbit_10(SwigDirectorOnRButtonDblClk);
    if (SwigDerivedClassHasMethod("OnMouseWheel", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateHOpCameraOrbit_11(SwigDirectorOnMouseWheel);
    if (SwigDerivedClassHasMethod("OnKeyDown", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateHOpCameraOrbit_12(SwigDirectorOnKeyDown);
    if (SwigDerivedClassHasMethod("OnKeyUp", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateHOpCameraOrbit_13(SwigDirectorOnKeyUp);
    if (SwigDerivedClassHasMethod("OnTouchesDown", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateHOpCameraOrbit_14(SwigDirectorOnTouchesDown);
    if (SwigDerivedClassHasMethod("OnTouchesMove", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateHOpCameraOrbit_15(SwigDirectorOnTouchesMove);
    if (SwigDerivedClassHasMethod("OnTouchesUp", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateHOpCameraOrbit_16(SwigDirectorOnTouchesUp);
    if (SwigDerivedClassHasMethod("Clone", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateHOpCameraOrbit_17(SwigDirectorClone);
    if (SwigDerivedClassHasMethod("OperatorStarted", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateHOpCameraOrbit_18(SwigDirectorOperatorStarted);
    if (SwigDerivedClassHasMethod("GetName", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateHOpCameraOrbit_19(SwigDirectorGetName);
    if (SwigDerivedClassHasMethod("OnLButtonDownAndMove", swigMethodTypes20))
      swigDelegate20 = new SwigDelegateHOpCameraOrbit_20(SwigDirectorOnLButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnMButtonDownAndMove", swigMethodTypes21))
      swigDelegate21 = new SwigDelegateHOpCameraOrbit_21(SwigDirectorOnMButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnRButtonDownAndMove", swigMethodTypes22))
      swigDelegate22 = new SwigDelegateHOpCameraOrbit_22(SwigDirectorOnRButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnLRButtonDownAndMove", swigMethodTypes23))
      swigDelegate23 = new SwigDelegateHOpCameraOrbit_23(SwigDirectorOnLRButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnNoButtonDownAndMove", swigMethodTypes24))
      swigDelegate24 = new SwigDelegateHOpCameraOrbit_24(SwigDirectorOnNoButtonDownAndMove);
    if (SwigDerivedClassHasMethod("OnTimer", swigMethodTypes25))
      swigDelegate25 = new SwigDelegateHOpCameraOrbit_25(SwigDirectorOnTimer);
    HCSMVOPINVOKE.HOpCameraOrbit_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19, swigDelegate20, swigDelegate21, swigDelegate22, swigDelegate23, swigDelegate24, swigDelegate25);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(HOpCameraOrbit));
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

  public delegate IntPtr SwigDelegateHOpCameraOrbit_0();
  public delegate int SwigDelegateHOpCameraOrbit_1(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_2(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_3(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_4(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_5(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_6(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_7(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_8(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_9(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_10(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_11(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_12(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_13(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_14(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_15(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_16(IntPtr hevent);
  public delegate IntPtr SwigDelegateHOpCameraOrbit_17();
  public delegate bool SwigDelegateHOpCameraOrbit_18();
  public delegate string SwigDelegateHOpCameraOrbit_19();
  public delegate int SwigDelegateHOpCameraOrbit_20(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_21(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_22(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_23(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_24(IntPtr hevent);
  public delegate int SwigDelegateHOpCameraOrbit_25(IntPtr hevent);

  private SwigDelegateHOpCameraOrbit_0 swigDelegate0;
  private SwigDelegateHOpCameraOrbit_1 swigDelegate1;
  private SwigDelegateHOpCameraOrbit_2 swigDelegate2;
  private SwigDelegateHOpCameraOrbit_3 swigDelegate3;
  private SwigDelegateHOpCameraOrbit_4 swigDelegate4;
  private SwigDelegateHOpCameraOrbit_5 swigDelegate5;
  private SwigDelegateHOpCameraOrbit_6 swigDelegate6;
  private SwigDelegateHOpCameraOrbit_7 swigDelegate7;
  private SwigDelegateHOpCameraOrbit_8 swigDelegate8;
  private SwigDelegateHOpCameraOrbit_9 swigDelegate9;
  private SwigDelegateHOpCameraOrbit_10 swigDelegate10;
  private SwigDelegateHOpCameraOrbit_11 swigDelegate11;
  private SwigDelegateHOpCameraOrbit_12 swigDelegate12;
  private SwigDelegateHOpCameraOrbit_13 swigDelegate13;
  private SwigDelegateHOpCameraOrbit_14 swigDelegate14;
  private SwigDelegateHOpCameraOrbit_15 swigDelegate15;
  private SwigDelegateHOpCameraOrbit_16 swigDelegate16;
  private SwigDelegateHOpCameraOrbit_17 swigDelegate17;
  private SwigDelegateHOpCameraOrbit_18 swigDelegate18;
  private SwigDelegateHOpCameraOrbit_19 swigDelegate19;
  private SwigDelegateHOpCameraOrbit_20 swigDelegate20;
  private SwigDelegateHOpCameraOrbit_21 swigDelegate21;
  private SwigDelegateHOpCameraOrbit_22 swigDelegate22;
  private SwigDelegateHOpCameraOrbit_23 swigDelegate23;
  private SwigDelegateHOpCameraOrbit_24 swigDelegate24;
  private SwigDelegateHOpCameraOrbit_25 swigDelegate25;

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