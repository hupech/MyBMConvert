/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public final class TKO_Font_Renderers {
  public final static TKO_Font_Renderers TKO_Font_Renderer_Undefined = new TKO_Font_Renderers("TKO_Font_Renderer_Undefined", HJSTREAMJNI.TKO_Font_Renderer_Undefined_get());
  public final static TKO_Font_Renderers TKO_Font_Renderer_Default = new TKO_Font_Renderers("TKO_Font_Renderer_Default", HJSTREAMJNI.TKO_Font_Renderer_Default_get());
  public final static TKO_Font_Renderers TKO_Font_Renderer_Driver = new TKO_Font_Renderers("TKO_Font_Renderer_Driver", HJSTREAMJNI.TKO_Font_Renderer_Driver_get());
  public final static TKO_Font_Renderers TKO_Font_Renderer_Truetype = new TKO_Font_Renderers("TKO_Font_Renderer_Truetype", HJSTREAMJNI.TKO_Font_Renderer_Truetype_get());
  public final static TKO_Font_Renderers TKO_Font_Renderer_Defined = new TKO_Font_Renderers("TKO_Font_Renderer_Defined", HJSTREAMJNI.TKO_Font_Renderer_Defined_get());

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static TKO_Font_Renderers swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + TKO_Font_Renderers.class + " with value " + swigValue);
  }

  private TKO_Font_Renderers(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private TKO_Font_Renderers(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private TKO_Font_Renderers(String swigName, TKO_Font_Renderers swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static TKO_Font_Renderers[] swigValues = { TKO_Font_Renderer_Undefined, TKO_Font_Renderer_Default, TKO_Font_Renderer_Driver, TKO_Font_Renderer_Truetype, TKO_Font_Renderer_Defined };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}

