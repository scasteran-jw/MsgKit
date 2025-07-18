//
// MessageImportance.cs
//
// Author: Kees van Spelde <sicos2002@hotmail.com>
//
// Copyright (c) 2015-2025 Kees van Spelde (www.magic-sessions.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

// ReSharper disable InconsistentNaming

namespace MsgKit.Enums;

/// <summary>
///     Contains the relative priority of a message.
/// </summary>
/// <remarks>
///     See https://msdn.microsoft.com/en-us/library/cc815346(v=office.15).aspx
/// </remarks>
public enum MessageImportance
{
    /// <summary>
    ///     The message has low importance.
    /// </summary>
    IMPORTANCE_LOW = 0,

    /// <summary>
    ///     The message has normal importance.
    /// </summary>
    IMPORTANCE_NORMAL = 1,

    /// <summary>
    ///     The message has high importance.
    /// </summary>
    IMPORTANCE_HIGH = 2
}