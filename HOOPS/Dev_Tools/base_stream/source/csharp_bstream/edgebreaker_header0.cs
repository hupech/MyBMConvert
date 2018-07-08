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
#else
using HLONG = System.Int32;
#endif


public class edgebreaker_header0 : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal edgebreaker_header0(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(edgebreaker_header0 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~edgebreaker_header0() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSBSTREAMPINVOKE.delete_edgebreaker_header0(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public char scheme {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_scheme_set(swigCPtr, value);
    } 
    get {
      char ret = HCSBSTREAMPINVOKE.edgebreaker_header0_scheme_get(swigCPtr);
      return ret;
    } 
  }

  public char mtable_scheme {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_mtable_scheme_set(swigCPtr, value);
    } 
    get {
      char ret = HCSBSTREAMPINVOKE.edgebreaker_header0_mtable_scheme_get(swigCPtr);
      return ret;
    } 
  }

  public char points_scheme {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_points_scheme_set(swigCPtr, value);
    } 
    get {
      char ret = HCSBSTREAMPINVOKE.edgebreaker_header0_points_scheme_get(swigCPtr);
      return ret;
    } 
  }

  public char normals_scheme {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_normals_scheme_set(swigCPtr, value);
    } 
    get {
      char ret = HCSBSTREAMPINVOKE.edgebreaker_header0_normals_scheme_get(swigCPtr);
      return ret;
    } 
  }

  public int opslen {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_opslen_set(swigCPtr, value);
    } 
    get {
      int ret = HCSBSTREAMPINVOKE.edgebreaker_header0_opslen_get(swigCPtr);
      return ret;
    } 
  }

  public int mtablelen {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_mtablelen_set(swigCPtr, value);
    } 
    get {
      int ret = HCSBSTREAMPINVOKE.edgebreaker_header0_mtablelen_get(swigCPtr);
      return ret;
    } 
  }

  public int pointslen {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_pointslen_set(swigCPtr, value);
    } 
    get {
      int ret = HCSBSTREAMPINVOKE.edgebreaker_header0_pointslen_get(swigCPtr);
      return ret;
    } 
  }

  public int pcount {
    set {
      HCSBSTREAMPINVOKE.edgebreaker_header0_pcount_set(swigCPtr, value);
    } 
    get {
      int ret = HCSBSTREAMPINVOKE.edgebreaker_header0_pcount_get(swigCPtr);
      return ret;
    } 
  }

  public edgebreaker_header0() : this(HCSBSTREAMPINVOKE.new_edgebreaker_header0(), true) {
  }

}