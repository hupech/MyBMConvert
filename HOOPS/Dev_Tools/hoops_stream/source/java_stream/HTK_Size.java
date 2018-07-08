/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HTK_Size extends TK_Size {
  private long swigCPtr;

  protected HTK_Size(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGHTK_SizeUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(HTK_Size obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_HTK_Size(swigCPtr);
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
    HJSTREAMJNI.HTK_Size_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJSTREAMJNI.HTK_Size_change_ownership(this, swigCPtr, true);
  }

  public HTK_Size(short opcode) {
    this(HJSTREAMJNI.new_HTK_Size(opcode), true);
    HJSTREAMJNI.HTK_Size_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public TK_Status Execute(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == HTK_Size.class) ? HJSTREAMJNI.HTK_Size_Execute(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.HTK_Size_ExecuteSwigExplicitHTK_Size(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key, int variant) {
    return TK_Status.swigToEnum((getClass() == HTK_Size.class) ? HJSTREAMJNI.HTK_Size_Interpret__SWIG_0(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, variant) : HJSTREAMJNI.HTK_Size_InterpretSwigExplicitHTK_Size__SWIG_0(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, variant));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key) {
    return TK_Status.swigToEnum((getClass() == HTK_Size.class) ? HJSTREAMJNI.HTK_Size_Interpret__SWIG_1(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key) : HJSTREAMJNI.HTK_Size_InterpretSwigExplicitHTK_Size__SWIG_1(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key, String special) {
    return TK_Status.swigToEnum((getClass() == HTK_Size.class) ? HJSTREAMJNI.HTK_Size_Interpret__SWIG_2(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, special) : HJSTREAMJNI.HTK_Size_InterpretSwigExplicitHTK_Size__SWIG_2(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, special));
  }

  public TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    return TK_Status.swigToEnum((getClass() == HTK_Size.class) ? HJSTREAMJNI.HTK_Size_Clone(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)) : HJSTREAMJNI.HTK_Size_CloneSwigExplicitHTK_Size(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
  }

}
