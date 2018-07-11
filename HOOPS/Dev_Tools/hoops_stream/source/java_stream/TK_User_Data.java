/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class TK_User_Data extends BBaseOpcodeHandler {
  private long swigCPtr;

  protected TK_User_Data(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGTK_User_DataUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(TK_User_Data obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_TK_User_Data(swigCPtr);
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
    HJSTREAMJNI.TK_User_Data_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJSTREAMJNI.TK_User_Data_change_ownership(this, swigCPtr, true);
  }

  protected void setM_size(int value) {
    HJSTREAMJNI.TK_User_Data_m_size_set(swigCPtr, this, value);
  }

  protected int getM_size() {
    return HJSTREAMJNI.TK_User_Data_m_size_get(swigCPtr, this);
  }

  protected void setM_buffer_size(int value) {
    HJSTREAMJNI.TK_User_Data_m_buffer_size_set(swigCPtr, this, value);
  }

  protected int getM_buffer_size() {
    return HJSTREAMJNI.TK_User_Data_m_buffer_size_get(swigCPtr, this);
  }

  protected void set_data(int size, byte[] bytes) {
    HJSTREAMJNI.TK_User_Data_set_data__SWIG_0(swigCPtr, this, size, bytes);
  }

  protected void set_data(int size) {
    HJSTREAMJNI.TK_User_Data_set_data__SWIG_1(swigCPtr, this, size);
  }

  public TK_User_Data() {
    this(HJSTREAMJNI.new_TK_User_Data(), true);
    HJSTREAMJNI.TK_User_Data_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public TK_Status Read(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_User_Data.class) ? HJSTREAMJNI.TK_User_Data_Read(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_User_Data_ReadSwigExplicitTK_User_Data(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Write(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_User_Data.class) ? HJSTREAMJNI.TK_User_Data_Write(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_User_Data_WriteSwigExplicitTK_User_Data(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    return TK_Status.swigToEnum((getClass() == TK_User_Data.class) ? HJSTREAMJNI.TK_User_Data_Clone(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)) : HJSTREAMJNI.TK_User_Data_CloneSwigExplicitTK_User_Data(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
  }

  public TK_Status ReadAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_User_Data_ReadAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status WriteAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_User_Data_WriteAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Execute(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_User_Data.class) ? HJSTREAMJNI.TK_User_Data_Execute(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_User_Data_ExecuteSwigExplicitTK_User_Data(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public void Reset() {
    if (getClass() == TK_User_Data.class) HJSTREAMJNI.TK_User_Data_Reset(swigCPtr, this); else HJSTREAMJNI.TK_User_Data_ResetSwigExplicitTK_User_Data(swigCPtr, this);
  }

  public void SetUserData(int size, byte[] bytes) {
    HJSTREAMJNI.TK_User_Data_SetUserData__SWIG_0(swigCPtr, this, size, bytes);
  }

  public void SetUserData(int size) {
    HJSTREAMJNI.TK_User_Data_SetUserData__SWIG_1(swigCPtr, this, size);
  }

  public int GetSize() {
    return HJSTREAMJNI.TK_User_Data_GetSize(swigCPtr, this);
  }

  public void Resize(int size) {
    HJSTREAMJNI.TK_User_Data_Resize(swigCPtr, this, size);
  }

  public void SetSize(int size) {
    HJSTREAMJNI.TK_User_Data_SetSize(swigCPtr, this, size);
  }

  public void GetUserData(byte[] values, int count) {
    HJSTREAMJNI.TK_User_Data_GetUserData(swigCPtr, this, values, count);
  }

}