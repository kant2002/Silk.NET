// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_render_L64_C9")]
    [NativeName("Name", "SDL_RendererFlags")]
    public enum RendererFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "SDL_RENDERER_SOFTWARE")]
        RendererSoftware = 0x1,
        [NativeName("Name", "SDL_RENDERER_ACCELERATED")]
        RendererAccelerated = 0x2,
        [NativeName("Name", "SDL_RENDERER_PRESENTVSYNC")]
        RendererPresentvsync = 0x4,
        [NativeName("Name", "SDL_RENDERER_TARGETTEXTURE")]
        RendererTargettexture = 0x8,
    }
}
