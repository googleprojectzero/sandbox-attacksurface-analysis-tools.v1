﻿//  Copyright 2022 Google LLC. All Rights Reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using NtApiDotNet.Utilities.Reflection;
using System;

namespace NtApiDotNet.Win32.Security.CredUI
{
    /// <summary>
    /// Flags for the SSPI credential prompt.
    /// </summary>
    [Flags]
    public enum SspiCredentialPromptDialogFlags
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        None = 0,
        [SDKName("SSPIPFC_CREDPROV_DO_NOT_SAVE")]
        DoNotSave = 1,
        [SDKName("SSPIPFC_NO_CHECKBOX")]
        NoCheckbox = 2,
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}