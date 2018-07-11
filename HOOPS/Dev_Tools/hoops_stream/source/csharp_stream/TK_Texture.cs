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


public class TK_Texture : BBaseOpcodeHandler {
  private HandleRef swigCPtr;

  public TK_Texture(IntPtr cPtr, bool cMemoryOwn) : base(HCSSTREAMPINVOKE.TK_TextureUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(TK_Texture obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~TK_Texture() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_TK_Texture(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public TK_Texture() : this(HCSSTREAMPINVOKE.new_TK_Texture(), true) {
    SwigDirectorConnect();
  }

  public override TK_Status Read(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(TK_Texture)) ? HCSSTREAMPINVOKE.TK_Texture_Read(swigCPtr, BStreamFileToolkit.getCPtr(tk)) : HCSSTREAMPINVOKE.TK_Texture_ReadSwigExplicitTK_Texture(swigCPtr, BStreamFileToolkit.getCPtr(tk)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Write(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(TK_Texture)) ? HCSSTREAMPINVOKE.TK_Texture_Write(swigCPtr, BStreamFileToolkit.getCPtr(tk)) : HCSSTREAMPINVOKE.TK_Texture_WriteSwigExplicitTK_Texture(swigCPtr, BStreamFileToolkit.getCPtr(tk)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    TK_Status ret = (TK_Status)((this.GetType() == typeof(TK_Texture)) ? HCSSTREAMPINVOKE.TK_Texture_Clone(swigCPtr, BStreamFileToolkit.getCPtr(tk), SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)) : HCSSTREAMPINVOKE.TK_Texture_CloneSwigExplicitTK_Texture(swigCPtr, BStreamFileToolkit.getCPtr(tk), SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TK_Status ReadAscii(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.TK_Texture_ReadAscii(swigCPtr, BStreamFileToolkit.getCPtr(tk));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TK_Status WriteAscii(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.TK_Texture_WriteAscii(swigCPtr, BStreamFileToolkit.getCPtr(tk));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Reset() {
    if (this.GetType() == typeof(TK_Texture)) HCSSTREAMPINVOKE.TK_Texture_Reset(swigCPtr); else HCSSTREAMPINVOKE.TK_Texture_ResetSwigExplicitTK_Texture(swigCPtr);
  }

  public void SetName(string name) {
    HCSSTREAMPINVOKE.TK_Texture_SetName__SWIG_0(swigCPtr, name);
  }

  public void SetName(int length) {
    HCSSTREAMPINVOKE.TK_Texture_SetName__SWIG_1(swigCPtr, length);
  }

  public string GetName() {return HCSSTREAMPINVOKE.TK_Texture_GetName__SWIG_0(swigCPtr);}

  public void SetShaderSource(string shader_source) {
    HCSSTREAMPINVOKE.TK_Texture_SetShaderSource__SWIG_0(swigCPtr, shader_source);
  }

  public void SetShaderSource(int length) {
    HCSSTREAMPINVOKE.TK_Texture_SetShaderSource__SWIG_1(swigCPtr, length);
  }

  public string GetShaderSource() {return HCSSTREAMPINVOKE.TK_Texture_GetShaderSource__SWIG_0(swigCPtr);}

  public void SetImage(string image) {
    HCSSTREAMPINVOKE.TK_Texture_SetImage__SWIG_0(swigCPtr, image);
  }

  public void SetImage(int length) {
    HCSSTREAMPINVOKE.TK_Texture_SetImage__SWIG_1(swigCPtr, length);
  }

  public string GetImage() {return HCSSTREAMPINVOKE.TK_Texture_GetImage__SWIG_0(swigCPtr);}

  public void SetCamera(string camera) {
    HCSSTREAMPINVOKE.TK_Texture_SetCamera__SWIG_0(swigCPtr, camera);
  }

  public void SetCamera(int length) {
    HCSSTREAMPINVOKE.TK_Texture_SetCamera__SWIG_1(swigCPtr, length);
  }

  public string GetCamera() {return HCSSTREAMPINVOKE.TK_Texture_GetCamera__SWIG_0(swigCPtr);}

  public void SetFlags(int f) {
    HCSSTREAMPINVOKE.TK_Texture_SetFlags(swigCPtr, f);
  }

  public int GetFlags() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetFlags(swigCPtr);
    return ret;
  }

  public void SetParameterSource(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetParameterSource(swigCPtr, p);
  }

  public int GetParameterSource() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetParameterSource(swigCPtr);
    return ret;
  }

  public void SetInterpolation(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetInterpolation(swigCPtr, p);
  }

  public int GetInterpolation() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetInterpolation(swigCPtr);
    return ret;
  }

  public void SetDecimation(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetDecimation(swigCPtr, p);
  }

  public int GetDecimation() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetDecimation(swigCPtr);
    return ret;
  }

  public void SetRedMapping(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetRedMapping(swigCPtr, p);
  }

  public int GetRedMapping() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetRedMapping(swigCPtr);
    return ret;
  }

  public void SetGreenMapping(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetGreenMapping(swigCPtr, p);
  }

  public int GetGreenMapping() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetGreenMapping(swigCPtr);
    return ret;
  }

  public void SetBlueMapping(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetBlueMapping(swigCPtr, p);
  }

  public int GetBlueMapping() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetBlueMapping(swigCPtr);
    return ret;
  }

  public void SetAlphaMapping(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetAlphaMapping(swigCPtr, p);
  }

  public int GetAlphaMapping() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetAlphaMapping(swigCPtr);
    return ret;
  }

  public void SetParameterFunction(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetParameterFunction(swigCPtr, p);
  }

  public int GetParameterFunction() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetParameterFunction(swigCPtr);
    return ret;
  }

  public void SetLayout(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetLayout(swigCPtr, p);
  }

  public int GetLayout() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetLayout(swigCPtr);
    return ret;
  }

  public void SetTiling(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetTiling(swigCPtr, p);
  }

  public int GetTiling() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetTiling(swigCPtr);
    return ret;
  }

  public void SetValueScale(float v1, float v2) {
    HCSSTREAMPINVOKE.TK_Texture_SetValueScale(swigCPtr, v1, v2);
  }

  public IntPtr GetValueScale() {return HCSSTREAMPINVOKE.TK_Texture_GetValueScale(swigCPtr);}

  public void SetApplicationMode(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetApplicationMode(swigCPtr, p);
  }

  public int GetApplicationMode() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetApplicationMode(swigCPtr);
    return ret;
  }

  public void SetParameterOffset(int p) {
    HCSSTREAMPINVOKE.TK_Texture_SetParameterOffset(swigCPtr, p);
  }

  public int GetParameterOffset() {
    int ret = HCSSTREAMPINVOKE.TK_Texture_GetParameterOffset(swigCPtr);
    return ret;
  }

  public void SetTransform(string transform) {
    HCSSTREAMPINVOKE.TK_Texture_SetTransform__SWIG_0(swigCPtr, transform);
  }

  public void SetTransform(int length) {
    HCSSTREAMPINVOKE.TK_Texture_SetTransform__SWIG_1(swigCPtr, length);
  }

  public string GetTransform() {return HCSSTREAMPINVOKE.TK_Texture_GetTransform__SWIG_0(swigCPtr);}

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("Read", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateTK_Texture_0(SwigDirectorRead);
    if (SwigDerivedClassHasMethod("Write", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateTK_Texture_1(SwigDirectorWrite);
    if (SwigDerivedClassHasMethod("Execute", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateTK_Texture_2(SwigDirectorExecute);
    if (SwigDerivedClassHasMethod("Interpret", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateTK_Texture_3(SwigDirectorInterpret__SWIG_0);
    if (SwigDerivedClassHasMethod("Interpret", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateTK_Texture_4(SwigDirectorInterpret__SWIG_1);
    if (SwigDerivedClassHasMethod("Interpret_special", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateTK_Texture_5(SwigDirectorInterpret_special);
    if (SwigDerivedClassHasMethod("Reset", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateTK_Texture_6(SwigDirectorReset);
    if (SwigDerivedClassHasMethod("Match_Instance", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateTK_Texture_7(SwigDirectorMatch_Instance);
    if (SwigDerivedClassHasMethod("Clone", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateTK_Texture_8(SwigDirectorClone);
    if (SwigDerivedClassHasMethod("NeedsContext", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateTK_Texture_9(SwigDirectorNeedsContext);
    HCSSTREAMPINVOKE.TK_Texture_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9);
  }

  private bool SwigDerivedClassHasMethod(string methodName, Type[] methodTypes) {
    System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(TK_Texture));
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

  public delegate int SwigDelegateTK_Texture_0(IntPtr tk);
  public delegate int SwigDelegateTK_Texture_1(IntPtr tk);
  public delegate int SwigDelegateTK_Texture_2(IntPtr tk);
  public delegate int SwigDelegateTK_Texture_3(IntPtr tk, ID_Key key, int variant);
  public delegate int SwigDelegateTK_Texture_4(IntPtr tk, ID_Key key);
  public delegate int SwigDelegateTK_Texture_5(IntPtr tk, ID_Key key, string special);
  public delegate void SwigDelegateTK_Texture_6();
  public delegate bool SwigDelegateTK_Texture_7(IntPtr tk, IntPtr instance);
  public delegate int SwigDelegateTK_Texture_8(IntPtr tk, IntPtr handler);
  public delegate bool SwigDelegateTK_Texture_9(IntPtr tk);

  private SwigDelegateTK_Texture_0 swigDelegate0;
  private SwigDelegateTK_Texture_1 swigDelegate1;
  private SwigDelegateTK_Texture_2 swigDelegate2;
  private SwigDelegateTK_Texture_3 swigDelegate3;
  private SwigDelegateTK_Texture_4 swigDelegate4;
  private SwigDelegateTK_Texture_5 swigDelegate5;
  private SwigDelegateTK_Texture_6 swigDelegate6;
  private SwigDelegateTK_Texture_7 swigDelegate7;
  private SwigDelegateTK_Texture_8 swigDelegate8;
  private SwigDelegateTK_Texture_9 swigDelegate9;

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