/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops.PMI.Roughness.Obtention;

public final class Type {
  public final static com.techsoft.hoops.PMI.Roughness.Obtention.Type Unknown = new com.techsoft.hoops.PMI.Roughness.Obtention.Type("Unknown");
  public final static com.techsoft.hoops.PMI.Roughness.Obtention.Type NotDefined = new com.techsoft.hoops.PMI.Roughness.Obtention.Type("NotDefined");
  public final static com.techsoft.hoops.PMI.Roughness.Obtention.Type MachiningMandatory = new com.techsoft.hoops.PMI.Roughness.Obtention.Type("MachiningMandatory");
  public final static com.techsoft.hoops.PMI.Roughness.Obtention.Type MachiningForbidden = new com.techsoft.hoops.PMI.Roughness.Obtention.Type("MachiningForbidden");

  public final int swigValue() {
    return swigValue;
  }

  public String toString() {
    return swigName;
  }

  public static Type swigToEnum(int swigValue) {
    if (swigValue < swigValues.length && swigValue >= 0 && swigValues[swigValue].swigValue == swigValue)
      return swigValues[swigValue];
    for (int i = 0; i < swigValues.length; i++)
      if (swigValues[i].swigValue == swigValue)
        return swigValues[i];
    throw new IllegalArgumentException("No enum " + Type.class + " with value " + swigValue);
  }

  private Type(String swigName) {
    this.swigName = swigName;
    this.swigValue = swigNext++;
  }

  private Type(String swigName, int swigValue) {
    this.swigName = swigName;
    this.swigValue = swigValue;
    swigNext = swigValue+1;
  }

  private Type(String swigName, Type swigEnum) {
    this.swigName = swigName;
    this.swigValue = swigEnum.swigValue;
    swigNext = this.swigValue+1;
  }

  private static Type[] swigValues = { Unknown, NotDefined, MachiningMandatory, MachiningForbidden };
  private static int swigNext = 0;
  private final int swigValue;
  private final String swigName;
}
