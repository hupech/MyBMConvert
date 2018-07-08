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


public class Lock_Masks : BBaseOpcodeHandler {
  private HandleRef swigCPtr;

  public Lock_Masks(IntPtr cPtr, bool cMemoryOwn) : base(HCSSTREAMPINVOKE.Lock_MasksUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(Lock_Masks obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Lock_Masks() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSSTREAMPINVOKE.delete_Lock_Masks(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public int mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_mask_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.Lock_Masks_mask_get(swigCPtr);
      return ret;
    } 
  }

  public int value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_value_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.Lock_Masks_value_get(swigCPtr);
      return ret;
    } 
  }

  public int color_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_mask_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.Lock_Masks_color_mask_get(swigCPtr);
      return ret;
    } 
  }

  public int color_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_value_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.Lock_Masks_color_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_face_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_face_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_face_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_face_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_face_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_face_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_edge_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_edge_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_edge_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_edge_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_edge_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_edge_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_line_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_line_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_line_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_line_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_line_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_line_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_marker_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_marker_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_marker_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_marker_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_marker_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_marker_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_text_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_text_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_text_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_text_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_text_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_text_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_window_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_window_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_window_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_window_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_window_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_window_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_face_contrast_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_face_contrast_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_face_contrast_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_face_contrast_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_face_contrast_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_face_contrast_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_window_contrast_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_window_contrast_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_window_contrast_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_window_contrast_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_window_contrast_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_window_contrast_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_back_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_back_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_back_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_back_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_back_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_back_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_vertex_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_vertex_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_vertex_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_vertex_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_vertex_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_vertex_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_edge_contrast_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_edge_contrast_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_edge_contrast_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_edge_contrast_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_edge_contrast_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_edge_contrast_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_line_contrast_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_line_contrast_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_line_contrast_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_line_contrast_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_line_contrast_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_line_contrast_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_marker_contrast_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_marker_contrast_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_marker_contrast_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_marker_contrast_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_marker_contrast_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_marker_contrast_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_vertex_contrast_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_vertex_contrast_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_vertex_contrast_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_vertex_contrast_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_vertex_contrast_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_vertex_contrast_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_text_contrast_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_text_contrast_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_text_contrast_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_text_contrast_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_text_contrast_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_text_contrast_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_simple_reflection_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_simple_reflection_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_simple_reflection_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_simple_reflection_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_simple_reflection_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_simple_reflection_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_cut_face_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_cut_face_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_cut_face_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_cut_face_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_cut_face_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_cut_face_value_get(swigCPtr);
      return ret;
    } 
  }

  public short color_cut_edge_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_cut_edge_mask_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_cut_edge_mask_get(swigCPtr);
      return ret;
    } 
  }

  public short color_cut_edge_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_color_cut_edge_value_set(swigCPtr, value);
    } 
    get {
      short ret = HCSSTREAMPINVOKE.Lock_Masks_color_cut_edge_value_get(swigCPtr);
      return ret;
    } 
  }

  public int visibility_mask {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_visibility_mask_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.Lock_Masks_visibility_mask_get(swigCPtr);
      return ret;
    } 
  }

  public int visibility_value {
    set {
      HCSSTREAMPINVOKE.Lock_Masks_visibility_value_set(swigCPtr, value);
    } 
    get {
      int ret = HCSSTREAMPINVOKE.Lock_Masks_visibility_value_get(swigCPtr);
      return ret;
    } 
  }

  public Lock_Masks() : this(HCSSTREAMPINVOKE.new_Lock_Masks(), true) {
  }

  public override TK_Status Read(BStreamFileToolkit arg0) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.Lock_Masks_Read__SWIG_0(swigCPtr, BStreamFileToolkit.getCPtr(arg0));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override TK_Status Write(BStreamFileToolkit arg0) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.Lock_Masks_Write__SWIG_0(swigCPtr, BStreamFileToolkit.getCPtr(arg0));
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TK_Status Read(BStreamFileToolkit tk, bool mask_only) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.Lock_Masks_Read__SWIG_1(swigCPtr, BStreamFileToolkit.getCPtr(tk), mask_only);
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public TK_Status Write(BStreamFileToolkit tk, bool mask_only) {
    TK_Status ret = (TK_Status)HCSSTREAMPINVOKE.Lock_Masks_Write__SWIG_1(swigCPtr, BStreamFileToolkit.getCPtr(tk), mask_only);
    if (HCSSTREAMPINVOKE.SWIGPendingException.Pending) throw HCSSTREAMPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void init() {
    HCSSTREAMPINVOKE.Lock_Masks_init(swigCPtr);
  }

  public void set_color() {
    HCSSTREAMPINVOKE.Lock_Masks_set_color(swigCPtr);
  }

}