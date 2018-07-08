/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class TK_Spot_Light extends BBaseOpcodeHandler {
  private long swigCPtr;

  protected TK_Spot_Light(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGTK_Spot_LightUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(TK_Spot_Light obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_TK_Spot_Light(swigCPtr);
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
    HJSTREAMJNI.TK_Spot_Light_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJSTREAMJNI.TK_Spot_Light_change_ownership(this, swigCPtr, true);
  }

  protected void setM_position(SWIGTYPE_p_float value) {
    HJSTREAMJNI.TK_Spot_Light_m_position_set(swigCPtr, this, SWIGTYPE_p_float.getCPtr(value));
  }

  protected SWIGTYPE_p_float getM_position() {
    long cPtr = HJSTREAMJNI.TK_Spot_Light_m_position_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_float(cPtr, false);
  }

  protected void setM_target(SWIGTYPE_p_float value) {
    HJSTREAMJNI.TK_Spot_Light_m_target_set(swigCPtr, this, SWIGTYPE_p_float.getCPtr(value));
  }

  protected SWIGTYPE_p_float getM_target() {
    long cPtr = HJSTREAMJNI.TK_Spot_Light_m_target_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_float(cPtr, false);
  }

  protected void setM_dposition(SWIGTYPE_p_double value) {
    HJSTREAMJNI.TK_Spot_Light_m_dposition_set(swigCPtr, this, SWIGTYPE_p_double.getCPtr(value));
  }

  protected SWIGTYPE_p_double getM_dposition() {
    long cPtr = HJSTREAMJNI.TK_Spot_Light_m_dposition_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_double(cPtr, false);
  }

  protected void setM_dtarget(SWIGTYPE_p_double value) {
    HJSTREAMJNI.TK_Spot_Light_m_dtarget_set(swigCPtr, this, SWIGTYPE_p_double.getCPtr(value));
  }

  protected SWIGTYPE_p_double getM_dtarget() {
    long cPtr = HJSTREAMJNI.TK_Spot_Light_m_dtarget_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_double(cPtr, false);
  }

  protected void setM_outer(float value) {
    HJSTREAMJNI.TK_Spot_Light_m_outer_set(swigCPtr, this, value);
  }

  protected float getM_outer() {
    return HJSTREAMJNI.TK_Spot_Light_m_outer_get(swigCPtr, this);
  }

  protected void setM_inner(float value) {
    HJSTREAMJNI.TK_Spot_Light_m_inner_set(swigCPtr, this, value);
  }

  protected float getM_inner() {
    return HJSTREAMJNI.TK_Spot_Light_m_inner_get(swigCPtr, this);
  }

  protected void setM_concentration(float value) {
    HJSTREAMJNI.TK_Spot_Light_m_concentration_set(swigCPtr, this, value);
  }

  protected float getM_concentration() {
    return HJSTREAMJNI.TK_Spot_Light_m_concentration_get(swigCPtr, this);
  }

  protected void setM_options(char value) {
    HJSTREAMJNI.TK_Spot_Light_m_options_set(swigCPtr, this, value);
  }

  protected char getM_options() {
    return HJSTREAMJNI.TK_Spot_Light_m_options_get(swigCPtr, this);
  }

  public TK_Spot_Light() {
    this(HJSTREAMJNI.new_TK_Spot_Light(), true);
    HJSTREAMJNI.TK_Spot_Light_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public TK_Status Read(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_Spot_Light.class) ? HJSTREAMJNI.TK_Spot_Light_Read(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_Spot_Light_ReadSwigExplicitTK_Spot_Light(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Write(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_Spot_Light.class) ? HJSTREAMJNI.TK_Spot_Light_Write(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_Spot_Light_WriteSwigExplicitTK_Spot_Light(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    return TK_Status.swigToEnum((getClass() == TK_Spot_Light.class) ? HJSTREAMJNI.TK_Spot_Light_Clone(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)) : HJSTREAMJNI.TK_Spot_Light_CloneSwigExplicitTK_Spot_Light(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
  }

  public TK_Status ReadAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Spot_Light_ReadAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status WriteAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Spot_Light_WriteAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public void SetPosition(float x, float y, float z) {
    HJSTREAMJNI.TK_Spot_Light_SetPosition__SWIG_0(swigCPtr, this, x, y, z);
  }

  public void SetPosition(float[] p) {
    HJSTREAMJNI.TK_Spot_Light_SetPosition__SWIG_1(swigCPtr, this, p);
  }

  public void SetDPosition(double x, double y, double z) {
    HJSTREAMJNI.TK_Spot_Light_SetDPosition__SWIG_0(swigCPtr, this, x, y, z);
  }

  public void SetDPosition(double[] p) {
    HJSTREAMJNI.TK_Spot_Light_SetDPosition__SWIG_1(swigCPtr, this, p);
  }

  public double[] GetDPosition() {return HJSTREAMJNI.TK_Spot_Light_GetDPosition(swigCPtr, this);}

  public void SetTarget(float x, float y, float z) {
    HJSTREAMJNI.TK_Spot_Light_SetTarget__SWIG_0(swigCPtr, this, x, y, z);
  }

  public void SetTarget(float[] t) {
    HJSTREAMJNI.TK_Spot_Light_SetTarget__SWIG_1(swigCPtr, this, t);
  }

  public void SetDTarget(double x, double y, double z) {
    HJSTREAMJNI.TK_Spot_Light_SetDTarget__SWIG_0(swigCPtr, this, x, y, z);
  }

  public void SetDTarget(double[] t) {
    HJSTREAMJNI.TK_Spot_Light_SetDTarget__SWIG_1(swigCPtr, this, t);
  }

  public double[] GetDTarget() {return HJSTREAMJNI.TK_Spot_Light_GetDTarget(swigCPtr, this);}

  public void SetOuter(float o) {
    HJSTREAMJNI.TK_Spot_Light_SetOuter(swigCPtr, this, o);
  }

  public float GetOuter() {
    return HJSTREAMJNI.TK_Spot_Light_GetOuter(swigCPtr, this);
  }

  public void SetInner(float i) {
    HJSTREAMJNI.TK_Spot_Light_SetInner(swigCPtr, this, i);
  }

  public float GetInner() {
    return HJSTREAMJNI.TK_Spot_Light_GetInner(swigCPtr, this);
  }

  public void SetConcentration(float c) {
    HJSTREAMJNI.TK_Spot_Light_SetConcentration(swigCPtr, this, c);
  }

  public float GetConcentration() {
    return HJSTREAMJNI.TK_Spot_Light_GetConcentration(swigCPtr, this);
  }

  public void SetOptions(int o) {
    HJSTREAMJNI.TK_Spot_Light_SetOptions(swigCPtr, this, o);
  }

  public int GetOptions() {
    return HJSTREAMJNI.TK_Spot_Light_GetOptions(swigCPtr, this);
  }

}
