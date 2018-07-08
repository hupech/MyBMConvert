/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public final class TKO_Color_Channels {
  public final static TKO_Color_Channels TKO_Channel_Diffuse = new TKO_Color_Channels("TKO_Channel_Diffuse", HJSTREAMJNI.TKO_Channel_Diffuse_get());
  public final static TKO_Color_Channels TKO_Channel_Specular = new TKO_Color_Channels("TKO_Channel_Specular", HJSTREAMJNI.TKO_Channel_Specular_get());
  public final static TKO_Color_Channels TKO_Channel_Mirror = new TKO_Color_Channels("TKO_Channel_Mirror", HJSTREAMJNI.TKO_Channel_Mirror_get());
  public final static TKO_Color_Channels TKO_Channel_Transmission = new TKO_Color_Channels("TKO_Channel_Transmission", HJSTREAMJNI.TKO_Channel_Transmission_get());
  public final static TKO_Color_Channels TKO_Channel_Emission = new TKO_Color_Channels("TKO_Channel_Emission", HJSTREAMJNI.TKO_Channel_Emission_get());
  public final static TKO_Color_Channels TKO_Channel_Gloss = new TKO_Color_Channels("TKO_Channel_Gloss", HJSTREAMJNI.TKO_Channel_Gloss_get());
  public final static TKO_Color_Channels TKO_Channel_Index = new TKO_Color_Channels("TKO_Channel_Index", HJSTREAMJNI.TKO_Channel_Index_get());
  public final static TKO_Color_Channels TKO_Channel_Extended = new TKO_Color_Channels("TKO_Channel_Extended", HJSTREAMJNI.TKO_Channel_Extended_get());
  public final static TKO_Color_Channels TKO_Channel_Environment = new TKO_Color_Channels("TKO_Channel_Environment", HJSTREAMJNI.TKO_Channel_Environment_get());
  public final static TKO_Color_Channels TKO_Channel_Bump = new TKO_Color_Channels("TKO_Channel_Bump", HJSTREAMJNI.TKO_Channel_Bump_get());
  public final static TKO_Color_Channels TKO_Channel_Count = new TKO_Color_Channels("TKO_Channel_Count", HJSTREAMJNI.TKO_Channel_Count_get());
  public final static TKO_Color_Channels TKO_Channel_Extended_Mask = new TKO_Color_Channels("TKO_Channel_Extended_Mask", HJSTREAMJNI.TKO_Channel_Extended_Mask_get());
  public final static TKO_Color_Channels TKO_Channel_Extended_Shift = new TKO_Color_Channels("TKO_Channel_Extended_Shift", HJSTREAMJNI.TKO_Channel_Extended_Shift_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static TKO_Color_Channels swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + TKO_Color_Channels.class + " with value " + swigValue);
  }

  private TKO_Color_Channels(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private TKO_Color_Channels(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private TKO_Color_Channels(String swigName, TKO_Color_Channels swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static TKO_Color_Channels[] swigValues = { TKO_Channel_Diffuse, TKO_Channel_Specular, TKO_Channel_Mirror, TKO_Channel_Transmission, TKO_Channel_Emission, TKO_Channel_Gloss, TKO_Channel_Index, TKO_Channel_Extended, TKO_Channel_Environment, TKO_Channel_Bump, TKO_Channel_Count, TKO_Channel_Extended_Mask, TKO_Channel_Extended_Shift };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

