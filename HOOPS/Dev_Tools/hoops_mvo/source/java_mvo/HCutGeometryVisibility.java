/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public final class HCutGeometryVisibility {
  public final static HCutGeometryVisibility HCutGeometryVisibilityNone = new HCutGeometryVisibility("HCutGeometryVisibilityNone", HJMVOJNI.HCutGeometryVisibilityNone_get());
  public final static HCutGeometryVisibility HCutGeometryVisibilityFaces = new HCutGeometryVisibility("HCutGeometryVisibilityFaces", HJMVOJNI.HCutGeometryVisibilityFaces_get());
  public final static HCutGeometryVisibility HCutGeometryVisibilityEdges = new HCutGeometryVisibility("HCutGeometryVisibilityEdges", HJMVOJNI.HCutGeometryVisibilityEdges_get());
  public final static HCutGeometryVisibility HCutGeometryVisibilityAll = new HCutGeometryVisibility("HCutGeometryVisibilityAll", HJMVOJNI.HCutGeometryVisibilityAll_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static HCutGeometryVisibility swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + HCutGeometryVisibility.class + " with value " + swigValue);
  }

  private HCutGeometryVisibility(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private HCutGeometryVisibility(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private HCutGeometryVisibility(String swigName, HCutGeometryVisibility swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static HCutGeometryVisibility[] swigValues = { HCutGeometryVisibilityNone, HCutGeometryVisibilityFaces, HCutGeometryVisibilityEdges, HCutGeometryVisibilityAll };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

