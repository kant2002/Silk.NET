// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_SHADER_CACHE_MODE")]
    public enum ShaderCacheMode : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "D3D12_SHADER_CACHE_MODE_MEMORY")]
        ShaderCacheModeMemory = 0x0,
        [NativeName("Name", "D3D12_SHADER_CACHE_MODE_DISK")]
        ShaderCacheModeDisk = 0x1,
    }
}
