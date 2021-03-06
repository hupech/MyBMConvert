/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public final class HViewSelectionLevel {
  public final static HViewSelectionLevel HSelectionLevelEntity = new HViewSelectionLevel("HSelectionLevelEntity");
  public final static HViewSelectionLevel HSelectionLevelSegment = new HViewSelectionLevel("HSelectionLevelSegment");
  public final static HViewSelectionLevel HSelectionLevelSegmentTree = new HViewSelectionLevel("HSelectionLevelSegmentTree");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static HViewSelectionLevel swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + HViewSelectionLevel.class + " with value " + swigValue);
  }

  private HViewSelectionLevel(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private HViewSelectionLevel(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private HViewSelectionLevel(String swigName, HViewSelectionLevel swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static HViewSelectionLevel[] swigValues = { HSelectionLevelEntity, HSelectionLevelSegment, HSelectionLevelSegmentTree };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

