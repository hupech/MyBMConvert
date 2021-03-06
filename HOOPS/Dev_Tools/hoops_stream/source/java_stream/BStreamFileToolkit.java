/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package com.techsoft.hoops;

public class BStreamFileToolkit extends BControlledMemoryObject {
  private long swigCPtr;

  protected BStreamFileToolkit(long cPtr, boolean cMemoryOwn) {
    super(HJSTREAMJNI.SWIGBStreamFileToolkitUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(BStreamFileToolkit obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        HJSTREAMJNI.delete_BStreamFileToolkit(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public BStreamFileToolkit() {
    this(HJSTREAMJNI.new_BStreamFileToolkit(), true);
  }

  public static boolean SupportsAsciiMode() {
    return HJSTREAMJNI.BStreamFileToolkit_SupportsAsciiMode();
  }

  public TK_Status SetAsciiMode(boolean whether) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_SetAsciiMode(swigCPtr, this, whether));
  }

  public boolean GetAsciiMode() {
    return HJSTREAMJNI.BStreamFileToolkit_GetAsciiMode(swigCPtr, this);
  }

  public void SetTabs(int arg0) {
    HJSTREAMJNI.BStreamFileToolkit_SetTabs(swigCPtr, this, arg0);
  }

  public int GetTabs() {
    return HJSTREAMJNI.BStreamFileToolkit_GetTabs(swigCPtr, this);
  }

  public static int ParseVersion(String block) {
    return HJSTREAMJNI.BStreamFileToolkit_ParseVersion(block);
  }

  public TK_Status PrepareBuffer(byte[] b, int s) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_PrepareBuffer(swigCPtr, this, b, s));
  }

  public int CurrentBufferLength() {
    return HJSTREAMJNI.BStreamFileToolkit_CurrentBufferLength(swigCPtr, this);
  }

  public void ActivateContext(int key) {
    HJSTREAMJNI.BStreamFileToolkit_ActivateContext(swigCPtr, this, key);
  }

  public void DeactivateContext(int key) {
    HJSTREAMJNI.BStreamFileToolkit_DeactivateContext(swigCPtr, this, key);
  }

  public void NewFileContext(int key) {
    HJSTREAMJNI.BStreamFileToolkit_NewFileContext(swigCPtr, this, key);
  }

  public int GeneratedSoFar() {
    return HJSTREAMJNI.BStreamFileToolkit_GeneratedSoFar(swigCPtr, this);
  }

  public long ObjectsSoFar() {
    return HJSTREAMJNI.BStreamFileToolkit_ObjectsSoFar(swigCPtr, this);
  }

  public void SetOpcodeHandler(int which, BBaseOpcodeHandler handler) {
    HJSTREAMJNI.BStreamFileToolkit_SetOpcodeHandler(swigCPtr, this, which, BBaseOpcodeHandler.getCPtr(handler), handler);
  }

  public void SetPrewalkHandler(BBaseOpcodeHandler handler) {
    HJSTREAMJNI.BStreamFileToolkit_SetPrewalkHandler(swigCPtr, this, BBaseOpcodeHandler.getCPtr(handler), handler);
  }

  public void SetPostwalkHandler(BBaseOpcodeHandler handler) {
    HJSTREAMJNI.BStreamFileToolkit_SetPostwalkHandler(swigCPtr, this, BBaseOpcodeHandler.getCPtr(handler), handler);
  }

  public BBaseOpcodeHandler GetOpcodeHandler(int which) {
    long cPtr = HJSTREAMJNI.BStreamFileToolkit_GetOpcodeHandler(swigCPtr, this, which);
    return (cPtr == 0) ? null : new BBaseOpcodeHandler(cPtr, false);
  }

  public void Restart() {
    HJSTREAMJNI.BStreamFileToolkit_Restart(swigCPtr, this);
  }

  public TK_Status IndexToKey(int index, int[] key) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_IndexToKey(swigCPtr, this, index, key));
  }

  public TK_Status KeyToIndex(int key, int[] index) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_KeyToIndex(swigCPtr, this, key, index));
  }

  public TK_Status AddIndexKeyPair(int index, int key) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_AddIndexKeyPair(swigCPtr, this, index, key));
  }

  public TK_Status AddVariant(int key, int variant, int value1, int value2) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_AddVariant__SWIG_0(swigCPtr, this, key, variant, value1, value2));
  }

  public TK_Status AddVariant(int key, int variant, int value1) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_AddVariant__SWIG_1(swigCPtr, this, key, variant, value1));
  }

  public TK_Status AddBounds(int key, float[] bounds) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_AddBounds(swigCPtr, this, key, bounds));
  }

  public TK_Status GetOffset(int key, int variant, int[] offset) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_GetOffset__SWIG_0(swigCPtr, this, key, variant, offset));
  }

  public TK_Status GetOffset(int key, int variant, int[] offset, int[] length) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_GetOffset__SWIG_1(swigCPtr, this, key, variant, offset, length));
  }

  public TK_Status GetOffset(int key, int variant, int[] offset, int[] length, SWIGTYPE_p_wchar_t filename) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_GetOffset__SWIG_2(swigCPtr, this, key, variant, offset, length, SWIGTYPE_p_wchar_t.getCPtr(filename)));
  }

  public TK_Status GetBounds(int key, float[] bounds) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_GetBounds(swigCPtr, this, key, bounds));
  }

  public int NextTagIndex() {
    return HJSTREAMJNI.BStreamFileToolkit_NextTagIndex(swigCPtr, this);
  }

  public int PeekTagIndex() {
    return HJSTREAMJNI.BStreamFileToolkit_PeekTagIndex(swigCPtr, this);
  }

  public void SetFilename(String name) {
    HJSTREAMJNI.BStreamFileToolkit_SetFilename(swigCPtr, this, name);
  }

  public TK_Status Read_Stream_File() {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_Read_Stream_File(swigCPtr, this));
  }

  public void SetNewFile(String name) {
    HJSTREAMJNI.BStreamFileToolkit_SetNewFile(swigCPtr, this, name);
  }

  public String GetCurrentFile() {return HJSTREAMJNI.BStreamFileToolkit_GetCurrentFile__SWIG_0(swigCPtr, this);}

  public void GetCurrentFile(SWIGTYPE_p_wchar_t filename) {
    HJSTREAMJNI.BStreamFileToolkit_GetCurrentFile__SWIG_1(swigCPtr, this, SWIGTYPE_p_wchar_t.getCPtr(filename));
  }

  public TK_Status SelectFile(String name) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_SelectFile(swigCPtr, this, name));
  }

  public TK_Status OpenFile(String name, boolean write) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_OpenFile__SWIG_0(swigCPtr, this, name, write));
  }

  public TK_Status OpenFile(String name) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_OpenFile__SWIG_1(swigCPtr, this, name));
  }

  public TK_Status CloseFile() {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_CloseFile(swigCPtr, this));
  }

  public TK_Status ReadBuffer(byte[] buffer, int size, int[] amount_read) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_ReadBuffer(swigCPtr, this, buffer, size, amount_read));
  }

  public TK_Status WriteBuffer(byte[] buffer, int size) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_WriteBuffer(swigCPtr, this, buffer, size));
  }

  public TK_Status PositionFile(int offset) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_PositionFile(swigCPtr, this, offset));
  }

  public TK_Status GetFileSize(long[] size) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_GetFileSize(swigCPtr, this, size));
  }

  public TK_Status LocateDictionary() {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_LocateDictionary(swigCPtr, this));
  }

  public TK_Status LocateEntity(int key, int variant) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_LocateEntity(swigCPtr, this, key, variant));
  }

  public int GetFlags() {
    return HJSTREAMJNI.BStreamFileToolkit_GetFlags(swigCPtr, this);
  }

  public void SetFlags(int flags) {
    HJSTREAMJNI.BStreamFileToolkit_SetFlags(swigCPtr, this, flags);
  }

  public void SetWriteFlags(int flags) {
    HJSTREAMJNI.BStreamFileToolkit_SetWriteFlags(swigCPtr, this, flags);
  }

  public int GetWriteFlags(int mask) {
    return HJSTREAMJNI.BStreamFileToolkit_GetWriteFlags__SWIG_0(swigCPtr, this, mask);
  }

  public int GetWriteFlags() {
    return HJSTREAMJNI.BStreamFileToolkit_GetWriteFlags__SWIG_1(swigCPtr, this);
  }

  public void SetReadFlags(int flags) {
    HJSTREAMJNI.BStreamFileToolkit_SetReadFlags(swigCPtr, this, flags);
  }

  public int GetReadFlags(int mask) {
    return HJSTREAMJNI.BStreamFileToolkit_GetReadFlags__SWIG_0(swigCPtr, this, mask);
  }

  public int GetReadFlags() {
    return HJSTREAMJNI.BStreamFileToolkit_GetReadFlags__SWIG_1(swigCPtr, this);
  }

  public int GetNumNormalBits() {
    return HJSTREAMJNI.BStreamFileToolkit_GetNumNormalBits(swigCPtr, this);
  }

  public void SetNumNormalBits(int numbits) {
    HJSTREAMJNI.BStreamFileToolkit_SetNumNormalBits(swigCPtr, this, numbits);
  }

  public int GetNumVertexBits() {
    return HJSTREAMJNI.BStreamFileToolkit_GetNumVertexBits(swigCPtr, this);
  }

  public void SetNumVertexBits(int numbits) {
    HJSTREAMJNI.BStreamFileToolkit_SetNumVertexBits(swigCPtr, this, numbits);
  }

  public int GetNumParameterBits() {
    return HJSTREAMJNI.BStreamFileToolkit_GetNumParameterBits(swigCPtr, this);
  }

  public void SetNumParameterBits(int numbits) {
    HJSTREAMJNI.BStreamFileToolkit_SetNumParameterBits(swigCPtr, this, numbits);
  }

  public int GetNumColorBits() {
    return HJSTREAMJNI.BStreamFileToolkit_GetNumColorBits(swigCPtr, this);
  }

  public void SetNumColorBits(int numbits) {
    HJSTREAMJNI.BStreamFileToolkit_SetNumColorBits(swigCPtr, this, numbits);
  }

  public int GetNumIndexBits() {
    return HJSTREAMJNI.BStreamFileToolkit_GetNumIndexBits(swigCPtr, this);
  }

  public void SetNumIndexBits(int numbits) {
    HJSTREAMJNI.BStreamFileToolkit_SetNumIndexBits(swigCPtr, this, numbits);
  }

  public void SetJpegQuality(int quality) {
    HJSTREAMJNI.BStreamFileToolkit_SetJpegQuality__SWIG_0(swigCPtr, this, quality);
  }

  public void SetJpegQuality() {
    HJSTREAMJNI.BStreamFileToolkit_SetJpegQuality__SWIG_1(swigCPtr, this);
  }

  public int GetJpegQuality() {
    return HJSTREAMJNI.BStreamFileToolkit_GetJpegQuality(swigCPtr, this);
  }

  public int GetVersion() {
    return HJSTREAMJNI.BStreamFileToolkit_GetVersion(swigCPtr, this);
  }

  public void SetReadVersion(int version) {
    HJSTREAMJNI.BStreamFileToolkit_SetReadVersion(swigCPtr, this, version);
  }

  public void SetTargetVersion(int version) {
    HJSTREAMJNI.BStreamFileToolkit_SetTargetVersion(swigCPtr, this, version);
  }

  public int GetTargetVersion() {
    return HJSTREAMJNI.BStreamFileToolkit_GetTargetVersion(swigCPtr, this);
  }

  public long GetFileOffset() {
    return HJSTREAMJNI.BStreamFileToolkit_GetFileOffset(swigCPtr, this);
  }

  public void SetFileOffset(long offset) {
    HJSTREAMJNI.BStreamFileToolkit_SetFileOffset(swigCPtr, this, offset);
  }

  public int Unused() {
    return HJSTREAMJNI.BStreamFileToolkit_Unused(swigCPtr, this);
  }

  public TK_Status Error(String msg) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_Error__SWIG_0(swigCPtr, this, msg));
  }

  public TK_Status Error() {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_Error__SWIG_1(swigCPtr, this));
  }

  public String GetLogFile() {return HJSTREAMJNI.BStreamFileToolkit_GetLogFile(swigCPtr, this);}

  public void SetLogFile(String filename) {
    HJSTREAMJNI.BStreamFileToolkit_SetLogFile__SWIG_0(swigCPtr, this, filename);
  }

  public void SetLogFile() {
    HJSTREAMJNI.BStreamFileToolkit_SetLogFile__SWIG_1(swigCPtr, this);
  }

  public boolean GetLogging() {
    return HJSTREAMJNI.BStreamFileToolkit_GetLogging(swigCPtr, this);
  }

  public void SetLogging(boolean setting) {
    HJSTREAMJNI.BStreamFileToolkit_SetLogging(swigCPtr, this, setting);
  }

  public long GetLoggingOptions(long mask) {
    return HJSTREAMJNI.BStreamFileToolkit_GetLoggingOptions__SWIG_0(swigCPtr, this, mask);
  }

  public long GetLoggingOptions() {
    return HJSTREAMJNI.BStreamFileToolkit_GetLoggingOptions__SWIG_1(swigCPtr, this);
  }

  public void SetLoggingOptions(long options) {
    HJSTREAMJNI.BStreamFileToolkit_SetLoggingOptions__SWIG_0(swigCPtr, this, options);
  }

  public void SetLoggingOptions() {
    HJSTREAMJNI.BStreamFileToolkit_SetLoggingOptions__SWIG_1(swigCPtr, this);
  }

  public TK_Status OpenLogFile(String filename, String mode) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_OpenLogFile(swigCPtr, this, filename, mode));
  }

  public void LogEntry(String string) {
    HJSTREAMJNI.BStreamFileToolkit_LogEntry(swigCPtr, this, string);
  }

  public void CloseLogFile() {
    HJSTREAMJNI.BStreamFileToolkit_CloseLogFile(swigCPtr, this);
  }

  public long NextOpcodeSequence() {
    return HJSTREAMJNI.BStreamFileToolkit_NextOpcodeSequence(swigCPtr, this);
  }

  public void SetOpcodeSequence(long seq) {
    HJSTREAMJNI.BStreamFileToolkit_SetOpcodeSequence__SWIG_0(swigCPtr, this, seq);
  }

  public void SetOpcodeSequence() {
    HJSTREAMJNI.BStreamFileToolkit_SetOpcodeSequence__SWIG_1(swigCPtr, this);
  }

  public boolean HeaderCommentSeen() {
    return HJSTREAMJNI.BStreamFileToolkit_HeaderCommentSeen(swigCPtr, this);
  }

  public SWIGTYPE_p_f_unsigned_long_unsigned_long_p_void__bool GetProgressCallback() {
    long cPtr = HJSTREAMJNI.BStreamFileToolkit_GetProgressCallback(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_f_unsigned_long_unsigned_long_p_void__bool(cPtr, false);
  }

  public void SetProgressCallback(SWIGTYPE_p_f_unsigned_long_unsigned_long_p_void__bool cb) {
    HJSTREAMJNI.BStreamFileToolkit_SetProgressCallback__SWIG_0(swigCPtr, this, SWIGTYPE_p_f_unsigned_long_unsigned_long_p_void__bool.getCPtr(cb));
  }

  public void SetProgressCallback() {
    HJSTREAMJNI.BStreamFileToolkit_SetProgressCallback__SWIG_1(swigCPtr, this);
  }

  public SWIGTYPE_p_void GetProgressValue() {
    long cPtr = HJSTREAMJNI.BStreamFileToolkit_GetProgressValue(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_void(cPtr, false);
  }

  public void SetProgressValue(SWIGTYPE_p_void value) {
    HJSTREAMJNI.BStreamFileToolkit_SetProgressValue(swigCPtr, this, SWIGTYPE_p_void.getCPtr(value));
  }

  public int GetBufferLimit() {
    return HJSTREAMJNI.BStreamFileToolkit_GetBufferLimit(swigCPtr, this);
  }

  public void SetBufferLimit(int limit) {
    HJSTREAMJNI.BStreamFileToolkit_SetBufferLimit(swigCPtr, this, limit);
  }

  public void SetLastKey(int key) {
    HJSTREAMJNI.BStreamFileToolkit_SetLastKey(swigCPtr, this, key);
  }

  public TK_Status AppendLastKey(int key) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_AppendLastKey(swigCPtr, this, key));
  }

  public void ClearLastKey() {
    HJSTREAMJNI.BStreamFileToolkit_ClearLastKey(swigCPtr, this);
  }

  public TK_Status GetLastKey(int[] key) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_GetLastKey(swigCPtr, this, key));
  }

  public void SetDictionaryFormat(int format, int options) {
    HJSTREAMJNI.BStreamFileToolkit_SetDictionaryFormat__SWIG_0(swigCPtr, this, format, options);
  }

  public void SetDictionaryFormat(int format) {
    HJSTREAMJNI.BStreamFileToolkit_SetDictionaryFormat__SWIG_1(swigCPtr, this, format);
  }

  public void SetDictionaryFormat() {
    HJSTREAMJNI.BStreamFileToolkit_SetDictionaryFormat__SWIG_2(swigCPtr, this);
  }

  public int GetDictionaryFormat() {
    return HJSTREAMJNI.BStreamFileToolkit_GetDictionaryFormat(swigCPtr, this);
  }

  public int GetDictionaryOptions() {
    return HJSTREAMJNI.BStreamFileToolkit_GetDictionaryOptions(swigCPtr, this);
  }

  public void SetDictionaryOffset(int offset) {
    HJSTREAMJNI.BStreamFileToolkit_SetDictionaryOffset(swigCPtr, this, offset);
  }

  public int GetDictionaryOffset() {
    return HJSTREAMJNI.BStreamFileToolkit_GetDictionaryOffset(swigCPtr, this);
  }

  public void SetDictionarySize(int size) {
    HJSTREAMJNI.BStreamFileToolkit_SetDictionarySize(swigCPtr, this, size);
  }

  public int GetDictionarySize() {
    return HJSTREAMJNI.BStreamFileToolkit_GetDictionarySize(swigCPtr, this);
  }

  public void RecordPause(int offset) {
    HJSTREAMJNI.BStreamFileToolkit_RecordPause(swigCPtr, this, offset);
  }

  public void ClearPauses() {
    HJSTREAMJNI.BStreamFileToolkit_ClearPauses(swigCPtr, this);
  }

  public int GetPauseCount() {
    return HJSTREAMJNI.BStreamFileToolkit_GetPauseCount(swigCPtr, this);
  }

  public void SetFirstPause(int offset) {
    HJSTREAMJNI.BStreamFileToolkit_SetFirstPause(swigCPtr, this, offset);
  }

  public int GetFirstPause() {
    return HJSTREAMJNI.BStreamFileToolkit_GetFirstPause(swigCPtr, this);
  }

  public int GetPosition() {
    return HJSTREAMJNI.BStreamFileToolkit_GetPosition(swigCPtr, this);
  }

  public void SetWorldBounding(float[] bbox) {
    HJSTREAMJNI.BStreamFileToolkit_SetWorldBounding(swigCPtr, this, bbox);
  }

  public void SetWorldBoundingBySphere(float[] pt, float radius) {
    HJSTREAMJNI.BStreamFileToolkit_SetWorldBoundingBySphere(swigCPtr, this, pt, radius);
  }

  public boolean AddExternalReference(String ref, int context) {
    return HJSTREAMJNI.BStreamFileToolkit_AddExternalReference(swigCPtr, this, ref, context);
  }

  public boolean NextExternalReference() {
    return HJSTREAMJNI.BStreamFileToolkit_NextExternalReference(swigCPtr, this);
  }

  public String GetExternalReference() {return HJSTREAMJNI.BStreamFileToolkit_GetExternalReference__SWIG_0(swigCPtr, this);}

  public void GetExternalReference(SWIGTYPE_p_wchar_t exref) {
    HJSTREAMJNI.BStreamFileToolkit_GetExternalReference__SWIG_1(swigCPtr, this, SWIGTYPE_p_wchar_t.getCPtr(exref));
  }

  public int GetExternalReferenceContext() {
    return HJSTREAMJNI.BStreamFileToolkit_GetExternalReferenceContext(swigCPtr, this);
  }

  public boolean MatchPreviousExRef() {
    return HJSTREAMJNI.BStreamFileToolkit_MatchPreviousExRef(swigCPtr, this);
  }

  public void AddSegment(int key) {
    HJSTREAMJNI.BStreamFileToolkit_AddSegment(swigCPtr, this, key);
  }

  public int RemoveSegment() {
    return HJSTREAMJNI.BStreamFileToolkit_RemoveSegment(swigCPtr, this);
  }

  public int CurrentSegment() {
    return HJSTREAMJNI.BStreamFileToolkit_CurrentSegment(swigCPtr, this);
  }

  public void ResetQuantizationError() {
    HJSTREAMJNI.BStreamFileToolkit_ResetQuantizationError(swigCPtr, this);
  }

  public void ReportQuantizationError(float error) {
    HJSTREAMJNI.BStreamFileToolkit_ReportQuantizationError__SWIG_0(swigCPtr, this, error);
  }

  public void ReportQuantizationError(int bits_per_sample, float[] bounding, int num_dimensions) {
    HJSTREAMJNI.BStreamFileToolkit_ReportQuantizationError__SWIG_1(swigCPtr, this, bits_per_sample, bounding, num_dimensions);
  }

  public void ReportQuantizationError(int bits_per_sample, float[] bounding) {
    HJSTREAMJNI.BStreamFileToolkit_ReportQuantizationError__SWIG_2(swigCPtr, this, bits_per_sample, bounding);
  }

  public float GetQuantizationError() {
    return HJSTREAMJNI.BStreamFileToolkit_GetQuantizationError(swigCPtr, this);
  }

  public TK_Status OpenGeometry() {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_OpenGeometry(swigCPtr, this));
  }

  public TK_Status CloseGeometry() {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_CloseGeometry(swigCPtr, this));
  }

  public boolean GeometryIsOpen() {
    return HJSTREAMJNI.BStreamFileToolkit_GeometryIsOpen(swigCPtr, this);
  }

  public int RevisitKey() {
    return HJSTREAMJNI.BStreamFileToolkit_RevisitKey(swigCPtr, this);
  }

  public int RevisitOwner() {
    return HJSTREAMJNI.BStreamFileToolkit_RevisitOwner(swigCPtr, this);
  }

  public TK_Status ParseBuffer(byte[] b, int s, TK_Status mode) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_ParseBuffer__SWIG_0(swigCPtr, this, b, s, mode.swigValue()));
  }

  public TK_Status ParseBuffer(byte[] b, int s) {
    return TK_Status.swigToEnum(HJSTREAMJNI.BStreamFileToolkit_ParseBuffer__SWIG_1(swigCPtr, this, b, s));
  }

  public void GetPauseTable(int[] values, int count) {
    HJSTREAMJNI.BStreamFileToolkit_GetPauseTable(swigCPtr, this, values, count);
  }

  public void GetWorldBounding(float[] values, int count) {
    HJSTREAMJNI.BStreamFileToolkit_GetWorldBounding(swigCPtr, this, values, count);
  }

}
