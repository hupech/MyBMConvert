/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

#if _M_X64
using MVO_POINTER_SIZED_INT = System.Int64;
using MVO_POINTER_SIZED_UINT = System.UInt64;
using ID_Key = System.Int64;
#else
using MVO_POINTER_SIZED_INT = System.Int32;
using MVO_POINTER_SIZED_UINT = System.UInt32;
using ID_Key = System.Int32;
#endif


public class HUtilityGeometryCreation : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public HUtilityGeometryCreation(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  public static HandleRef getCPtr(HUtilityGeometryCreation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }
  
  public void owns_memory(bool ownMemory) {
	swigCMemOwn = ownMemory;
  }

  ~HUtilityGeometryCreation() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          HCSMVOPINVOKE.delete_HUtilityGeometryCreation(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static bool GeneratePointOnCircle(HPoint point, HPoint center, float radius, int axis, float angle, bool convert) {
    bool ret = HCSMVOPINVOKE.HUtilityGeometryCreation_GeneratePointOnCircle__SWIG_0(HPoint.getCPtr(point), HPoint.getCPtr(center), radius, axis, angle, convert);
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GeneratePointOnCircle(HPoint point, HPoint center, float radius, int axis, float angle) {
    bool ret = HCSMVOPINVOKE.HUtilityGeometryCreation_GeneratePointOnCircle__SWIG_1(HPoint.getCPtr(point), HPoint.getCPtr(center), radius, axis, angle);
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GeneratePointsOnCircle(float[] points, HPoint center, float radius, int axis, int numpoints, bool convert) {
    bool ret = HCSMVOPINVOKE.HUtilityGeometryCreation_GeneratePointsOnCircle__SWIG_0(points, HPoint.getCPtr(center), radius, axis, numpoints, convert);
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GeneratePointsOnCircle(float[] points, HPoint center, float radius, int axis, int numpoints) {
    bool ret = HCSMVOPINVOKE.HUtilityGeometryCreation_GeneratePointsOnCircle__SWIG_1(points, HPoint.getCPtr(center), radius, axis, numpoints);
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool GeneratePointsOnCircularArc(float[] points, HPoint center, float radius, int axis, int numpoints, bool convert, float start_angle, float end_angle) {
    bool ret = HCSMVOPINVOKE.HUtilityGeometryCreation_GeneratePointsOnCircularArc(points, HPoint.getCPtr(center), radius, axis, numpoints, convert, start_angle, end_angle);
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static MVO_POINTER_SIZED_INT CreateWireframeCircleWithEllipse(HPoint x1, HPoint x2, HPoint x3) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateWireframeCircleWithEllipse(HPoint.getCPtr(x1), HPoint.getCPtr(x2), HPoint.getCPtr(x3));}

  public static MVO_POINTER_SIZED_INT CreateSphere(string segment, HPoint center, float radius, int num_faces) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateSphere__SWIG_0(segment, HPoint.getCPtr(center), radius, num_faces);}

  public static MVO_POINTER_SIZED_INT CreateSphere(HPoint center, float radius, int numsides, HPoint axis, HPoint arg4) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateSphere__SWIG_1(HPoint.getCPtr(center), radius, numsides, HPoint.getCPtr(axis), HPoint.getCPtr(arg4));}

  public static MVO_POINTER_SIZED_INT CreateCone(HPoint center, float radius, float height, int numsides, HPoint axis, HPoint arg5) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateCone(HPoint.getCPtr(center), radius, height, numsides, HPoint.getCPtr(axis), HPoint.getCPtr(arg5));}

  public static MVO_POINTER_SIZED_INT CreateCylinder(HPoint center, float radius, float height, int numsides, HPoint axis, HPoint arg5) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateCylinder(HPoint.getCPtr(center), radius, height, numsides, HPoint.getCPtr(axis), HPoint.getCPtr(arg5));}

  public static MVO_POINTER_SIZED_INT CreateCuboid(HPoint max, HPoint min) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateCuboid(HPoint.getCPtr(max), HPoint.getCPtr(min));}

  public static void SetupModellingMatrix(HPoint axis, HPoint arg1, HPoint side, HPoint pos) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_SetupModellingMatrix(HPoint.getCPtr(axis), HPoint.getCPtr(arg1), HPoint.getCPtr(side), HPoint.getCPtr(pos));
    if (HCSMVOPINVOKE.SWIGPendingException.Pending) throw HCSMVOPINVOKE.SWIGPendingException.Retrieve();
  }

  public static MVO_POINTER_SIZED_INT CreateCuttingPlane(HBaseView view, string segmentname, bool createplane) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateCuttingPlane__SWIG_0(HBaseView.getCPtr(view), segmentname, createplane);}

  public static MVO_POINTER_SIZED_INT CreateCuttingPlane(HBaseView view, string segmentname) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateCuttingPlane__SWIG_1(HBaseView.getCPtr(view), segmentname);}

  public static MVO_POINTER_SIZED_INT CreateCuttingPlane(HBaseView view) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateCuttingPlane__SWIG_2(HBaseView.getCPtr(view));}

  public static void SetCuttingPlaneVisibilityForAll(MVO_POINTER_SIZED_INT startkey, string visibility) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_SetCuttingPlaneVisibilityForAll(startkey, visibility);
  }

  public static void AdjustCuttingPlaneRendering(HBaseView view) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_AdjustCuttingPlaneRendering(HBaseView.getCPtr(view));
  }

  public static void AdjustSection(HBaseView view, MVO_POINTER_SIZED_INT key) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_AdjustSection(HBaseView.getCPtr(view), key);
  }

  public static void CreateThreeSidedSection(HBaseView view) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_CreateThreeSidedSection(HBaseView.getCPtr(view));
  }

  public static void CreateTwoSidedSection(HBaseView view) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_CreateTwoSidedSection(HBaseView.getCPtr(view));
  }

  public static void CreateSlice(HBaseView view, float relative_thickness) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_CreateSlice__SWIG_0(HBaseView.getCPtr(view), relative_thickness);
  }

  public static void CreateSlice(HBaseView view) {
    HCSMVOPINVOKE.HUtilityGeometryCreation_CreateSlice__SWIG_1(HBaseView.getCPtr(view));
  }

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values, int[] per_face_vertex_color_value_indices, float[] color_findices, int[] per_face_vertex_color_findex_indices, float[] arg9, int[] per_face_vertex_param_indices, int param_number, float crease_angle) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_0(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values, per_face_vertex_color_value_indices, color_findices, per_face_vertex_color_findex_indices, arg9, per_face_vertex_param_indices, param_number, crease_angle);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values, int[] per_face_vertex_color_value_indices, float[] color_findices, int[] per_face_vertex_color_findex_indices, float[] arg9, int[] per_face_vertex_param_indices, int param_number) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_1(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values, per_face_vertex_color_value_indices, color_findices, per_face_vertex_color_findex_indices, arg9, per_face_vertex_param_indices, param_number);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values, int[] per_face_vertex_color_value_indices, float[] color_findices, int[] per_face_vertex_color_findex_indices, float[] arg9, int[] per_face_vertex_param_indices) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_2(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values, per_face_vertex_color_value_indices, color_findices, per_face_vertex_color_findex_indices, arg9, per_face_vertex_param_indices);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values, int[] per_face_vertex_color_value_indices, float[] color_findices, int[] per_face_vertex_color_findex_indices, float[] arg9) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_3(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values, per_face_vertex_color_value_indices, color_findices, per_face_vertex_color_findex_indices, arg9);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values, int[] per_face_vertex_color_value_indices, float[] color_findices, int[] per_face_vertex_color_findex_indices) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_4(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values, per_face_vertex_color_value_indices, color_findices, per_face_vertex_color_findex_indices);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values, int[] per_face_vertex_color_value_indices, float[] color_findices) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_5(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values, per_face_vertex_color_value_indices, color_findices);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values, int[] per_face_vertex_color_value_indices) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_6(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values, per_face_vertex_color_value_indices);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices, float[] color_values) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_7(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices, color_values);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals, int[] per_face_vertex_normal_indices) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_8(points, face_list_length, face_vertex_indices, normals, per_face_vertex_normal_indices);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices, float[] normals) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_9(points, face_list_length, face_vertex_indices, normals);}

  public static MVO_POINTER_SIZED_INT CreateShellWithFaceSpecificVertexAttributes(float[] points, int face_list_length, int[] face_vertex_indices) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellWithFaceSpecificVertexAttributes__SWIG_10(points, face_list_length, face_vertex_indices);}

  public static MVO_POINTER_SIZED_INT GenerateFEAShell(MVO_POINTER_SIZED_INT definingShell, bool generateIsolines, string algorithm) {return HCSMVOPINVOKE.HUtilityGeometryCreation_GenerateFEAShell(definingShell, generateIsolines, algorithm);}

  public static MVO_POINTER_SIZED_INT CreateSmoothedShell(int PointCount, float[] Points, int FaceListLength, int[] FaceList, float creaseAngle) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateSmoothedShell(PointCount, Points, FaceListLength, FaceList, creaseAngle);}

  public static bool ComputeFIndexDemoData(HShellVertexData pShellVertexData, int data_cycles) {
    bool ret = HCSMVOPINVOKE.HUtilityGeometryCreation_ComputeFIndexDemoData__SWIG_0(HShellVertexData.getCPtr(pShellVertexData), data_cycles);
    return ret;
  }

  public static bool ComputeFIndexDemoData(HShellVertexData pShellVertexData) {
    bool ret = HCSMVOPINVOKE.HUtilityGeometryCreation_ComputeFIndexDemoData__SWIG_1(HShellVertexData.getCPtr(pShellVertexData));
    return ret;
  }

  public static MVO_POINTER_SIZED_INT CreateBoolean(MVO_POINTER_SIZED_INT target, MVO_POINTER_SIZED_INT tool, int bool_type) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateBoolean(target, tool, bool_type);}

  public static MVO_POINTER_SIZED_INT CreateShellFromRotationalSweep(int nPoints, float[] profile, float[] radii, float start_angle, float end_angle, int axis, bool[] hard, int n_sides) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellFromRotationalSweep(nPoints, profile, radii, start_angle, end_angle, axis, hard, n_sides);}

  public static MVO_POINTER_SIZED_INT CreateShellFromPathSweep(int nProfilePoints, float[] pOuterProfilePoints, float[] pInnerProfilePoints, int nPathPoints, float[] pSweepPathPoints, bool bIsProfileClosed) {return HCSMVOPINVOKE.HUtilityGeometryCreation_CreateShellFromPathSweep(nProfilePoints, pOuterProfilePoints, pInnerProfilePoints, nPathPoints, pSweepPathPoints, bIsProfileClosed);}

  public HUtilityGeometryCreation() : this(HCSMVOPINVOKE.new_HUtilityGeometryCreation(), true) {
  }

}
