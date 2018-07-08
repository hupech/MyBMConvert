/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HKeyframeMatrix extends HKeyframeRotation {
  private long swigCPtr;

  public HKeyframeMatrix(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HKeyframeMatrix_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HKeyframeMatrix obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HKeyframeMatrix(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public HKeyframeMatrix(float[] matrix) {
    this(HJMVOJNI.new_HKeyframeMatrix__SWIG_0(matrix), true);
  }

  public HKeyframeMatrix() {
    this(HJMVOJNI.new_HKeyframeMatrix__SWIG_1(), true);
  }

  public HKeyframe Clone() {
    long cPtr = HJMVOJNI.HKeyframeMatrix_Clone(swigCPtr, this);
    return (cPtr == 0) ? null : new HKeyframe(cPtr, false);
  }

  public void Serialize(SWIGTYPE_p_HUtilityXMLTag xmlgen) {
    HJMVOJNI.HKeyframeMatrix_Serialize(swigCPtr, this, SWIGTYPE_p_HUtilityXMLTag.getCPtr(xmlgen));
  }

  public void setM_ExtraSpins(int value) {
    HJMVOJNI.HKeyframeMatrix_m_ExtraSpins_set(swigCPtr, this, value);
  }

  public int getM_ExtraSpins() {
    return HJMVOJNI.HKeyframeMatrix_m_ExtraSpins_get(swigCPtr, this);
  }

  public void get_m_matrix(float[] values, int count) {
    HJMVOJNI.HKeyframeMatrix_get_m_matrix(swigCPtr, this, values, count);
  }

}
