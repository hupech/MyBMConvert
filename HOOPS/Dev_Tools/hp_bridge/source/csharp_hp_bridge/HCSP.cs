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
using HLONG = System.Int64;
#else
using HLONG = System.Int32;
#endif
unsafe public partial class 
 HCSP {
  public static void Init(string arg0, byte arg1, bool arg2) {
    HCSPPINVOKE.Init__SWIG_0(arg0, arg1, arg2);
  }

  public static void Init(string arg0, byte arg1) {
    HCSPPINVOKE.Init__SWIG_1(arg0, arg1);
  }

  public static void Update() {
    HCSPPINVOKE.Update();
  }

  public static void Close() {
    HCSPPINVOKE.Close();
  }

  public static void Delete_Entity_Geometry(uint arg0, int* arg1, bool arg2) {
    HCSPPINVOKE.Delete_Entity_Geometry__SWIG_0(arg0, arg1, arg2);
  }

  public static void Delete_Entity_Geometry(uint arg0, int* arg1) {
    HCSPPINVOKE.Delete_Entity_Geometry__SWIG_1(arg0, arg1);
  }

  public static bool Update_Entity(int arg0, int arg1, int arg2) {
    bool ret = HCSPPINVOKE.Update_Entity__SWIG_0(arg0, arg1, arg2);
    return ret;
  }

  public static bool Update_Entity(int arg0, int arg1) {
    bool ret = HCSPPINVOKE.Update_Entity__SWIG_1(arg0, arg1);
    return ret;
  }

  public static bool Update_Entity(int arg0) {
    bool ret = HCSPPINVOKE.Update_Entity__SWIG_2(arg0);
    return ret;
  }

  public static int Compute_Geometry_Keys(int arg0, int arg1, HLONG* arg2, string arg3) {
    int ret = HCSPPINVOKE.Compute_Geometry_Keys(arg0, arg1, arg2, arg3);
    return ret;
  }

  public static int Compute_Geometry_Key_Count(int arg0, System.Text.StringBuilder arg1) {
    int ret = HCSPPINVOKE.Compute_Geometry_Key_Count(arg0, arg1);
    return ret;
  }

  public static int Compute_TagID(HLONG arg0, int arg1) {
    int ret = HCSPPINVOKE.Compute_TagID(arg0, arg1);
    return ret;
  }

  public static void Set_Rendering_Options(string arg0) {
    HCSPPINVOKE.Set_Rendering_Options(arg0);
  }

  public static void Show_Rendering_Options(System.Text.StringBuilder arg0) {
    HCSPPINVOKE.Show_Rendering_Options(arg0);
  }

  public static void Show_One_Rendering_Option(string arg0, System.Text.StringBuilder arg1) {
    HCSPPINVOKE.Show_One_Rendering_Option(arg0, arg1);
  }

  public static void Set_Schema_Path(string arg0) {
    HCSPPINVOKE.Set_Schema_Path(arg0);
  }

  public static void Set_Hash_Level(byte arg0) {
    HCSPPINVOKE.Set_Hash_Level(arg0);
  }

  public static void Set_Instances_To_Bodies(bool arg0) {
    HCSPPINVOKE.Set_Instances_To_Bodies(arg0);
  }

  public static bool Get_Instances_To_Bodies() {
    bool ret = HCSPPINVOKE.Get_Instances_To_Bodies();
    return ret;
  }

  public static int Check_Consistency() {
    int ret = HCSPPINVOKE.Check_Consistency();
    return ret;
  }

  public static bool Associate_Key_To_Entity(int arg0, HLONG arg1) {
    bool ret = HCSPPINVOKE.Associate_Key_To_Entity(arg0, arg1);
    return ret;
  }

  public static void Compute_Selected_Entity_List(int ** arg0, int* arg1) {
    HCSPPINVOKE.Compute_Selected_Entity_List(arg0, arg1);
  }

  public static byte Get_Hash_Level() {
    byte ret = HCSPPINVOKE.Get_Hash_Level();
    return ret;
  }

  public static SWIGTYPE_p_wchar_t Get_Schema_Path() {
    IntPtr cPtr = HCSPPINVOKE.Get_Schema_Path();
    SWIGTYPE_p_wchar_t ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_wchar_t(cPtr, false);
    return ret;
  }

  public static void open_assembly_internal(int assembly, bool tesselate, int level) {
    HCSPPINVOKE.open_assembly_internal(assembly, tesselate, level);
  }

  public static void merge_body_faces_internal(int* bodies_to_merge, uint num_Bodies) {
    HCSPPINVOKE.merge_body_faces_internal(bodies_to_merge, num_Bodies);
  }

  public static void insert_vertices_for_body(int body) {
    HCSPPINVOKE.insert_vertices_for_body(body);
  }

  public static readonly int HP_ERROR_key_out_of_range = HCSPPINVOKE.HP_ERROR_key_out_of_range_get();
  public static readonly int HP_ERROR_non_circle_key_out_of_range = HCSPPINVOKE.HP_ERROR_non_circle_key_out_of_range_get();
  public static readonly int HP_ERROR_key_does_not_exist = HCSPPINVOKE.HP_ERROR_key_does_not_exist_get();
  public static readonly int HP_ERROR_unable_to_determine_entity_class = HCSPPINVOKE.HP_ERROR_unable_to_determine_entity_class_get();
  public static readonly int HP_ERROR_non_mappable_entity_class = HCSPPINVOKE.HP_ERROR_non_mappable_entity_class_get();
  public static readonly int HP_ERROR_unknown_entity_class = HCSPPINVOKE.HP_ERROR_unknown_entity_class_get();
  public static readonly int HP_ERROR_not_implemented = HCSPPINVOKE.HP_ERROR_not_implemented_get();
  public static readonly int HP_ERROR_hoops_key_maps_to_invalid_entity_class = HCSPPINVOKE.HP_ERROR_hoops_key_maps_to_invalid_entity_class_get();
  public static readonly int HP_ERROR_incorrect_face_tag_mapping = HCSPPINVOKE.HP_ERROR_incorrect_face_tag_mapping_get();
}
