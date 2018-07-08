/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HOpNetwork extends HBaseOperator {
  private long swigCPtr;

  public HOpNetwork(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HOpNetwork_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HOpNetwork obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HOpNetwork(swigCPtr);
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
    HJMVOJNI.HOpNetwork_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJMVOJNI.HOpNetwork_change_ownership(this, swigCPtr, true);
  }

  public HOpNetwork(HBaseView view) {
    this(HJMVOJNI.new_HOpNetwork(HBaseView.getCPtr(view), view), true);
    HJMVOJNI.HOpNetwork_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public int OnLButtonDown(HEventInfo hevent) {
    return (getClass() == HOpNetwork.class) ? HJMVOJNI.HOpNetwork_OnLButtonDown(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpNetwork_OnLButtonDownSwigExplicitHOpNetwork(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnLButtonDownAndMove(HEventInfo hevent) {
    return (getClass() == HOpNetwork.class) ? HJMVOJNI.HOpNetwork_OnLButtonDownAndMove(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpNetwork_OnLButtonDownAndMoveSwigExplicitHOpNetwork(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnLButtonUp(HEventInfo hevent) {
    return (getClass() == HOpNetwork.class) ? HJMVOJNI.HOpNetwork_OnLButtonUp(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpNetwork_OnLButtonUpSwigExplicitHOpNetwork(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnRButtonDown(HEventInfo hevent) {
    return (getClass() == HOpNetwork.class) ? HJMVOJNI.HOpNetwork_OnRButtonDown(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpNetwork_OnRButtonDownSwigExplicitHOpNetwork(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnRButtonDownAndMove(HEventInfo hevent) {
    return (getClass() == HOpNetwork.class) ? HJMVOJNI.HOpNetwork_OnRButtonDownAndMove(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpNetwork_OnRButtonDownAndMoveSwigExplicitHOpNetwork(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  public int OnRButtonUp(HEventInfo hevent) {
    return (getClass() == HOpNetwork.class) ? HJMVOJNI.HOpNetwork_OnRButtonUp(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent) : HJMVOJNI.HOpNetwork_OnRButtonUpSwigExplicitHOpNetwork(swigCPtr, this, HEventInfo.getCPtr(hevent), hevent);
  }

  protected void setM_NetworkKey(long value) {
    HJMVOJNI.HOpNetwork_m_NetworkKey_set(swigCPtr, this, value);
  }

  protected long getM_NetworkKey() {return HJMVOJNI.HOpNetwork_m_NetworkKey_get(swigCPtr, this);}

  protected void setM_NodesKey(long value) {
    HJMVOJNI.HOpNetwork_m_NodesKey_set(swigCPtr, this, value);
  }

  protected long getM_NodesKey() {return HJMVOJNI.HOpNetwork_m_NodesKey_get(swigCPtr, this);}

  protected void setM_SelectedNodeKey(long value) {
    HJMVOJNI.HOpNetwork_m_SelectedNodeKey_set(swigCPtr, this, value);
  }

  protected long getM_SelectedNodeKey() {return HJMVOJNI.HOpNetwork_m_SelectedNodeKey_get(swigCPtr, this);}

  protected void setM_SelectedLineKey(long value) {
    HJMVOJNI.HOpNetwork_m_SelectedLineKey_set(swigCPtr, this, value);
  }

  protected long getM_SelectedLineKey() {return HJMVOJNI.HOpNetwork_m_SelectedLineKey_get(swigCPtr, this);}

  protected long My_KInsert_Line(float x1, float y1, float z1, float x2, float y2, float z2) {return HJMVOJNI.HOpNetwork_My_KInsert_Line(swigCPtr, this, x1, y1, z1, x2, y2, z2);}

  protected void My_Line_Common(long key, float x1, float y1, float z1, float x2, float y2, float z2) {
    HJMVOJNI.HOpNetwork_My_Line_Common(swigCPtr, this, key, x1, y1, z1, x2, y2, z2);
  }

  protected void My_Edit_Line(long key, float x1, float y1, float z1, float x2, float y2, float z2) {
    HJMVOJNI.HOpNetwork_My_Edit_Line(swigCPtr, this, key, x1, y1, z1, x2, y2, z2);
  }

  protected void My_Delete_Line(long key) {
    HJMVOJNI.HOpNetwork_My_Delete_Line(swigCPtr, this, key);
  }

  protected long My_KInsert_Node(float x, float y, float z) {return HJMVOJNI.HOpNetwork_My_KInsert_Node(swigCPtr, this, x, y, z);}

  protected void My_Edit_Node(long key, float x, float y, float z) {
    HJMVOJNI.HOpNetwork_My_Edit_Node(swigCPtr, this, key, x, y, z);
  }

  protected void Show_Node_Position(long key, float[] x, float[] y, float[] z) {
    HJMVOJNI.HOpNetwork_Show_Node_Position(swigCPtr, this, key, x, y, z);
  }

  protected long Get_Node_Key(long key) {return HJMVOJNI.HOpNetwork_Get_Node_Key(swigCPtr, this, key);}

  protected void My_Open_Node(long key) {
    HJMVOJNI.HOpNetwork_My_Open_Node(swigCPtr, this, key);
  }

  protected void My_Close_Node() {
    HJMVOJNI.HOpNetwork_My_Close_Node(swigCPtr, this);
  }

  protected long My_Renumber_Key(long key) {return HJMVOJNI.HOpNetwork_My_Renumber_Key(swigCPtr, this, key);}

  protected long GetNextKey() {return HJMVOJNI.HOpNetwork_GetNextKey(swigCPtr, this);}

}
