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
using MVO_POINTER_SIZED_INT = System.Int64;
using MVO_POINTER_SIZED_UINT = System.UInt64;
using ID_Key = System.Int64;
#else
using MVO_POINTER_SIZED_INT = System.Int32;
using MVO_POINTER_SIZED_UINT = System.UInt32;
using ID_Key = System.Int32;
#endif


public class HOldSelItem : HSelectionItem {
  private HandleRef swigCPtr;

  public HOldSelItem(IntPtr cPtr, bool cMemoryOwn) : base(HCSMVOPINVOKE.HOldSelItemUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HOldSelItem obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~HOldSelItem() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSMVOPINVOKE.delete_HOldSelItem(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public HOldSelItem(MVO_POINTER_SIZED_INT key, HSelectionSet selection_set, string selection_path, MVO_POINTER_SIZED_INT include_key, MVO_POINTER_SIZED_INT includer_key) : this(HCSMVOPINVOKE.new_HOldSelItem(key, HSelectionSet.getCPtr(selection_set), selection_path, include_key, includer_key), true) {
  }

  public override string GetName() {
    string ret = HCSMVOPINVOKE.HOldSelItem_GetName(swigCPtr);
    return ret;
  }

  public override bool Equals(HSelectionItem i2) {
    bool ret = HCSMVOPINVOKE.HOldSelItem_Equals(swigCPtr, HSelectionItem.getCPtr(i2));
    return ret;
  }

  public override bool Highlight() {
    bool ret = HCSMVOPINVOKE.HOldSelItem_Highlight(swigCPtr);
    return ret;
  }

  public override bool UnHighlight() {
    bool ret = HCSMVOPINVOKE.HOldSelItem_UnHighlight(swigCPtr);
    return ret;
  }

  public override bool IsHighlighted() {
    bool ret = HCSMVOPINVOKE.HOldSelItem_IsHighlighted(swigCPtr);
    return ret;
  }

  public override bool Delete() {
    bool ret = HCSMVOPINVOKE.HOldSelItem_Delete(swigCPtr);
    return ret;
  }

  public override bool IsInstanced() {
    bool ret = HCSMVOPINVOKE.HOldSelItem_IsInstanced(swigCPtr);
    return ret;
  }

  public override int GetIncludeCount() {
    int ret = HCSMVOPINVOKE.HOldSelItem_GetIncludeCount(swigCPtr);
    return ret;
  }

  public override IntPtr GetIncludeKeys() {return HCSMVOPINVOKE.HOldSelItem_GetIncludeKeys__SWIG_0(swigCPtr);}

  public override void GetIncludeKeys(MVO_POINTER_SIZED_INT[] arg0) {
    HCSMVOPINVOKE.HOldSelItem_GetIncludeKeys__SWIG_1(swigCPtr, arg0);
  }

  public override bool QueryIncludeDependency(MVO_POINTER_SIZED_INT include_key, MVO_POINTER_SIZED_INT[] ret_dependent_key) {
    bool ret = HCSMVOPINVOKE.HOldSelItem_QueryIncludeDependency(swigCPtr, include_key, ret_dependent_key);
    return ret;
  }

  public override bool UpdateIncludeDependency(MVO_POINTER_SIZED_INT include_key, MVO_POINTER_SIZED_INT dependent_key, MVO_POINTER_SIZED_INT replacement_key) {
    bool ret = HCSMVOPINVOKE.HOldSelItem_UpdateIncludeDependency(swigCPtr, include_key, dependent_key, replacement_key);
    return ret;
  }

}