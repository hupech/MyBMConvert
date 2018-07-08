/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class TK_Complex_Clip_Region extends BBaseOpcodeHandler {
  private long swigCPtr;

  protected TK_Complex_Clip_Region(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGTK_Complex_Clip_RegionUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(TK_Complex_Clip_Region obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_TK_Complex_Clip_Region(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public TK_Complex_Clip_Region() {
    this(HJSTREAMJNI.new_TK_Complex_Clip_Region(), true);
  }

  public TK_Status Read(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Complex_Clip_Region_Read(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Write(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Complex_Clip_Region_Write(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Complex_Clip_Region_Clone(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
  }

  public TK_Status ReadAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Complex_Clip_Region_ReadAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status WriteAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Complex_Clip_Region_WriteAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public void Reset() {
    HJSTREAMJNI.TK_Complex_Clip_Region_Reset(swigCPtr, this);
  }

  public void SetPoints(int count, float[] points) {
    HJSTREAMJNI.TK_Complex_Clip_Region_SetPoints__SWIG_0(swigCPtr, this, count, points);
  }

  public void SetPoints(int count) {
    HJSTREAMJNI.TK_Complex_Clip_Region_SetPoints__SWIG_1(swigCPtr, this, count);
  }

  public float[] GetPoints() {return HJSTREAMJNI.TK_Complex_Clip_Region_GetPoints__SWIG_0(swigCPtr, this);}

  public void SetDPoints(int count, double[] points) {
    HJSTREAMJNI.TK_Complex_Clip_Region_SetDPoints__SWIG_0(swigCPtr, this, count, points);
  }

  public void SetDPoints(int count) {
    HJSTREAMJNI.TK_Complex_Clip_Region_SetDPoints__SWIG_1(swigCPtr, this, count);
  }

  public double[] GetDPoints() {return HJSTREAMJNI.TK_Complex_Clip_Region_GetDPoints__SWIG_0(swigCPtr, this);}

  public void SetLengths(int count, int[] lengths) {
    HJSTREAMJNI.TK_Complex_Clip_Region_SetLengths__SWIG_0(swigCPtr, this, count, lengths);
  }

  public void SetLengths(int count) {
    HJSTREAMJNI.TK_Complex_Clip_Region_SetLengths__SWIG_1(swigCPtr, this, count);
  }

  public int[] GetLengths() {return HJSTREAMJNI.TK_Complex_Clip_Region_GetLengths__SWIG_0(swigCPtr, this);}

  public int GetTotal() {
    return HJSTREAMJNI.TK_Complex_Clip_Region_GetTotal(swigCPtr, this);
  }

  public int GetLoops() {
    return HJSTREAMJNI.TK_Complex_Clip_Region_GetLoops(swigCPtr, this);
  }

  public void SetOptions(int o) {
    HJSTREAMJNI.TK_Complex_Clip_Region_SetOptions(swigCPtr, this, o);
  }

  public int GetOptions() {
    return HJSTREAMJNI.TK_Complex_Clip_Region_GetOptions(swigCPtr, this);
  }

}