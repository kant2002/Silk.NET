// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoDecodeCapabilityFlagsKHR")]
    public enum VideoDecodeCapabilityFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_VIDEO_DECODE_CAPABILITY_DEFAULT_KHR")]
        VideoDecodeCapabilityDefaultKhr = 0,
        [NativeName("Name", "VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_COINCIDE_BIT_KHR")]
        VideoDecodeCapabilityDpbAndOutputCoincideBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_DECODE_CAPABILITY_DPB_AND_OUTPUT_DISTINCT_BIT_KHR")]
        VideoDecodeCapabilityDpbAndOutputDistinctBitKhr = 2,
    }
}
