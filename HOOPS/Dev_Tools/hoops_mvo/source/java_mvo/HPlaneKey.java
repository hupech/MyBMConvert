/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HPlaneKey extends HPlane {
  private long swigCPtr;

  public HPlaneKey(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HPlaneKey_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HPlaneKey obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HPlaneKey(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public HPlaneKey(float A, float B, float C, float D) {
    this(HJMVOJNI.new_HPlaneKey__SWIG_0(A, B, C, D), true);
  }

  public HPlaneKey(float A, float B, float C) {
    this(HJMVOJNI.new_HPlaneKey__SWIG_1(A, B, C), true);
  }

  public HPlaneKey(float A, float B) {
    this(HJMVOJNI.new_HPlaneKey__SWIG_2(A, B), true);
  }

  public HPlaneKey(float A) {
    this(HJMVOJNI.new_HPlaneKey__SWIG_3(A), true);
  }

  public HPlaneKey() {
    this(HJMVOJNI.new_HPlaneKey__SWIG_4(), true);
  }

  public HPlaneKey(HPoint normal, float D) {
    this(HJMVOJNI.new_HPlaneKey__SWIG_5(HPoint.getCPtr(normal), normal, D), true);
  }

  public HPlaneKey(HPlane p) {
    this(HJMVOJNI.new_HPlaneKey__SWIG_6(HPlane.getCPtr(p), p), true);
  }

}