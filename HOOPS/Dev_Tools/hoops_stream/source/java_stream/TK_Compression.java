/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class TK_Compression extends BBaseOpcodeHandler {
  private long swigCPtr;

  protected TK_Compression(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGTK_CompressionUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(TK_Compression obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_TK_Compression(swigCPtr);
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
    HJSTREAMJNI.TK_Compression_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJSTREAMJNI.TK_Compression_change_ownership(this, swigCPtr, true);
  }

  public TK_Compression(char opcode) {
    this(HJSTREAMJNI.new_TK_Compression(opcode), true);
    HJSTREAMJNI.TK_Compression_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public TK_Status Read(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_Compression.class) ? HJSTREAMJNI.TK_Compression_Read(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_Compression_ReadSwigExplicitTK_Compression(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Write(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_Compression.class) ? HJSTREAMJNI.TK_Compression_Write(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_Compression_WriteSwigExplicitTK_Compression(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status ReadAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Compression_ReadAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status WriteAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Compression_WriteAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Execute(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_Compression.class) ? HJSTREAMJNI.TK_Compression_Execute(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_Compression_ExecuteSwigExplicitTK_Compression(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status ExecuteAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Compression_ExecuteAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key, int variant) {
    return TK_Status.swigToEnum((getClass() == TK_Compression.class) ? HJSTREAMJNI.TK_Compression_Interpret__SWIG_0(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, variant) : HJSTREAMJNI.TK_Compression_InterpretSwigExplicitTK_Compression__SWIG_0(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, variant));
  }

  public TK_Status Interpret(BStreamFileToolkit tk, int key, String special) {
    return TK_Status.swigToEnum((getClass() == TK_Compression.class) ? HJSTREAMJNI.TK_Compression_Interpret__SWIG_1(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, special) : HJSTREAMJNI.TK_Compression_InterpretSwigExplicitTK_Compression__SWIG_1(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, special));
  }

}
