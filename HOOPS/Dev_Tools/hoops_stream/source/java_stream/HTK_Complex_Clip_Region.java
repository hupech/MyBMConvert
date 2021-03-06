/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HTK_Complex_Clip_Region extends TK_Complex_Clip_Region {
  private long swigCPtr;

  protected HTK_Complex_Clip_Region(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGHTK_Complex_Clip_RegionUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(HTK_Complex_Clip_Region obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_HTK_Complex_Clip_Region(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public TK_Status Execute(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Complex_Clip_Region_Execute(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key, int variant) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Complex_Clip_Region_Interpret__SWIG_0(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, variant));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Complex_Clip_Region_Interpret__SWIG_1(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key, String special) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Complex_Clip_Region_Interpret__SWIG_2(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, special));
  }

  public TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Complex_Clip_Region_Clone(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
  }

  public HTK_Complex_Clip_Region() {
    this(HJSTREAMJNI.new_HTK_Complex_Clip_Region(), true);
  }

}
