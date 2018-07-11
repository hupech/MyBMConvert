/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HObjectManipulationListener extends HEventListener {
  private long swigCPtr;

  public HObjectManipulationListener(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HObjectManipulationListener_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HObjectManipulationListener obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HObjectManipulationListener(swigCPtr);
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
    HJMVOJNI.HObjectManipulationListener_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJMVOJNI.HObjectManipulationListener_change_ownership(this, swigCPtr, true);
  }

  public static HEventListenerType GetEventType() {
    return HEventListenerType.swigToEnum(HJMVOJNI.HObjectManipulationListener_GetEventType());
  }

  public HEventListener CreateListenerManager() {
    long cPtr = (getClass() == HObjectManipulationListener.class) ? HJMVOJNI.HObjectManipulationListener_CreateListenerManager(swigCPtr, this) : HJMVOJNI.HObjectManipulationListener_CreateListenerManagerSwigExplicitHObjectManipulationListener(swigCPtr, this);
    return (cPtr == 0) ? null : new HEventListener(cPtr, false);
  }

  public int SetupHandlesEvent(HBaseView view, long key, boolean complex) {
    return (getClass() == HObjectManipulationListener.class) ? HJMVOJNI.HObjectManipulationListener_SetupHandlesEvent(swigCPtr, this, HBaseView.getCPtr(view), view, key, complex) : HJMVOJNI.HObjectManipulationListener_SetupHandlesEventSwigExplicitHObjectManipulationListener(swigCPtr, this, HBaseView.getCPtr(view), view, key, complex);
  }

  public int ObjectBeforeMoveEvent(HBaseView view, long key, HPoint p) {
    return (getClass() == HObjectManipulationListener.class) ? HJMVOJNI.HObjectManipulationListener_ObjectBeforeMoveEvent(swigCPtr, this, HBaseView.getCPtr(view), view, key, HPoint.getCPtr(p), p) : HJMVOJNI.HObjectManipulationListener_ObjectBeforeMoveEventSwigExplicitHObjectManipulationListener(swigCPtr, this, HBaseView.getCPtr(view), view, key, HPoint.getCPtr(p), p);
  }

  public int ObjectMovedEvent(HBaseView view, long key, HPoint p) {
    return (getClass() == HObjectManipulationListener.class) ? HJMVOJNI.HObjectManipulationListener_ObjectMovedEvent(swigCPtr, this, HBaseView.getCPtr(view), view, key, HPoint.getCPtr(p), p) : HJMVOJNI.HObjectManipulationListener_ObjectMovedEventSwigExplicitHObjectManipulationListener(swigCPtr, this, HBaseView.getCPtr(view), view, key, HPoint.getCPtr(p), p);
  }

  public int ObjectScaledEvent(HBaseView view, long key, HPoint p) {
    return (getClass() == HObjectManipulationListener.class) ? HJMVOJNI.HObjectManipulationListener_ObjectScaledEvent(swigCPtr, this, HBaseView.getCPtr(view), view, key, HPoint.getCPtr(p), p) : HJMVOJNI.HObjectManipulationListener_ObjectScaledEventSwigExplicitHObjectManipulationListener(swigCPtr, this, HBaseView.getCPtr(view), view, key, HPoint.getCPtr(p), p);
  }

  public HObjectManipulationListener() {
    this(HJMVOJNI.new_HObjectManipulationListener(), true);
    HJMVOJNI.HObjectManipulationListener_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

}