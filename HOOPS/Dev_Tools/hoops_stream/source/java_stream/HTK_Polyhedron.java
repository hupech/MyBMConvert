/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HTK_Polyhedron extends TK_Polyhedron {
  private long swigCPtr;

  protected HTK_Polyhedron(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGHTK_PolyhedronUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(HTK_Polyhedron obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_HTK_Polyhedron(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public TK_Status HExecute(BStreamFileToolkit tk, int mesh_columns) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Polyhedron_HExecute__SWIG_0(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, mesh_columns));
  }

  public TK_Status HExecute(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Polyhedron_HExecute__SWIG_1(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status HInterpret(BStreamFileToolkit tk, int key, int lod, int mesh_columns) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Polyhedron_HInterpret__SWIG_0(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, lod, mesh_columns));
  }

  public TK_Status HInterpret(BStreamFileToolkit tk, int key, int lod) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Polyhedron_HInterpret__SWIG_1(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key, lod));
  }

  public TK_Status HInterpret(BStreamFileToolkit tk, int key) {
    return TK_Status.swigToEnum(HJSTREAMJNI.HTK_Polyhedron_HInterpret__SWIG_2(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, key));
  }

  public boolean match_points(Recorded_Instance instance, float[] instance_points) {
    return HJSTREAMJNI.HTK_Polyhedron_match_points(swigCPtr, this, Recorded_Instance.getCPtr(instance), instance, instance_points);
  }

  public boolean match_attributes(Recorded_Instance instance) {
    return HJSTREAMJNI.HTK_Polyhedron_match_attributes(swigCPtr, this, Recorded_Instance.getCPtr(instance), instance);
  }

}
