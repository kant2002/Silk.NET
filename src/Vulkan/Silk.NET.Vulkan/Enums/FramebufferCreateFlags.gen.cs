// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkFramebufferCreateFlags")]
    public enum FramebufferCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT_KHR")]
        FramebufferCreateImagelessBitKhr = 1,
        [NativeName("Name", "VK_FRAMEBUFFER_CREATE_IMAGELESS_BIT")]
        FramebufferCreateImagelessBit = 1,
    }
}
