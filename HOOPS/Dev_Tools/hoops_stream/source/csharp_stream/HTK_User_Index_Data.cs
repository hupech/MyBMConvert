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


public class HTK_User_Index_Data : TK_User_Index_Data {
  private HandleRef swigCPtr;

  public HTK_User_Index_Data(IntPtr cPtr, bool cMemoryOwn) : base(HCSSTREAMPINVOKE.HTK_User_Index_DataUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HTK_User_Index_Data obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HTK_User_Index_Data() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_HTK_User_Index_Data(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public override TK_Status Execute(BStreamFileToolkit tk) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.HTK_User_Index_Data_Execute(swigCPtr, BStreamFileToolkit.getCPtr(tk));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Interpret(BStreamFileToolkit tk, ID_Key key, int variant) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.HTK_User_Index_Data_Interpret__SWIG_0(swigCPtr, BStreamFileToolkit.getCPtr(tk), key, variant);
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Interpret(BStreamFileToolkit tk, ID_Key key) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.HTK_User_Index_Data_Interpret__SWIG_1(swigCPtr, BStreamFileToolkit.getCPtr(tk), key);
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Interpret_special(BStreamFileToolkit tk, ID_Key key, string special) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.HTK_User_Index_Data_Interpret_special(swigCPtr, BStreamFileToolkit.getCPtr(tk), key, special);
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.HTK_User_Index_Data_Clone(swigCPtr, BStreamFileToolkit.getCPtr(tk), SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public HTK_User_Index_Data() : this(HCSSTREAMPINVOKE.new_HTK_User_Index_Data(), true) {
  }

}
