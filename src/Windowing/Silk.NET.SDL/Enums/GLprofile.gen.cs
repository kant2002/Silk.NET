// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [Flags]
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_video_L238_C9")]
    [NativeName("Name", "SDL_GLprofile")]
    public enum GLprofile : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_CORE")]
        GLContextProfileCore = 0x1,
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_COMPATIBILITY")]
        GLContextProfileCompatibility = 0x2,
        [NativeName("Name", "SDL_GL_CONTEXT_PROFILE_ES")]
        GLContextProfileES = 0x4,
    }
}
