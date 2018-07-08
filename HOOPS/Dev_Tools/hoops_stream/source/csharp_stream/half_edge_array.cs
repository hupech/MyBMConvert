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


public class half_edge_array : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public half_edge_array(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(half_edge_array obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~half_edge_array() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_half_edge_array(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public half_edge edges {
    set {
      HCSSTREAMPINVOKE.half_edge_array_edges_set(swigCPtr, half_edge.getCPtr(value));
    } 
    get {
      IntPtr cPtr = HCSSTREAMPINVOKE.half_edge_array_edges_get(swigCPtr);
      half_edge ret = (cPtr == IntPtr.Zero) ? null : new half_edge(cPtr, false);
      return ret;
    } 
  }

  public int allocated {
    set {
      HCSSTREAMPINVOKE.half_edge_array_allocated_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.half_edge_array_allocated_get(swigCPtr);
      return ret;
    } 
  }

  public int used {
    set {
      HCSSTREAMPINVOKE.half_edge_array_used_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.half_edge_array_used_get(swigCPtr);
      return ret;
    } 
  }

  public IntPtr visitations {
   set {
	 HCSSTREAMPINVOKE.half_edge_array_visitations_set(swigCPtr, value);
   } 
   get {
	 return HCSSTREAMPINVOKE.half_edge_array_visitations_get(swigCPtr);
   } 
  }

  public int visitations_used {
    set {
      HCSSTREAMPINVOKE.half_edge_array_visitations_used_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.half_edge_array_visitations_used_get(swigCPtr);
      return ret;
    } 
  }

  public half_edge_array() : this(HCSSTREAMPINVOKE.new_half_edge_array(), true) {
  }

}
