/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HEdgeVertexSelectionObject extends HObject {
  private long swigCPtr;

  public HEdgeVertexSelectionObject(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HEdgeVertexSelectionObject_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HEdgeVertexSelectionObject obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HEdgeVertexSelectionObject(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public HEdgeVertexSelectionObject(HBaseView view) {
    this(HJMVOJNI.new_HEdgeVertexSelectionObject(HBaseView.getCPtr(view), view), true);
  }

  public int OnMouseMove(HEventInfo hevent) {
    return HJMVOJNI.HEdgeVertexSelectionObject_OnMouseMove(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnLButtonDown(HEventInfo hevent) {
    return HJMVOJNI.HEdgeVertexSelectionObject_OnLButtonDown(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnLButtonUp(HEventInfo hevent) {
    return HJMVOJNI.HEdgeVertexSelectionObject_OnLButtonUp(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public void IncludeEntity(HBaseView view, long movekey) {
    HJMVOJNI.HEdgeVertexSelectionObject_IncludeEntity(swigCPtr, this, HBaseView.getCPtr(view), view, movekey);
  }

  public static String GetStaticName() {
    return HJMVOJNI.HEdgeVertexSelectionObject_GetStaticName();
  }

  public String GetName() {
    return HJMVOJNI.HEdgeVertexSelectionObject_GetName(swigCPtr, this);
  }

}