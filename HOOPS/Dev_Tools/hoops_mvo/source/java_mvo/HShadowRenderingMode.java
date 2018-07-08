/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public final class HShadowRenderingMode {
  public final static HShadowRenderingMode SoftwareShadow = new HShadowRenderingMode("SoftwareShadow");
  public final static HShadowRenderingMode HardwareShadow = new HShadowRenderingMode("HardwareShadow");
  public final static HShadowRenderingMode SoftwareOpenglShadow = new HShadowRenderingMode("SoftwareOpenglShadow");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static HShadowRenderingMode swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + HShadowRenderingMode.class + " with value " + swigValue);
  }

  private HShadowRenderingMode(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private HShadowRenderingMode(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private HShadowRenderingMode(String swigName, HShadowRenderingMode swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static HShadowRenderingMode[] swigValues = { SoftwareShadow, HardwareShadow, SoftwareOpenglShadow };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

