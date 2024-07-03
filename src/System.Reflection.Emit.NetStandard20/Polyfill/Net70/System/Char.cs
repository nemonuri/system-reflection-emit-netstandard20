// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

#if !NET7_0_OR_GREATER

namespace Net70.System
{
    public static class Char
    {
        //
        // Static Methods
        //

        /// <summary>Indicates whether a character is categorized as an ASCII letter.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is an ASCII letter; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'A' through 'Z', inclusive,
        /// or 'a' through 'z', inclusive.
        /// </remarks>
        public static bool IsAsciiLetter(char c) => (uint)((c | 0x20) - 'a') <= 'z' - 'a';

        /// <summary>Indicates whether a character is categorized as a lowercase ASCII letter.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is a lowercase ASCII letter; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'a' through 'z', inclusive.
        /// </remarks>
        public static bool IsAsciiLetterLower(char c) => IsBetween(c, 'a', 'z');

        /// <summary>Indicates whether a character is categorized as an uppercase ASCII letter.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is a lowercase ASCII letter; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'a' through 'z', inclusive.
        /// </remarks>
        public static bool IsAsciiLetterUpper(char c) => IsBetween(c, 'A', 'Z');

        /// <summary>Indicates whether a character is categorized as an ASCII digit.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is an ASCII digit; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range '0' through '9', inclusive.
        /// </remarks>
        public static bool IsAsciiDigit(char c) => IsBetween(c, '0', '9');

        /// <summary>Indicates whether a character is categorized as an ASCII letter or digit.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <returns>true if <paramref name="c"/> is an ASCII letter or digit; otherwise, false.</returns>
        /// <remarks>
        /// This determines whether the character is in the range 'A' through 'Z', inclusive,
        /// 'a' through 'z', inclusive, or '0' through '9', inclusive.
        /// </remarks>
        public static bool IsAsciiLetterOrDigit(char c) => IsAsciiLetter(c) | IsBetween(c, '0', '9');

        /// <summary>Indicates whether a character is within the specified inclusive range.</summary>
        /// <param name="c">The character to evaluate.</param>
        /// <param name="minInclusive">The lower bound, inclusive.</param>
        /// <param name="maxInclusive">The upper bound, inclusive.</param>
        /// <returns>true if <paramref name="c"/> is within the specified range; otherwise, false.</returns>
        /// <remarks>
        /// The method does not validate that <paramref name="maxInclusive"/> is greater than or equal
        /// to <paramref name="minInclusive"/>.  If <paramref name="maxInclusive"/> is less than
        /// <paramref name="minInclusive"/>, the behavior is undefined.
        /// </remarks>
        public static bool IsBetween(char c, char minInclusive, char maxInclusive) =>
            (uint)(c - minInclusive) <= (uint)(maxInclusive - minInclusive);

        private static bool IsBetween(UnicodeCategory c, UnicodeCategory min, UnicodeCategory max) =>
            (uint)(c - min) <= (uint)(max - min);
    }
}

#endif