﻿namespace ChakraCoreNet
{
    public enum JsModuleHostInfoKind
    {
        JsModuleHostInfo_Exception = 0x01,

        JsModuleHostInfo_HostDefined = 0x02,

        JsModuleHostInfo_NotifyModuleReadyCallback = 0x3,

        JsModuleHostInfo_FetchImportedModuleCallback = 0x4,

        JsModuleHostInfo_FetchImportedModuleFromScriptCallback = 0x5,

        JsModuleHostInfo_Url = 0x6
    }
}