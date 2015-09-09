﻿//----------------------------------------------------------------------------------------------
//    Copyright 2014 Microsoft Corporation
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System.Collections.Generic;

namespace KAIT.Common.Services.Messages
{
    public interface IConfigSettings
    {
        string RootContentDirectory { get; }
        bool ShowJpgFiles { get; }
        bool ShowPngFiles { get; }
        bool ShowGifFiles { get; }
        bool ShowWmvFiles { get; }
        bool ShowMp4Files { get; }
        List<ZoneDefinition> ZoneDefinitions { get; }
        bool EnableTouchScreen { get; }
        bool EnableDiagnostics { get; } 
    }
}
