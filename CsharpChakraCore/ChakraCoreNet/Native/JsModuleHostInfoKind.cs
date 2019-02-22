﻿namespace ChakraCoreNet.Native
{
    public enum JsModuleHostInfoKind
    {
        Exception = 0x01,

        HostDefined = 0x02,

        NotifyModuleReadyCallback = 0x3,

        FetchImportedModuleCallback = 0x4,

        FetchImportedModuleFromScriptCallback = 0x5,

        Url = 0x6
    }
}