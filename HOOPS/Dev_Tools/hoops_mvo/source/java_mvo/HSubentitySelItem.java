/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HSubentitySelItem extends HSmartSelItem {
  private long swigCPtr;

  public HSubentitySelItem(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HSubentitySelItem_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HSubentitySelItem obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HSubentitySelItem(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public HSubentitySelItem(long key, HSelectionSet selection_set, int incl_count, long[] incl_keys, int face_count, int[] faces, int vertex_count, int[] vertex1, int[] vertex2, boolean highlight_faces, boolean highlight_vertices, boolean highlight_edges, boolean maintain_maps) {
    this(HJMVOJNI.new_HSubentitySelItem__SWIG_0(key, HSelectionSet.getCPtr(selection_set), selection_set, incl_count, incl_keys, face_count, faces, vertex_count, vertex1, vertex2, highlight_faces, highlight_vertices, highlight_edges, maintain_maps), true);
  }

  public HSubentitySelItem(long key, HSelectionSet selection_set, int incl_count, long[] incl_keys, int face_count, int[] faces, int vertex_count, int[] vertex1, int[] vertex2, boolean highlight_faces, boolean highlight_vertices, boolean highlight_edges) {
    this(HJMVOJNI.new_HSubentitySelItem__SWIG_1(key, HSelectionSet.getCPtr(selection_set), selection_set, incl_count, incl_keys, face_count, faces, vertex_count, vertex1, vertex2, highlight_faces, highlight_vertices, highlight_edges), true);
  }

  public HSubentitySelItem(long key, HSelectionSet selection_set, int incl_count, long[] incl_keys, int face_count, int[] faces, int vertex_count, int[] vertex1, int[] vertex2, boolean highlight_faces, boolean highlight_vertices) {
    this(HJMVOJNI.new_HSubentitySelItem__SWIG_2(key, HSelectionSet.getCPtr(selection_set), selection_set, incl_count, incl_keys, face_count, faces, vertex_count, vertex1, vertex2, highlight_faces, highlight_vertices), true);
  }

  public HSubentitySelItem(long key, HSelectionSet selection_set, int incl_count, long[] incl_keys, int face_count, int[] faces, int vertex_count, int[] vertex1, int[] vertex2, boolean highlight_faces) {
    this(HJMVOJNI.new_HSubentitySelItem__SWIG_3(key, HSelectionSet.getCPtr(selection_set), selection_set, incl_count, incl_keys, face_count, faces, vertex_count, vertex1, vertex2, highlight_faces), true);
  }

  public HSubentitySelItem(long key, HSelectionSet selection_set, int incl_count, long[] incl_keys, int face_count, int[] faces, int vertex_count, int[] vertex1, int[] vertex2) {
    this(HJMVOJNI.new_HSubentitySelItem__SWIG_4(key, HSelectionSet.getCPtr(selection_set), selection_set, incl_count, incl_keys, face_count, faces, vertex_count, vertex1, vertex2), true);
  }

  public String GetName() {
    return HJMVOJNI.HSubentitySelItem_GetName(swigCPtr, this);
  }

  public boolean Equals(HSelectionItem i2) {
    return HJMVOJNI.HSubentitySelItem_Equals(swigCPtr, this, HSelectionItem.getCPtr(i2), i2);
  }

  public boolean Similar(HSelectionItem i2) {
    return HJMVOJNI.HSubentitySelItem_Similar(swigCPtr, this, HSelectionItem.getCPtr(i2), i2);
  }

  public boolean Highlight() {
    return HJMVOJNI.HSubentitySelItem_Highlight(swigCPtr, this);
  }

  public boolean UnHighlight() {
    return HJMVOJNI.HSubentitySelItem_UnHighlight__SWIG_0(swigCPtr, this);
  }

  public boolean UnHighlight(HSubentitySelItem remove_sel) {
    return HJMVOJNI.HSubentitySelItem_UnHighlight__SWIG_1(swigCPtr, this, HSubentitySelItem.getCPtr(remove_sel), remove_sel);
  }

  public boolean IsEmpty() {
    return HJMVOJNI.HSubentitySelItem_IsEmpty(swigCPtr, this);
  }

  public boolean Delete() {
    return HJMVOJNI.HSubentitySelItem_Delete(swigCPtr, this);
  }

  public int GetFaceCount() {
    return HJMVOJNI.HSubentitySelItem_GetFaceCount(swigCPtr, this);
  }

  public void GetFaces(int[] faces) {
    HJMVOJNI.HSubentitySelItem_GetFaces(swigCPtr, this, faces);
  }

  public int GetVertexCount() {
    return HJMVOJNI.HSubentitySelItem_GetVertexCount(swigCPtr, this);
  }

  public void GetVertices(int[] vertex1, int[] vertex2) {
    HJMVOJNI.HSubentitySelItem_GetVertices(swigCPtr, this, vertex1, vertex2);
  }

  public boolean MaintainMaps() {
    return HJMVOJNI.HSubentitySelItem_MaintainMaps__SWIG_0(swigCPtr, this);
  }

  public void MaintainMaps(boolean maintain_maps) {
    HJMVOJNI.HSubentitySelItem_MaintainMaps__SWIG_1(swigCPtr, this, maintain_maps);
  }

  public void GetMapCounts(int[] face_map_count, int[] vertex_map_count) {
    HJMVOJNI.HSubentitySelItem_GetMapCounts(swigCPtr, this, face_map_count, vertex_map_count);
  }

  public void GetMaps(int[] face_map, int[] vertex_map) {
    HJMVOJNI.HSubentitySelItem_GetMaps(swigCPtr, this, face_map, vertex_map);
  }

  public void MergeMaps(HSubentitySelItem that) {
    HJMVOJNI.HSubentitySelItem_MergeMaps(swigCPtr, this, HSubentitySelItem.getCPtr(that), that);
  }

}