// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_FILTER_TYPE")]
    public enum FilterType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "D3D11_FILTER_TYPE_POINT")]
        FilterTypePoint = 0x0,
        [NativeName("Name", "D3D11_FILTER_TYPE_LINEAR")]
        FilterTypeLinear = 0x1,
    }
}
