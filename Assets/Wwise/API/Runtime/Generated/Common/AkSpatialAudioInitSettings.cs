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


public class AkSpatialAudioInitSettings : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkSpatialAudioInitSettings(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkSpatialAudioInitSettings obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkSpatialAudioInitSettings() {
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
          AkUnitySoundEnginePINVOKE.CSharp_delete_AkSpatialAudioInitSettings(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkSpatialAudioInitSettings() : this(AkUnitySoundEnginePINVOKE.CSharp_new_AkSpatialAudioInitSettings(), true) {
  }

  public uint uMaxSoundPropagationDepth { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxSoundPropagationDepth_get(swigCPtr); } 
  }

  public float fMovementThreshold { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMovementThreshold_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMovementThreshold_get(swigCPtr); } 
  }

  public uint uNumberOfPrimaryRays { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uNumberOfPrimaryRays_get(swigCPtr); } 
  }

  public uint uMaxReflectionOrder { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxReflectionOrder_get(swigCPtr); } 
  }

  public uint uMaxDiffractionOrder { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxDiffractionOrder_get(swigCPtr); } 
  }

  public uint uMaxDiffractionPaths { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxDiffractionPaths_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxDiffractionPaths_get(swigCPtr); } 
  }

  public uint uMaxGlobalReflectionPaths { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxGlobalReflectionPaths_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxGlobalReflectionPaths_get(swigCPtr); } 
  }

  public uint uMaxEmitterRoomAuxSends { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uMaxEmitterRoomAuxSends_get(swigCPtr); } 
  }

  public uint uDiffractionOnReflectionsOrder { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uDiffractionOnReflectionsOrder_get(swigCPtr); } 
  }

  public float fMaxDiffractionAngleDegrees { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMaxDiffractionAngleDegrees_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMaxDiffractionAngleDegrees_get(swigCPtr); } 
  }

  public float fMaxPathLength { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMaxPathLength_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fMaxPathLength_get(swigCPtr); } 
  }

  public float fCPULimitPercentage { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fCPULimitPercentage_get(swigCPtr); } 
  }

  public float fSmoothingConstantMs { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fSmoothingConstantMs_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_fSmoothingConstantMs_get(swigCPtr); } 
  }

  public uint uLoadBalancingSpread { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_uLoadBalancingSpread_get(swigCPtr); } 
  }

  public bool bEnableGeometricDiffractionAndTransmission { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_bEnableGeometricDiffractionAndTransmission_get(swigCPtr); } 
  }

  public bool bCalcEmitterVirtualPosition { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_bCalcEmitterVirtualPosition_get(swigCPtr); } 
  }

  public AkTransmissionOperation eTransmissionOperation { set { AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_eTransmissionOperation_set(swigCPtr, (int)value); }  get { return (AkTransmissionOperation)AkUnitySoundEnginePINVOKE.CSharp_AkSpatialAudioInitSettings_eTransmissionOperation_get(swigCPtr); } 
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.