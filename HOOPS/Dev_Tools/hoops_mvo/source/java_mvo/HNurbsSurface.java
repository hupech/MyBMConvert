/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HNurbsSurface {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  public HNurbsSurface(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  public static long getCPtr(HNurbsSurface obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HNurbsSurface(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public HNurbsSurface() {
    this(HJMVOJNI.new_HNurbsSurface(), true);
  }

  public void Init(long key) {
    HJMVOJNI.HNurbsSurface_Init__SWIG_0(swigCPtr, this, key);
  }

  public long Init(HPoint center, HPoint axis, int num_u_vertices, int num_v_vertices, int degree, int tesselation_level, float distance, HSurfaceType stype) {return HJMVOJNI.HNurbsSurface_Init__SWIG_1(swigCPtr, this, HPoint.getCPtr(center), center, HPoint.getCPtr(axis), axis, num_u_vertices, num_v_vertices, degree, tesselation_level, distance, stype.swigValue());}

  public void Recalculate() {
    HJMVOJNI.HNurbsSurface_Recalculate(swigCPtr, this);
  }

  public long GetKey() {return HJMVOJNI.HNurbsSurface_GetKey(swigCPtr, this);}

  public void DisplayVertices() {
    HJMVOJNI.HNurbsSurface_DisplayVertices(swigCPtr, this);
  }

  public void HideVertices() {
    HJMVOJNI.HNurbsSurface_HideVertices(swigCPtr, this);
  }

  public void EnableSelectability() {
    HJMVOJNI.HNurbsSurface_EnableSelectability(swigCPtr, this);
  }

  public void DisableSelectability() {
    HJMVOJNI.HNurbsSurface_DisableSelectability(swigCPtr, this);
  }

  public void UpdateVertex(int vertexnum, float x, float y, float z) {
    HJMVOJNI.HNurbsSurface_UpdateVertex(swigCPtr, this, vertexnum, x, y, z);
  }

  public void ShowVertex(int vertexnum, HPoint v) {
    HJMVOJNI.HNurbsSurface_ShowVertex(swigCPtr, this, vertexnum, HPoint.getCPtr(v), v);
  }

  public void CreateDefaultVertices(HPoint center, HPoint axis) {
    HJMVOJNI.HNurbsSurface_CreateDefaultVertices(swigCPtr, this, HPoint.getCPtr(center), center, HPoint.getCPtr(axis), axis);
  }

  public long GetSurfaceMeshKey() {return HJMVOJNI.HNurbsSurface_GetSurfaceMeshKey(swigCPtr, this);}

}