#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkDeviceSettings : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkDeviceSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkDeviceSettings obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkDeviceSettings() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkUnitySoundEnginePINVOKE.CSharp_delete_AkDeviceSettings(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public global::System.IntPtr pIOMemory { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_pIOMemory_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_pIOMemory_get(swigCPtr); }
  }

  public uint uIOMemorySize { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemorySize_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemorySize_get(swigCPtr); } 
  }

  public uint uIOMemoryAlignment { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemoryAlignment_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uIOMemoryAlignment_get(swigCPtr); } 
  }

  public uint ePoolAttributes { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_ePoolAttributes_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_ePoolAttributes_get(swigCPtr); } 
  }

  public uint uGranularity { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uGranularity_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uGranularity_get(swigCPtr); } 
  }

  public AkThreadProperties threadProperties { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_threadProperties_set(swigCPtr, AkThreadProperties.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_threadProperties_get(swigCPtr);
      AkThreadProperties ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkThreadProperties(cPtr, false);
      return ret;
    } 
  }

  public float fTargetAutoStmBufferLength { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_fTargetAutoStmBufferLength_get(swigCPtr); } 
  }

  public uint uMaxConcurrentIO { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxConcurrentIO_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxConcurrentIO_get(swigCPtr); } 
  }

  public bool bUseStreamCache { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_bUseStreamCache_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_bUseStreamCache_get(swigCPtr); } 
  }

  public uint uMaxCachePinnedBytes { set { AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxCachePinnedBytes_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkDeviceSettings_uMaxCachePinnedBytes_get(swigCPtr); } 
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.