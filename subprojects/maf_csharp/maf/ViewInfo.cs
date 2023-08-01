//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace maf {

public class ViewInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ViewInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ViewInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ViewInfo obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~ViewInfo() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          mafPINVOKE.delete_ViewInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Pose pose {
    set {
      mafPINVOKE.ViewInfo_pose_set(swigCPtr, Pose.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = mafPINVOKE.ViewInfo_pose_get(swigCPtr);
      Pose ret = (cPtr == global::System.IntPtr.Zero) ? null : new Pose(cPtr, false);
      return ret;
    } 
  }

  public Camera camera {
    set {
      mafPINVOKE.ViewInfo_camera_set(swigCPtr, Camera.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = mafPINVOKE.ViewInfo_camera_get(swigCPtr);
      Camera ret = (cPtr == global::System.IntPtr.Zero) ? null : new Camera(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_a_4__float objectTransform {
    set {
      mafPINVOKE.ViewInfo_objectTransform_set(swigCPtr, SWIGTYPE_p_a_4__float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = mafPINVOKE.ViewInfo_objectTransform_get(swigCPtr);
      SWIGTYPE_p_a_4__float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_a_4__float(cPtr, false);
      return ret;
    } 
  }

  public ViewInfo() : this(mafPINVOKE.new_ViewInfo(), true) {
  }

}

}
