/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class HKeyframeChannelDiscrete extends HKeyframeChannel {
  private long swigCPtr;

  public HKeyframeChannelDiscrete(long cPtr, boolean cMemoryOwn) {
    super(HJMVOJNI.HKeyframeChannelDiscrete_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  public static long getCPtr(HKeyframeChannelDiscrete obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJMVOJNI.delete_HKeyframeChannelDiscrete(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public HKeyframeChannelDiscrete(float x, float y, float z) {
    this(HJMVOJNI.new_HKeyframeChannelDiscrete__SWIG_0(x, y, z), true);
  }

  public HKeyframeChannelDiscrete(float x, float y) {
    this(HJMVOJNI.new_HKeyframeChannelDiscrete__SWIG_1(x, y), true);
  }

  public HKeyframeChannelDiscrete(float x) {
    this(HJMVOJNI.new_HKeyframeChannelDiscrete__SWIG_2(x), true);
  }

  public HKeyframeChannelDiscrete() {
    this(HJMVOJNI.new_HKeyframeChannelDiscrete__SWIG_3(), true);
  }

  public HKeyframe Clone() {
    long cPtr = HJMVOJNI.HKeyframeChannelDiscrete_Clone(swigCPtr, this);
    return (cPtr == 0) ? null : new HKeyframe(cPtr, false);
  }

  public void Interpolate(SWIGTYPE_p_p_HKeyframeChannel posarray, int keyframe, float fraction, int length, HPoint res) {
    HJMVOJNI.HKeyframeChannelDiscrete_Interpolate(swigCPtr, this, SWIGTYPE_p_p_HKeyframeChannel.getCPtr(posarray), keyframe, fraction, length, HPoint.getCPtr(res), res);
  }

  public void Serialize(SWIGTYPE_p_HUtilityXMLTag xmlgen) {
    HJMVOJNI.HKeyframeChannelDiscrete_Serialize(swigCPtr, this, SWIGTYPE_p_HUtilityXMLTag.getCPtr(xmlgen));
  }

}
