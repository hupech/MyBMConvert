/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HShadow {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public HShadow(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(HShadow obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HShadow(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public HShadow(long ModelSegmentKey, long ShadowBaseSegmentKey, float[] ObjectModellingMatrix) {
    this(HJMVOJNI.new_HShadow__SWIG_0(ModelSegmentKey, ShadowBaseSegmentKey, ObjectModellingMatrix), true);
  }

  public HShadow(long ModelSegmentKey, long ShadowBaseSegmentKey) {
    this(HJMVOJNI.new_HShadow__SWIG_1(ModelSegmentKey, ShadowBaseSegmentKey), true);
  }

  public void CalculateTotalModelExtents() {
    HJMVOJNI.HShadow_CalculateTotalModelExtents(swigCPtr, this);
  }

  public void GetModelExtents(HPoint ObjectBoundingMin, HPoint ObjectBoundingMax) {
    HJMVOJNI.HShadow_GetModelExtents(swigCPtr, this, HPoint.getCPtr(ObjectBoundingMin), ObjectBoundingMin, HPoint.getCPtr(ObjectBoundingMax), ObjectBoundingMax);
  }

  public void GetShadowLightPos(HPoint lightpos) {
    HJMVOJNI.HShadow_GetShadowLightPos(swigCPtr, this, HPoint.getCPtr(lightpos), lightpos);
  }

  public void GetShadowGroundPlane(HPlane plane) {
    HJMVOJNI.HShadow_GetShadowGroundPlane(swigCPtr, this, HPlane.getCPtr(plane), plane);
  }

  public long GetShadowKey() {return HJMVOJNI.HShadow_GetShadowKey(swigCPtr, this);}

  public void SetShadowLightPos(HPoint lightpos) {
    HJMVOJNI.HShadow_SetShadowLightPos(swigCPtr, this, HPoint.getCPtr(lightpos), lightpos);
  }

  public void SetShadowGroundPlane(HPlane plane) {
    HJMVOJNI.HShadow_SetShadowGroundPlane(swigCPtr, this, HPlane.getCPtr(plane), plane);
  }

  public void SetShadowBrightness(int ShadowBrightness) {
    HJMVOJNI.HShadow_SetShadowBrightness(swigCPtr, this, ShadowBrightness);
  }

  public int GetShadowBrightness() {
    return HJMVOJNI.HShadow_GetShadowBrightness(swigCPtr, this);
  }

}