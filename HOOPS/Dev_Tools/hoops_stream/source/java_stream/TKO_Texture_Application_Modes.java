/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public final class TKO_Texture_Application_Modes {
  public final static TKO_Texture_Application_Modes TKO_Texture_Modulate_Set = new TKO_Texture_Application_Modes("TKO_Texture_Modulate_Set", HJSTREAMJNI.TKO_Texture_Modulate_Set_get());
  public final static TKO_Texture_Application_Modes TKO_Texture_Decal_Set = new TKO_Texture_Application_Modes("TKO_Texture_Decal_Set", HJSTREAMJNI.TKO_Texture_Decal_Set_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static TKO_Texture_Application_Modes swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + TKO_Texture_Application_Modes.class + " with value " + swigValue);
  }

  private TKO_Texture_Application_Modes(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private TKO_Texture_Application_Modes(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private TKO_Texture_Application_Modes(String swigName, TKO_Texture_Application_Modes swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static TKO_Texture_Application_Modes[] swigValues = { TKO_Texture_Modulate_Set, TKO_Texture_Decal_Set };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}
