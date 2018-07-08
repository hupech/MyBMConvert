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


public class HTK_Size : TK_Size {
  private HandleRef swigCPtr;

  public HTK_Size(IntPtr cPtr, bool cMemoryOwn) : base(HCSSTREAMPINVOKE.HTK_SizeUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HTK_Size obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HTK_Size() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_HTK_Size(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HTK_Size(byte opcode) : this(HCSSTREAMPINVOKE.new_HTK_Size(opcode), true) {
    SwigDirectorConnect();
  }

  public override TK_Status Execute(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(HTK_Size)) ? HCSSTREAMPINVOKE.HTK_Size_Execute(swigCPtr, BStreamFileToolkit.getCPtr(tk)) : HCSSTREAMPINVOKE.HTK_Size_ExecuteSwigExplicitHTK_Size(swigCPtr, BStreamFileToolkit.getCPtr(tk)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Interpret(BStreamFileToolkit tk, ID_Key key, int variant) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(HTK_Size)) ? HCSSTREAMPINVOKE.HTK_Size_Interpret__SWIG_0(swigCPtr, BStreamFileToolkit.getCPtr(tk), key, variant) : HCSSTREAMPINVOKE.HTK_Size_InterpretSwigExplicitHTK_Size__SWIG_0(swigCPtr, BStreamFileToolkit.getCPtr(tk), key, variant));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Interpret(BStreamFileToolkit tk, ID_Key key) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(HTK_Size)) ? HCSSTREAMPINVOKE.HTK_Size_Interpret__SWIG_1(swigCPtr, BStreamFileToolkit.getCPtr(tk), key) : HCSSTREAMPINVOKE.HTK_Size_InterpretSwigExplicitHTK_Size__SWIG_1(swigCPtr, BStreamFileToolkit.getCPtr(tk), key));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Interpret_special(BStreamFileToolkit tk, ID_Key key, string special) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(HTK_Size)) ? HCSSTREAMPINVOKE.HTK_Size_Interpret_special(swigCPtr, BStreamFileToolkit.getCPtr(tk), key, special) : HCSSTREAMPINVOKE.HTK_Size_Interpret_specialSwigExplicitHTK_Size(swigCPtr, BStreamFileToolkit.getCPtr(tk), key, special));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(HTK_Size)) ? HCSSTREAMPINVOKE.HTK_Size_Clone(swigCPtr, BStreamFileToolkit.getCPtr(tk), SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)) : HCSSTREAMPINVOKE.HTK_Size_CloneSwigExplicitHTK_Size(swigCPtr, BStreamFileToolkit.getCPtr(tk), SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("Read", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateHTK_Size_0(SwigDirectorRead);
    if (SwigDerivedClassHasMethod("Write", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateHTK_Size_1(SwigDirectorWrite);
    if (SwigDerivedClassHasMethod("Execute", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateHTK_Size_2(SwigDirectorExecute);
    if (SwigDerivedClassHasMethod("Interpret", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateHTK_Size_3(SwigDirectorInterpret__SWIG_0);
    if (SwigDerivedClassHasMethod("Interpret", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateHTK_Size_4(SwigDirectorInterpret__SWIG_1);
    if (SwigDerivedClassHasMethod("Interpret_special", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateHTK_Size_5(SwigDirectorInterpret_special);
    if (SwigDerivedClassHasMethod("Reset", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateHTK_Size_6(SwigDirectorReset);
    if (SwigDerivedClassHasMethod("Match_Instance", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateHTK_Size_7(SwigDirectorMatch_Instance);
    if (SwigDerivedClassHasMethod("Clone", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateHTK_Size_8(SwigDirectorClone);
    if (SwigDerivedClassHasMethod("NeedsContext", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateHTK_Size_9(SwigDirectorNeedsContext);
    HCSSTREAMPINVOKE.HTK_Size_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(HTK_Size));
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

  public delegate int SwigDelegateHTK_Size_0(IntPtr tk);
  public delegate int SwigDelegateHTK_Size_1(IntPtr tk);
  public delegate int SwigDelegateHTK_Size_2(IntPtr tk);
  public delegate int SwigDelegateHTK_Size_3(IntPtr tk, ID_Key key, int variant);
  public delegate int SwigDelegateHTK_Size_4(IntPtr tk, ID_Key key);
  public delegate int SwigDelegateHTK_Size_5(IntPtr tk, ID_Key key, string special);
  public delegate void SwigDelegateHTK_Size_6();
  public delegate bool SwigDelegateHTK_Size_7(IntPtr tk, IntPtr instance);
  public delegate int SwigDelegateHTK_Size_8(IntPtr tk, IntPtr handler);
  public delegate bool SwigDelegateHTK_Size_9(IntPtr tk);

  private SwigDelegateHTK_Size_0 swigDelegate0;
  private SwigDelegateHTK_Size_1 swigDelegate1;
  private SwigDelegateHTK_Size_2 swigDelegate2;
  private SwigDelegateHTK_Size_3 swigDelegate3;
  private SwigDelegateHTK_Size_4 swigDelegate4;
  private SwigDelegateHTK_Size_5 swigDelegate5;
  private SwigDelegateHTK_Size_6 swigDelegate6;
  private SwigDelegateHTK_Size_7 swigDelegate7;
  private SwigDelegateHTK_Size_8 swigDelegate8;
  private SwigDelegateHTK_Size_9 swigDelegate9;

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
