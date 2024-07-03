// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;

#if !NETSTANDARD2_1
namespace Netstandard21.System.Text
{
    public static class StringBuilderExtensions
    {
        public unsafe static StringBuilder Append(this StringBuilder self, ReadOnlySpan<char> value)
        {
            fixed (char* head = value)
            {
                self.Append(head, value.Length);
            }
            return self;
        }
    }
}
#endif