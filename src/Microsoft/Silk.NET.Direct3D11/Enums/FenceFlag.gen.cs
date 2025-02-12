// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_FENCE_FLAG")]
    public enum FenceFlag : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "D3D11_FENCE_FLAG_NONE")]
        FenceFlagNone = 0x0,
        [NativeName("Name", "D3D11_FENCE_FLAG_SHARED")]
        FenceFlagShared = 0x2,
        [NativeName("Name", "D3D11_FENCE_FLAG_SHARED_CROSS_ADAPTER")]
        FenceFlagSharedCrossAdapter = 0x4,
        [NativeName("Name", "D3D11_FENCE_FLAG_NON_MONITORED")]
        FenceFlagNonMonitored = 0x8,
    }
}
