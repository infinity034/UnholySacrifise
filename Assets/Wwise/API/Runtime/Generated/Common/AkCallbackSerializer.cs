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


public class AkCallbackSerializer : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkCallbackSerializer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkCallbackSerializer obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkCallbackSerializer() {
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
          AkUnitySoundEnginePINVOKE.CSharp_delete_AkCallbackSerializer(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static AKRESULT Init() { return (AKRESULT)AkUnitySoundEnginePINVOKE.CSharp_AkCallbackSerializer_Init(); }

  public static void Term() { AkUnitySoundEnginePINVOKE.CSharp_AkCallbackSerializer_Term(); }

  public static global::System.IntPtr Lock() { return AkUnitySoundEnginePINVOKE.CSharp_AkCallbackSerializer_Lock(); }

  public static void Unlock() { AkUnitySoundEnginePINVOKE.CSharp_AkCallbackSerializer_Unlock(); }

  public static void SetLocalOutput(uint in_uErrorLevel, string in_ip, uint in_port, string in_xmlFilePath, uint in_msXmlTranslatorTimeout, uint in_msWaapiTranslatorTimeout) { AkUnitySoundEnginePINVOKE.CSharp_AkCallbackSerializer_SetLocalOutput(in_uErrorLevel, in_ip, in_port, in_xmlFilePath, in_msXmlTranslatorTimeout, in_msWaapiTranslatorTimeout); }

  public static void FreeXmlTranslatorHandle(string in_xmlFilePath, uint in_msXmlTranslatorTimeout) { AkUnitySoundEnginePINVOKE.CSharp_AkCallbackSerializer_FreeXmlTranslatorHandle(in_xmlFilePath, in_msXmlTranslatorTimeout); }

  public static AKRESULT AudioSourceChangeCallbackFunc(bool in_bOtherAudioPlaying, object in_pCookie) { return (AKRESULT)AkUnitySoundEnginePINVOKE.CSharp_AkCallbackSerializer_AudioSourceChangeCallbackFunc(in_bOtherAudioPlaying, in_pCookie != null ? (global::System.IntPtr)in_pCookie.GetHashCode() : global::System.IntPtr.Zero); }

  public AkCallbackSerializer() : this(AkUnitySoundEnginePINVOKE.CSharp_new_AkCallbackSerializer(), true) {
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.