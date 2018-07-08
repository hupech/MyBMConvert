/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HByteStream {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected HByteStream(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(HByteStream obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_HByteStream(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public HByteStream(int size, byte[] cptr, int bpv) {
    this(HJSTREAMJNI.new_HByteStream__SWIG_0(size, cptr, bpv), true);
  }

  public HByteStream() {
    this(HJSTREAMJNI.new_HByteStream__SWIG_1(), true);
  }

  public void put(int value) {
    HJSTREAMJNI.HByteStream_put(swigCPtr, this, value);
  }

  public void get(int[] value) {
    HJSTREAMJNI.HByteStream_get(swigCPtr, this, value);
  }

}
