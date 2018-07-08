/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class TK_Text_Font extends BBaseOpcodeHandler {
  private long swigCPtr;

  protected TK_Text_Font(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGTK_Text_FontUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(TK_Text_Font obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_TK_Text_Font(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    HJSTREAMJNI.TK_Text_Font_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    HJSTREAMJNI.TK_Text_Font_change_ownership(this, swigCPtr, true);
  }

  protected void setM_mask(int value) {
    HJSTREAMJNI.TK_Text_Font_m_mask_set(swigCPtr, this, value);
  }

  protected int getM_mask() {
    return HJSTREAMJNI.TK_Text_Font_m_mask_get(swigCPtr, this);
  }

  protected void setM_value(int value) {
    HJSTREAMJNI.TK_Text_Font_m_value_set(swigCPtr, this, value);
  }

  protected int getM_value() {
    return HJSTREAMJNI.TK_Text_Font_m_value_get(swigCPtr, this);
  }

  protected void setM_names_length(int value) {
    HJSTREAMJNI.TK_Text_Font_m_names_length_set(swigCPtr, this, value);
  }

  protected int getM_names_length() {
    return HJSTREAMJNI.TK_Text_Font_m_names_length_get(swigCPtr, this);
  }

  protected void setM_size(float value) {
    HJSTREAMJNI.TK_Text_Font_m_size_set(swigCPtr, this, value);
  }

  protected float getM_size() {
    return HJSTREAMJNI.TK_Text_Font_m_size_get(swigCPtr, this);
  }

  protected void setM_tolerance(float value) {
    HJSTREAMJNI.TK_Text_Font_m_tolerance_set(swigCPtr, this, value);
  }

  protected float getM_tolerance() {
    return HJSTREAMJNI.TK_Text_Font_m_tolerance_get(swigCPtr, this);
  }

  protected void setM_rotation(float value) {
    HJSTREAMJNI.TK_Text_Font_m_rotation_set(swigCPtr, this, value);
  }

  protected float getM_rotation() {
    return HJSTREAMJNI.TK_Text_Font_m_rotation_get(swigCPtr, this);
  }

  protected void setM_slant(float value) {
    HJSTREAMJNI.TK_Text_Font_m_slant_set(swigCPtr, this, value);
  }

  protected float getM_slant() {
    return HJSTREAMJNI.TK_Text_Font_m_slant_get(swigCPtr, this);
  }

  protected void setM_width_scale(float value) {
    HJSTREAMJNI.TK_Text_Font_m_width_scale_set(swigCPtr, this, value);
  }

  protected float getM_width_scale() {
    return HJSTREAMJNI.TK_Text_Font_m_width_scale_get(swigCPtr, this);
  }

  protected void setM_extra_space(float value) {
    HJSTREAMJNI.TK_Text_Font_m_extra_space_set(swigCPtr, this, value);
  }

  protected float getM_extra_space() {
    return HJSTREAMJNI.TK_Text_Font_m_extra_space_get(swigCPtr, this);
  }

  protected void setM_line_spacing(float value) {
    HJSTREAMJNI.TK_Text_Font_m_line_spacing_set(swigCPtr, this, value);
  }

  protected float getM_line_spacing() {
    return HJSTREAMJNI.TK_Text_Font_m_line_spacing_get(swigCPtr, this);
  }

  protected void setM_greeking_limit(float value) {
    HJSTREAMJNI.TK_Text_Font_m_greeking_limit_set(swigCPtr, this, value);
  }

  protected float getM_greeking_limit() {
    return HJSTREAMJNI.TK_Text_Font_m_greeking_limit_get(swigCPtr, this);
  }

  protected void setM_renderer_cutoff(float value) {
    HJSTREAMJNI.TK_Text_Font_m_renderer_cutoff_set(swigCPtr, this, value);
  }

  protected float getM_renderer_cutoff() {
    return HJSTREAMJNI.TK_Text_Font_m_renderer_cutoff_get(swigCPtr, this);
  }

  protected void setM_preference_cutoff(float value) {
    HJSTREAMJNI.TK_Text_Font_m_preference_cutoff_set(swigCPtr, this, value);
  }

  protected float getM_preference_cutoff() {
    return HJSTREAMJNI.TK_Text_Font_m_preference_cutoff_get(swigCPtr, this);
  }

  protected void setM_renderers(SWIGTYPE_p_int value) {
    HJSTREAMJNI.TK_Text_Font_m_renderers_set(swigCPtr, this, SWIGTYPE_p_int.getCPtr(value));
  }

  protected SWIGTYPE_p_int getM_renderers() {
    long cPtr = HJSTREAMJNI.TK_Text_Font_m_renderers_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_int(cPtr, false);
  }

  protected void setM_preferences(SWIGTYPE_p_int value) {
    HJSTREAMJNI.TK_Text_Font_m_preferences_set(swigCPtr, this, SWIGTYPE_p_int.getCPtr(value));
  }

  protected SWIGTYPE_p_int getM_preferences() {
    long cPtr = HJSTREAMJNI.TK_Text_Font_m_preferences_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_int(cPtr, false);
  }

  protected void setM_size_units(short value) {
    HJSTREAMJNI.TK_Text_Font_m_size_units_set(swigCPtr, this, value);
  }

  protected short getM_size_units() {
    return HJSTREAMJNI.TK_Text_Font_m_size_units_get(swigCPtr, this);
  }

  protected void setM_tolerance_units(short value) {
    HJSTREAMJNI.TK_Text_Font_m_tolerance_units_set(swigCPtr, this, value);
  }

  protected short getM_tolerance_units() {
    return HJSTREAMJNI.TK_Text_Font_m_tolerance_units_get(swigCPtr, this);
  }

  protected void setM_space_units(short value) {
    HJSTREAMJNI.TK_Text_Font_m_space_units_set(swigCPtr, this, value);
  }

  protected short getM_space_units() {
    return HJSTREAMJNI.TK_Text_Font_m_space_units_get(swigCPtr, this);
  }

  protected void setM_greeking_units(short value) {
    HJSTREAMJNI.TK_Text_Font_m_greeking_units_set(swigCPtr, this, value);
  }

  protected short getM_greeking_units() {
    return HJSTREAMJNI.TK_Text_Font_m_greeking_units_get(swigCPtr, this);
  }

  protected void setM_greeking_mode(short value) {
    HJSTREAMJNI.TK_Text_Font_m_greeking_mode_set(swigCPtr, this, value);
  }

  protected short getM_greeking_mode() {
    return HJSTREAMJNI.TK_Text_Font_m_greeking_mode_get(swigCPtr, this);
  }

  protected void setM_transforms(short value) {
    HJSTREAMJNI.TK_Text_Font_m_transforms_set(swigCPtr, this, value);
  }

  protected short getM_transforms() {
    return HJSTREAMJNI.TK_Text_Font_m_transforms_get(swigCPtr, this);
  }

  protected void setM_renderer_cutoff_units(short value) {
    HJSTREAMJNI.TK_Text_Font_m_renderer_cutoff_units_set(swigCPtr, this, value);
  }

  protected short getM_renderer_cutoff_units() {
    return HJSTREAMJNI.TK_Text_Font_m_renderer_cutoff_units_get(swigCPtr, this);
  }

  protected void setM_preference_cutoff_units(short value) {
    HJSTREAMJNI.TK_Text_Font_m_preference_cutoff_units_set(swigCPtr, this, value);
  }

  protected short getM_preference_cutoff_units() {
    return HJSTREAMJNI.TK_Text_Font_m_preference_cutoff_units_get(swigCPtr, this);
  }

  protected void setM_layout(short value) {
    HJSTREAMJNI.TK_Text_Font_m_layout_set(swigCPtr, this, value);
  }

  protected short getM_layout() {
    return HJSTREAMJNI.TK_Text_Font_m_layout_get(swigCPtr, this);
  }

  protected void set_names(int length) {
    HJSTREAMJNI.TK_Text_Font_set_names__SWIG_0(swigCPtr, this, length);
  }

  protected void set_names(String names) {
    HJSTREAMJNI.TK_Text_Font_set_names__SWIG_1(swigCPtr, this, names);
  }

  public TK_Text_Font() {
    this(HJSTREAMJNI.new_TK_Text_Font(), true);
    HJSTREAMJNI.TK_Text_Font_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public TK_Status Read(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_Text_Font.class) ? HJSTREAMJNI.TK_Text_Font_Read(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_Text_Font_ReadSwigExplicitTK_Text_Font(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Write(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum((getClass() == TK_Text_Font.class) ? HJSTREAMJNI.TK_Text_Font_Write(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk) : HJSTREAMJNI.TK_Text_Font_WriteSwigExplicitTK_Text_Font(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status Clone(BStreamFileToolkit tk, SWIGTYPE_p_p_BBaseOpcodeHandler handler) {
    return TK_Status.swigToEnum((getClass() == TK_Text_Font.class) ? HJSTREAMJNI.TK_Text_Font_Clone(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)) : HJSTREAMJNI.TK_Text_Font_CloneSwigExplicitTK_Text_Font(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk, SWIGTYPE_p_p_BBaseOpcodeHandler.getCPtr(handler)));
  }

  public TK_Status ReadAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Text_Font_ReadAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public TK_Status WriteAscii(BStreamFileToolkit tk) {
    return TK_Status.swigToEnum(HJSTREAMJNI.TK_Text_Font_WriteAscii(swigCPtr, this, BStreamFileToolkit.getCPtr(tk), tk));
  }

  public void Reset() {
    if (getClass() == TK_Text_Font.class) HJSTREAMJNI.TK_Text_Font_Reset(swigCPtr, this); else HJSTREAMJNI.TK_Text_Font_ResetSwigExplicitTK_Text_Font(swigCPtr, this);
  }

  public void SetMask(int m) {
    HJSTREAMJNI.TK_Text_Font_SetMask(swigCPtr, this, m);
  }

  public int GetMask() {
    return HJSTREAMJNI.TK_Text_Font_GetMask(swigCPtr, this);
  }

  public void SetValue(int v) {
    HJSTREAMJNI.TK_Text_Font_SetValue(swigCPtr, this, v);
  }

  public int GetValue() {
    return HJSTREAMJNI.TK_Text_Font_GetValue(swigCPtr, this);
  }

  public void SetNames(String names) {
    HJSTREAMJNI.TK_Text_Font_SetNames__SWIG_0(swigCPtr, this, names);
  }

  public void SetNames(int length) {
    HJSTREAMJNI.TK_Text_Font_SetNames__SWIG_1(swigCPtr, this, length);
  }

  public String GetNames() {return HJSTREAMJNI.TK_Text_Font_GetNames__SWIG_0(swigCPtr, this);}

  public void SetSize(float s) {
    HJSTREAMJNI.TK_Text_Font_SetSize(swigCPtr, this, s);
  }

  public float GetSize() {
    return HJSTREAMJNI.TK_Text_Font_GetSize(swigCPtr, this);
  }

  public void SetSizeUnits(int u) {
    HJSTREAMJNI.TK_Text_Font_SetSizeUnits(swigCPtr, this, u);
  }

  public int GetSizeUnits() {
    return HJSTREAMJNI.TK_Text_Font_GetSizeUnits(swigCPtr, this);
  }

  public void SetTolerance(float t) {
    HJSTREAMJNI.TK_Text_Font_SetTolerance(swigCPtr, this, t);
  }

  public float GetTolerance() {
    return HJSTREAMJNI.TK_Text_Font_GetTolerance(swigCPtr, this);
  }

  public void SetToleranceUnits(int u) {
    HJSTREAMJNI.TK_Text_Font_SetToleranceUnits(swigCPtr, this, u);
  }

  public int GetToleranceUnits() {
    return HJSTREAMJNI.TK_Text_Font_GetToleranceUnits(swigCPtr, this);
  }

  public void SetRotation(float r) {
    HJSTREAMJNI.TK_Text_Font_SetRotation(swigCPtr, this, r);
  }

  public float GetRotation() {
    return HJSTREAMJNI.TK_Text_Font_GetRotation(swigCPtr, this);
  }

  public void SetSlant(float s) {
    HJSTREAMJNI.TK_Text_Font_SetSlant(swigCPtr, this, s);
  }

  public float GetSlant() {
    return HJSTREAMJNI.TK_Text_Font_GetSlant(swigCPtr, this);
  }

  public void SetWidthScale(float s) {
    HJSTREAMJNI.TK_Text_Font_SetWidthScale(swigCPtr, this, s);
  }

  public float GetWidthScale() {
    return HJSTREAMJNI.TK_Text_Font_GetWidthScale(swigCPtr, this);
  }

  public void SetExtraSpace(float s) {
    HJSTREAMJNI.TK_Text_Font_SetExtraSpace(swigCPtr, this, s);
  }

  public float GetExtraSpace() {
    return HJSTREAMJNI.TK_Text_Font_GetExtraSpace(swigCPtr, this);
  }

  public void SetExtraSpaceUnits(int u) {
    HJSTREAMJNI.TK_Text_Font_SetExtraSpaceUnits(swigCPtr, this, u);
  }

  public int GetExtraSpaceUnits() {
    return HJSTREAMJNI.TK_Text_Font_GetExtraSpaceUnits(swigCPtr, this);
  }

  public void SetLineSpacing(float s) {
    HJSTREAMJNI.TK_Text_Font_SetLineSpacing(swigCPtr, this, s);
  }

  public float GetLineSpacing() {
    return HJSTREAMJNI.TK_Text_Font_GetLineSpacing(swigCPtr, this);
  }

  public void SetTransforms(int t) {
    HJSTREAMJNI.TK_Text_Font_SetTransforms(swigCPtr, this, t);
  }

  public int GetTransforms() {
    return HJSTREAMJNI.TK_Text_Font_GetTransforms(swigCPtr, this);
  }

  public void SetGreekingLimit(float s) {
    HJSTREAMJNI.TK_Text_Font_SetGreekingLimit(swigCPtr, this, s);
  }

  public float GetGreekingLimit() {
    return HJSTREAMJNI.TK_Text_Font_GetGreekingLimit(swigCPtr, this);
  }

  public void SetGreekingLimitUnits(int u) {
    HJSTREAMJNI.TK_Text_Font_SetGreekingLimitUnits(swigCPtr, this, u);
  }

  public int GetGreekingLimitUnits() {
    return HJSTREAMJNI.TK_Text_Font_GetGreekingLimitUnits(swigCPtr, this);
  }

  public void SetGreekingMode(int m) {
    HJSTREAMJNI.TK_Text_Font_SetGreekingMode(swigCPtr, this, m);
  }

  public int GetGreekingMode() {
    return HJSTREAMJNI.TK_Text_Font_GetGreekingMode(swigCPtr, this);
  }

  public void SetRenderer(int r) {
    HJSTREAMJNI.TK_Text_Font_SetRenderer(swigCPtr, this, r);
  }

  public int GetRenderer() {
    return HJSTREAMJNI.TK_Text_Font_GetRenderer(swigCPtr, this);
  }

  public void SetRenderers(int r1, int r2) {
    HJSTREAMJNI.TK_Text_Font_SetRenderers(swigCPtr, this, r1, r2);
  }

  public void SetRendererCutoff(float s) {
    HJSTREAMJNI.TK_Text_Font_SetRendererCutoff(swigCPtr, this, s);
  }

  public float GetRendererCutoff() {
    return HJSTREAMJNI.TK_Text_Font_GetRendererCutoff(swigCPtr, this);
  }

  public void SetRendererCutoffUnits(int u) {
    HJSTREAMJNI.TK_Text_Font_SetRendererCutoffUnits(swigCPtr, this, u);
  }

  public int GetRendererCutoffUnits() {
    return HJSTREAMJNI.TK_Text_Font_GetRendererCutoffUnits(swigCPtr, this);
  }

  public void SetPreference(int r) {
    HJSTREAMJNI.TK_Text_Font_SetPreference(swigCPtr, this, r);
  }

  public int GetPreference() {
    return HJSTREAMJNI.TK_Text_Font_GetPreference(swigCPtr, this);
  }

  public void SetPreferences(int r1, int r2) {
    HJSTREAMJNI.TK_Text_Font_SetPreferences(swigCPtr, this, r1, r2);
  }

  public void SetPreferenceCutoff(float s) {
    HJSTREAMJNI.TK_Text_Font_SetPreferenceCutoff(swigCPtr, this, s);
  }

  public float GetPreferenceCutoff() {
    return HJSTREAMJNI.TK_Text_Font_GetPreferenceCutoff(swigCPtr, this);
  }

  public void SetPreferenceCutoffUnits(int u) {
    HJSTREAMJNI.TK_Text_Font_SetPreferenceCutoffUnits(swigCPtr, this, u);
  }

  public int GetPreferenceCutoffUnits() {
    return HJSTREAMJNI.TK_Text_Font_GetPreferenceCutoffUnits(swigCPtr, this);
  }

  public void SetLayout(int l) {
    HJSTREAMJNI.TK_Text_Font_SetLayout(swigCPtr, this, l);
  }

  public int GetLayout() {
    return HJSTREAMJNI.TK_Text_Font_GetLayout(swigCPtr, this);
  }

}
