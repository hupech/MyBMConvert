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


public class Internal_Translator : BControlledMemoryObject {
  private HandleRef swigCPtr;

  internal Internal_Translator(IntPtr cPtr, bool cMemoryOwn) : base(HCSBSTREAMPINVOKE.Internal_TranslatorUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Internal_Translator obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Internal_Translator() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSBSTREAMPINVOKE.delete_Internal_Translator(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Internal_Translator() : this(HCSBSTREAMPINVOKE.new_Internal_Translator(), true) {
  }

  public TK_Status add_pair(int index, int key) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_add_pair(swigCPtr, index, key);
    return ret;
  }

  public TK_Status add_variant(int key, int variant, int value1, int value2) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_add_variant__SWIG_0(swigCPtr, key, variant, value1, value2);
    return ret;
  }

  public TK_Status add_variant(int key, int variant, int value1) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_add_variant__SWIG_1(swigCPtr, key, variant, value1);
    return ret;
  }

  public TK_Status add_bounds(int key, float[] bounds) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_add_bounds(swigCPtr, key, bounds);
    return ret;
  }

  public TK_Status index_to_key(int index, int[] key) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_index_to_key(swigCPtr, index, key);
    return ret;
  }

  public TK_Status key_to_index(int key, int[] index) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_key_to_index(swigCPtr, key, index);
    return ret;
  }

  public TK_Status key_variant_offset(int key, int variant, int[] offset, int[] length, int[] index) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_key_variant_offset__SWIG_0(swigCPtr, key, variant, offset, length, index);
    return ret;
  }

  public TK_Status key_bounds(int key, float[] bounds) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_key_bounds(swigCPtr, key, bounds);
    return ret;
  }

  public int used() {
    int ret = HCSBSTREAMPINVOKE.Internal_Translator_used(swigCPtr);
    return ret;
  }

  public void clean() {
    HCSBSTREAMPINVOKE.Internal_Translator_clean(swigCPtr);
  }

  public TK_Status key_variant_offset(int key, int variant, int[] offset) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_key_variant_offset__SWIG_1(swigCPtr, key, variant, offset);
    return ret;
  }

  public TK_Status key_variant_offset(int key, int variant, int[] offset, int[] length) {
    TK_Status ret = (TK_Status)HCSBSTREAMPINVOKE.Internal_Translator_key_variant_offset__SWIG_2(swigCPtr, key, variant, offset, length);
    return ret;
  }

}
