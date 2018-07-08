/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

#if _M_X64
using HLONG = System.Int64;
using ID_Key = System.Int64;
#else
using HLONG = System.Int32;
using ID_Key = System.Int32;
#endif


public class BVarStream : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public BVarStream(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(BVarStream obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BVarStream() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_BVarStream(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public BVarStream() : this(HCSSTREAMPINVOKE.new_BVarStream(), true) {
  }

  public void InitWrite(int size, IntPtr pointer) {
    HCSSTREAMPINVOKE.BVarStream_InitWrite(swigCPtr, size, pointer);
  }

  public void InitRead(int size, IntPtr pointer) {
    HCSSTREAMPINVOKE.BVarStream_InitRead(swigCPtr, size, pointer);
  }

  public int Put(int[] numbits_array, int val) {
    int ret = HCSSTREAMPINVOKE.BVarStream_Put(swigCPtr, numbits_array, val);
    return ret;
  }

  public int Get(int[] numbits_array) {
    int ret = HCSSTREAMPINVOKE.BVarStream_Get(swigCPtr, numbits_array);
    return ret;
  }

}