/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HPolyline {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public HPolyline(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(HPolyline obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HPolyline(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public void setM_PointCount(int value) {
    HJMVOJNI.HPolyline_m_PointCount_set(swigCPtr, this, value);
  }

  public int getM_PointCount() {
    return HJMVOJNI.HPolyline_m_PointCount_get(swigCPtr, this);
  }

  public void setM_pNextPolyline(HPolyline value) {
    HJMVOJNI.HPolyline_m_pNextPolyline_set(swigCPtr, this, HPolyline.getCPtr(value), value);
  }

  public HPolyline getM_pNextPolyline() {
    long cPtr = HJMVOJNI.HPolyline_m_pNextPolyline_get(swigCPtr, this);
    return (cPtr == 0) ? null : new HPolyline(cPtr, false);
  }

  public void get_m_pHPointArray(HPoint[] values, int count) {
    HJMVOJNI.HPolyline_get_m_pHPointArray(swigCPtr, this, HPoint.cArrayUnwrap(values), count);
  }

  public HPolyline() {
    this(HJMVOJNI.new_HPolyline(), true);
  }

}