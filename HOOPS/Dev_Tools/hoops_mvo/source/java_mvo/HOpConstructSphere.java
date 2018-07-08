/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HOpConstructSphere extends HBaseOperator {
  private long swigCPtr;

  public HOpConstructSphere(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HOpConstructSphere_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HOpConstructSphere obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HOpConstructSphere(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    HJMVOJNI.HOpConstructSphere_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJMVOJNI.HOpConstructSphere_change_ownership(this, swigCPtr, true);
  }

  protected void setM_radius(float value) {
    HJMVOJNI.HOpConstructSphere_m_radius_set(swigCPtr, this, value);
  }

  protected float getM_radius() {
    return HJMVOJNI.HOpConstructSphere_m_radius_get(swigCPtr, this);
  }

  protected void ConstructWireframeSphere(HPoint center, float radius) {
    HJMVOJNI.HOpConstructSphere_ConstructWireframeSphere(swigCPtr, this, HPoint.getCPtr(center), center, radius);
  }

  public HOpConstructSphere(HBaseView view, int DoRepeat, int DoCapture) {
    this(HJMVOJNI.new_HOpConstructSphere__SWIG_0(HBaseView.getCPtr(view), view, DoRepeat, DoCapture), true);
    HJMVOJNI.HOpConstructSphere_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public HOpConstructSphere(HBaseView view, int DoRepeat) {
    this(HJMVOJNI.new_HOpConstructSphere__SWIG_1(HBaseView.getCPtr(view), view, DoRepeat), true);
    HJMVOJNI.HOpConstructSphere_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public HOpConstructSphere(HBaseView view) {
    this(HJMVOJNI.new_HOpConstructSphere__SWIG_2(HBaseView.getCPtr(view), view), true);
    HJMVOJNI.HOpConstructSphere_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public String GetName() {
    return (getClass() == HOpConstructSphere.class) ? HJMVOJNI.HOpConstructSphere_GetName(swigCPtr, this) : HJMVOJNI.HOpConstructSphere_GetNameSwigExplicitHOpConstructSphere(swigCPtr, this);
  }

  public int OnLButtonDown(HEventInfo hevent) {
    return (getClass() == HOpConstructSphere.class) ? HJMVOJNI.HOpConstructSphere_OnLButtonDown(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpConstructSphere_OnLButtonDownSwigExplicitHOpConstructSphere(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnLButtonDownAndMove(HEventInfo hevent) {
    return (getClass() == HOpConstructSphere.class) ? HJMVOJNI.HOpConstructSphere_OnLButtonDownAndMove(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpConstructSphere_OnLButtonDownAndMoveSwigExplicitHOpConstructSphere(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnLButtonUp(HEventInfo hevent) {
    return (getClass() == HOpConstructSphere.class) ? HJMVOJNI.HOpConstructSphere_OnLButtonUp(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpConstructSphere_OnLButtonUpSwigExplicitHOpConstructSphere(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public HBaseOperator Clone() {
    long cPtr = (getClass() == HOpConstructSphere.class) ? HJMVOJNI.HOpConstructSphere_Clone(swigCPtr, this) : HJMVOJNI.HOpConstructSphere_CloneSwigExplicitHOpConstructSphere(swigCPtr, this);
    return (cPtr == 0) ? null : new HBaseOperator(cPtr, false);
  }

}