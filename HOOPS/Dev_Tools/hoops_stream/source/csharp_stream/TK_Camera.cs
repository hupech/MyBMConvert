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


public class TK_Camera : BBaseOpcodeHandler {
  private HandleRef swigCPtr;

  public TK_Camera(IntPtr cPtr, bool cMemoryOwn) : base(HCSSTREAMPINVOKE.TK_CameraUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(TK_Camera obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TK_Camera() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_TK_Camera(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public TK_Camera(byte opcode) : this(HCSSTREAMPINVOKE.new_TK_Camera__SWIG_0(opcode), true) {
    SwigDirectorConnect();
  }

  public TK_Camera() : this(HCSSTREAMPINVOKE.new_TK_Camera__SWIG_1(), true) {
    SwigDirectorConnect();
  }

  public override TK_Status Read(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(TK_Camera)) ? HCSSTREAMPINVOKE.TK_Camera_Read(swigCPtr, BStreamFileToolkit.getCPtr(tk)) : HCSSTREAMPINVOKE.TK_Camera_ReadSwigExplicitTK_Camera(swigCPtr, BStreamFileToolkit.getCPtr(tk)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Write(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(TK_Camera)) ? HCSSTREAMPINVOKE.TK_Camera_Write(swigCPtr, BStreamFileToolkit.getCPtr(tk)) : HCSSTREAMPINVOKE.TK_Camera_WriteSwigExplicitTK_Camera(swigCPtr, BStreamFileToolkit.getCPtr(tk)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(TK_Camera)) ? HCSSTREAMPINVOKE.TK_Camera_Clone(swigCPtr, BStreamFileToolkit.getCPtr(tk), SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)) : HCSSTREAMPINVOKE.TK_Camera_CloneSwigExplicitTK_Camera(swigCPtr, BStreamFileToolkit.getCPtr(tk), SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TK_Status ReadAscii(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.TK_Camera_ReadAscii(swigCPtr, BStreamFileToolkit.getCPtr(tk));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TK_Status WriteAscii(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.TK_Camera_WriteAscii(swigCPtr, BStreamFileToolkit.getCPtr(tk));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPosition(float x, float y, float z) {
    HCSSTREAMPINVOKE.TK_Camera_SetPosition__SWIG_0(swigCPtr, x, y, z);
  }

  public void SetPosition(float[] p) {
    HCSSTREAMPINVOKE.TK_Camera_SetPosition__SWIG_1(swigCPtr, p);
  }

  public IntPtr GetPosition() {return HCSSTREAMPINVOKE.TK_Camera_GetPosition__SWIG_0(swigCPtr);}

  public void GetPosition(float[] p) {
    HCSSTREAMPINVOKE.TK_Camera_GetPosition__SWIG_1(swigCPtr, p);
  }

  public void SetDPosition(double x, double y, double z) {
    HCSSTREAMPINVOKE.TK_Camera_SetDPosition__SWIG_0(swigCPtr, x, y, z);
  }

  public void SetDPosition(double[] p) {
    HCSSTREAMPINVOKE.TK_Camera_SetDPosition__SWIG_1(swigCPtr, p);
  }

  public IntPtr GetDPosition() {return HCSSTREAMPINVOKE.TK_Camera_GetDPosition__SWIG_0(swigCPtr);}

  public void GetDPosition(double[] p) {
    HCSSTREAMPINVOKE.TK_Camera_GetDPosition__SWIG_1(swigCPtr, p);
  }

  public void SetTarget(float x, float y, float z) {
    HCSSTREAMPINVOKE.TK_Camera_SetTarget__SWIG_0(swigCPtr, x, y, z);
  }

  public void SetTarget(float[] t) {
    HCSSTREAMPINVOKE.TK_Camera_SetTarget__SWIG_1(swigCPtr, t);
  }

  public IntPtr GetTarget() {return HCSSTREAMPINVOKE.TK_Camera_GetTarget__SWIG_0(swigCPtr);}

  public void GetTarget(float[] t) {
    HCSSTREAMPINVOKE.TK_Camera_GetTarget__SWIG_1(swigCPtr, t);
  }

  public void SetDTarget(double x, double y, double z) {
    HCSSTREAMPINVOKE.TK_Camera_SetDTarget__SWIG_0(swigCPtr, x, y, z);
  }

  public void SetDTarget(double[] t) {
    HCSSTREAMPINVOKE.TK_Camera_SetDTarget__SWIG_1(swigCPtr, t);
  }

  public IntPtr GetDTarget() {return HCSSTREAMPINVOKE.TK_Camera_GetDTarget__SWIG_0(swigCPtr);}

  public void GetDTarget(double[] t) {
    HCSSTREAMPINVOKE.TK_Camera_GetDTarget__SWIG_1(swigCPtr, t);
  }

  public void SetUpVector(float x, float y, float z) {
    HCSSTREAMPINVOKE.TK_Camera_SetUpVector__SWIG_0(swigCPtr, x, y, z);
  }

  public void SetUpVector(float[] u) {
    HCSSTREAMPINVOKE.TK_Camera_SetUpVector__SWIG_1(swigCPtr, u);
  }

  public IntPtr GetUpVector() {return HCSSTREAMPINVOKE.TK_Camera_GetUpVector__SWIG_0(swigCPtr);}

  public void GetUpVector(float[] u) {
    HCSSTREAMPINVOKE.TK_Camera_GetUpVector__SWIG_1(swigCPtr, u);
  }

  public void SetDUpVector(double x, double y, double z) {
    HCSSTREAMPINVOKE.TK_Camera_SetDUpVector__SWIG_0(swigCPtr, x, y, z);
  }

  public void SetDUpVector(double[] u) {
    HCSSTREAMPINVOKE.TK_Camera_SetDUpVector__SWIG_1(swigCPtr, u);
  }

  public IntPtr GetDUpVector() {return HCSSTREAMPINVOKE.TK_Camera_GetDUpVector__SWIG_0(swigCPtr);}

  public void GetDUpVector(double[] u) {
    HCSSTREAMPINVOKE.TK_Camera_GetDUpVector__SWIG_1(swigCPtr, u);
  }

  public void SetField(float w, float h) {
    HCSSTREAMPINVOKE.TK_Camera_SetField__SWIG_0(swigCPtr, w, h);
  }

  public void SetField(float[] f) {
    HCSSTREAMPINVOKE.TK_Camera_SetField__SWIG_1(swigCPtr, f);
  }

  public IntPtr GetField() {return HCSSTREAMPINVOKE.TK_Camera_GetField__SWIG_0(swigCPtr);}

  public void GetField(float[] f) {
    HCSSTREAMPINVOKE.TK_Camera_GetField__SWIG_1(swigCPtr, f);
  }

  public void SetDField(double w, double h) {
    HCSSTREAMPINVOKE.TK_Camera_SetDField__SWIG_0(swigCPtr, w, h);
  }

  public void SetDField(double[] f) {
    HCSSTREAMPINVOKE.TK_Camera_SetDField__SWIG_1(swigCPtr, f);
  }

  public IntPtr GetDField() {return HCSSTREAMPINVOKE.TK_Camera_GetDField__SWIG_0(swigCPtr);}

  public void GetDField(double[] f) {
    HCSSTREAMPINVOKE.TK_Camera_GetDField__SWIG_1(swigCPtr, f);
  }

  public void SetOblique(float h, float v) {
    HCSSTREAMPINVOKE.TK_Camera_SetOblique__SWIG_0(swigCPtr, h, v);
  }

  public void SetOblique(float[] o) {
    HCSSTREAMPINVOKE.TK_Camera_SetOblique__SWIG_1(swigCPtr, o);
  }

  public IntPtr GetOblique() {return HCSSTREAMPINVOKE.TK_Camera_GetOblique__SWIG_0(swigCPtr);}

  public void GetOblique(float[] o) {
    HCSSTREAMPINVOKE.TK_Camera_GetOblique__SWIG_1(swigCPtr, o);
  }

  public void SetNearLimit(float l) {
    HCSSTREAMPINVOKE.TK_Camera_SetNearLimit(swigCPtr, l);
  }

  public float GetNearLimit() {
    float ret = HCSSTREAMPINVOKE.TK_Camera_GetNearLimit(swigCPtr);
    return ret;
  }

  public void SetProjection(int p) {
    HCSSTREAMPINVOKE.TK_Camera_SetProjection(swigCPtr, p);
  }

  public int GetProjection() {
    int ret = HCSSTREAMPINVOKE.TK_Camera_GetProjection(swigCPtr);
    return ret;
  }

  public void SetView(string name) {
    HCSSTREAMPINVOKE.TK_Camera_SetView__SWIG_0(swigCPtr, name);
  }

  public void SetView(int length) {
    HCSSTREAMPINVOKE.TK_Camera_SetView__SWIG_1(swigCPtr, length);
  }

  public string GetView() {return HCSSTREAMPINVOKE.TK_Camera_GetView__SWIG_0(swigCPtr);}

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("Read", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateTK_Camera_0(SwigDirectorRead);
    if (SwigDerivedClassHasMethod("Write", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateTK_Camera_1(SwigDirectorWrite);
    if (SwigDerivedClassHasMethod("Execute", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateTK_Camera_2(SwigDirectorExecute);
    if (SwigDerivedClassHasMethod("Interpret", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateTK_Camera_3(SwigDirectorInterpret__SWIG_0);
    if (SwigDerivedClassHasMethod("Interpret", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateTK_Camera_4(SwigDirectorInterpret__SWIG_1);
    if (SwigDerivedClassHasMethod("Interpret_special", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateTK_Camera_5(SwigDirectorInterpret_special);
    if (SwigDerivedClassHasMethod("Reset", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateTK_Camera_6(SwigDirectorReset);
    if (SwigDerivedClassHasMethod("Match_Instance", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateTK_Camera_7(SwigDirectorMatch_Instance);
    if (SwigDerivedClassHasMethod("Clone", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateTK_Camera_8(SwigDirectorClone);
    if (SwigDerivedClassHasMethod("NeedsContext", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateTK_Camera_9(SwigDirectorNeedsContext);
    HCSSTREAMPINVOKE.TK_Camera_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(TK_Camera));
    return hasDerivedMethod;
  }

  private int SwigDirectorRead(IntPtr tk) {
    return (int)Read(new BStreamFileToolkit(tk, false));
  }

  private int SwigDirectorWrite(IntPtr tk) {
    return (int)Write(new BStreamFileToolkit(tk, false));
  }

  private int SwigDirectorExecute(IntPtr tk) {
    return (int)Execute(new BStreamFileToolkit(tk, false));
  }

  private int SwigDirectorInterpret__SWIG_0(IntPtr tk, ID_Key key, int variant) {
    return (int)Interpret(new BStreamFileToolkit(tk, false), key, variant);
  }

  private int SwigDirectorInterpret__SWIG_1(IntPtr tk, ID_Key key) {
    return (int)Interpret(new BStreamFileToolkit(tk, false), key);
  }

  private int SwigDirectorInterpret_special(IntPtr tk, ID_Key key, string special) {
    return (int)Interpret_special(new BStreamFileToolkit(tk, false), key, special);
  }

  private void SwigDirectorReset() {
    Reset();
  }

  private bool SwigDirectorMatch_Instance(IntPtr tk, IntPtr instance) {
    return Match_Instance(new BStreamFileToolkit(tk, false), (instance == IntPtr.Zero) ? null : new Recorded_Instance(instance, false));
  }

  private int SwigDirectorClone(IntPtr tk, IntPtr handler) {
    return (int)Clone(new BStreamFileToolkit(tk, false), (handler == IntPtr.Zero) ? null : new SWIGTYPE_p_p_BBaseOpcodeHandler(handler, false));
  }

  private bool SwigDirectorNeedsContext(IntPtr tk) {
    return NeedsContext(new BStreamFileToolkit(tk, false));
  }

  public delegate int SwigDelegateTK_Camera_0(IntPtr tk);
  public delegate int SwigDelegateTK_Camera_1(IntPtr tk);
  public delegate int SwigDelegateTK_Camera_2(IntPtr tk);
  public delegate int SwigDelegateTK_Camera_3(IntPtr tk, ID_Key key, int variant);
  public delegate int SwigDelegateTK_Camera_4(IntPtr tk, ID_Key key);
  public delegate int SwigDelegateTK_Camera_5(IntPtr tk, ID_Key key, string special);
  public delegate void SwigDelegateTK_Camera_6();
  public delegate bool SwigDelegateTK_Camera_7(IntPtr tk, IntPtr instance);
  public delegate int SwigDelegateTK_Camera_8(IntPtr tk, IntPtr handler);
  public delegate bool SwigDelegateTK_Camera_9(IntPtr tk);

  private SwigDelegateTK_Camera_0 swigDelegate0;
  private SwigDelegateTK_Camera_1 swigDelegate1;
  private SwigDelegateTK_Camera_2 swigDelegate2;
  private SwigDelegateTK_Camera_3 swigDelegate3;
  private SwigDelegateTK_Camera_4 swigDelegate4;
  private SwigDelegateTK_Camera_5 swigDelegate5;
  private SwigDelegateTK_Camera_6 swigDelegate6;
  private SwigDelegateTK_Camera_7 swigDelegate7;
  private SwigDelegateTK_Camera_8 swigDelegate8;
  private SwigDelegateTK_Camera_9 swigDelegate9;

  private static Type[] swigMethodTypes0 = new Type[] { typeof(BStreamFileToolkit) };
  private static Type[] swigMethodTypes1 = new Type[] { typeof(BStreamFileToolkit) };
  private static Type[] swigMethodTypes2 = new Type[] { typeof(BStreamFileToolkit) };
  private static Type[] swigMethodTypes3 = new Type[] { typeof(BStreamFileToolkit), typeof(ID_Key), typeof(int) };
  private static Type[] swigMethodTypes4 = new Type[] { typeof(BStreamFileToolkit), typeof(ID_Key) };
  private static Type[] swigMethodTypes5 = new Type[] { typeof(BStreamFileToolkit), typeof(ID_Key), typeof(string) };
  private static Type[] swigMethodTypes6 = new Type[] {  };
  private static Type[] swigMethodTypes7 = new Type[] { typeof(BStreamFileToolkit), typeof(Recorded_Instance) };
  private static Type[] swigMethodTypes8 = new Type[] { typeof(BStreamFileToolkit), typeof(SWIGTYPE_p_p_BBaseOpcodeHandler) };
  private static Type[] swigMethodTypes9 = new Type[] { typeof(BStreamFileToolkit) };
}
