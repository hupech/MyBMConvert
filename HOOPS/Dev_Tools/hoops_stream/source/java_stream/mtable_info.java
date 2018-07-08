/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class mtable_info {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected mtable_info(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(mtable_info obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_mtable_info(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public void get_mlengths(int[] values, int count) {
    HJSTREAMJNI.mtable_info_get_mlengths(swigCPtr, this, values, count);
  }

  public void get_m2stackoffsets(int[] values, int count) {
    HJSTREAMJNI.mtable_info_get_m2stackoffsets(swigCPtr, this, values, count);
  }

  public void get_m2gateoffsets(int[] values, int count) {
    HJSTREAMJNI.mtable_info_get_m2gateoffsets(swigCPtr, this, values, count);
  }

  public void get_dummies(int[] values, int count) {
    HJSTREAMJNI.mtable_info_get_dummies(swigCPtr, this, values, count);
  }

  public void get_patches(int[] values, int count) {
    HJSTREAMJNI.mtable_info_get_patches(swigCPtr, this, values, count);
  }

  public void setFlags(int value) {
    HJSTREAMJNI.mtable_info_flags_set(swigCPtr, this, value);
  }

  public int getFlags() {
    return HJSTREAMJNI.mtable_info_flags_get(swigCPtr, this);
  }

  public void setMlengths_used(int value) {
    HJSTREAMJNI.mtable_info_mlengths_used_set(swigCPtr, this, value);
  }

  public int getMlengths_used() {
    return HJSTREAMJNI.mtable_info_mlengths_used_get(swigCPtr, this);
  }

  public void setMlengths_allocated(int value) {
    HJSTREAMJNI.mtable_info_mlengths_allocated_set(swigCPtr, this, value);
  }

  public int getMlengths_allocated() {
    return HJSTREAMJNI.mtable_info_mlengths_allocated_get(swigCPtr, this);
  }

  public void setM2stackoffsets_used(int value) {
    HJSTREAMJNI.mtable_info_m2stackoffsets_used_set(swigCPtr, this, value);
  }

  public int getM2stackoffsets_used() {
    return HJSTREAMJNI.mtable_info_m2stackoffsets_used_get(swigCPtr, this);
  }

  public void setM2stackoffsets_allocated(int value) {
    HJSTREAMJNI.mtable_info_m2stackoffsets_allocated_set(swigCPtr, this, value);
  }

  public int getM2stackoffsets_allocated() {
    return HJSTREAMJNI.mtable_info_m2stackoffsets_allocated_get(swigCPtr, this);
  }

  public void setM2gateoffsets_used(int value) {
    HJSTREAMJNI.mtable_info_m2gateoffsets_used_set(swigCPtr, this, value);
  }

  public int getM2gateoffsets_used() {
    return HJSTREAMJNI.mtable_info_m2gateoffsets_used_get(swigCPtr, this);
  }

  public void setM2gateoffsets_allocated(int value) {
    HJSTREAMJNI.mtable_info_m2gateoffsets_allocated_set(swigCPtr, this, value);
  }

  public int getM2gateoffsets_allocated() {
    return HJSTREAMJNI.mtable_info_m2gateoffsets_allocated_get(swigCPtr, this);
  }

  public void setDummies_used(int value) {
    HJSTREAMJNI.mtable_info_dummies_used_set(swigCPtr, this, value);
  }

  public int getDummies_used() {
    return HJSTREAMJNI.mtable_info_dummies_used_get(swigCPtr, this);
  }

  public void setDummies_allocated(int value) {
    HJSTREAMJNI.mtable_info_dummies_allocated_set(swigCPtr, this, value);
  }

  public int getDummies_allocated() {
    return HJSTREAMJNI.mtable_info_dummies_allocated_get(swigCPtr, this);
  }

  public void setPatches_used(int value) {
    HJSTREAMJNI.mtable_info_patches_used_set(swigCPtr, this, value);
  }

  public int getPatches_used() {
    return HJSTREAMJNI.mtable_info_patches_used_get(swigCPtr, this);
  }

  public void setPatches_allocated(int value) {
    HJSTREAMJNI.mtable_info_patches_allocated_set(swigCPtr, this, value);
  }

  public int getPatches_allocated() {
    return HJSTREAMJNI.mtable_info_patches_allocated_get(swigCPtr, this);
  }

  public void setBounding(ET_Bounding value) {
    HJSTREAMJNI.mtable_info_bounding_set(swigCPtr, this, ET_Bounding.getCPtr(value), value);
  }

  public ET_Bounding getBounding() {
    long cPtr = HJSTREAMJNI.mtable_info_bounding_get(swigCPtr, this);
    return (cPtr == 0) ? null : new ET_Bounding(cPtr, false);
  }

  public void setX_quantization(int value) {
    HJSTREAMJNI.mtable_info_x_quantization_set(swigCPtr, this, value);
  }

  public int getX_quantization() {
    return HJSTREAMJNI.mtable_info_x_quantization_get(swigCPtr, this);
  }

  public void setY_quantization(int value) {
    HJSTREAMJNI.mtable_info_y_quantization_set(swigCPtr, this, value);
  }

  public int getY_quantization() {
    return HJSTREAMJNI.mtable_info_y_quantization_get(swigCPtr, this);
  }

  public void setZ_quantization(int value) {
    HJSTREAMJNI.mtable_info_z_quantization_set(swigCPtr, this, value);
  }

  public int getZ_quantization() {
    return HJSTREAMJNI.mtable_info_z_quantization_get(swigCPtr, this);
  }

  public void setX_quantization_normals(int value) {
    HJSTREAMJNI.mtable_info_x_quantization_normals_set(swigCPtr, this, value);
  }

  public int getX_quantization_normals() {
    return HJSTREAMJNI.mtable_info_x_quantization_normals_get(swigCPtr, this);
  }

  public void setY_quantization_normals(int value) {
    HJSTREAMJNI.mtable_info_y_quantization_normals_set(swigCPtr, this, value);
  }

  public int getY_quantization_normals() {
    return HJSTREAMJNI.mtable_info_y_quantization_normals_get(swigCPtr, this);
  }

  public void setZ_quantization_normals(int value) {
    HJSTREAMJNI.mtable_info_z_quantization_normals_set(swigCPtr, this, value);
  }

  public int getZ_quantization_normals() {
    return HJSTREAMJNI.mtable_info_z_quantization_normals_get(swigCPtr, this);
  }

  public mtable_info() {
    this(HJSTREAMJNI.new_mtable_info(), true);
  }

}
