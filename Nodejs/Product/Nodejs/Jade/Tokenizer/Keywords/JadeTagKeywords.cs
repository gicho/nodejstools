// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;

namespace Microsoft.NodejsTools.Jade
{
    internal static class JadeTagKeywords
    {
        public static bool IsKeyword(string candidate)
        {
            var lower = candidate.ToLowerInvariant();
            return Array.BinarySearch<string>(_keywords, lower) >= 0;
        }

        // must be sorted
        private static string[] _keywords = new string[] {
            "block",
            "extends",
            "include",
            "javascripts",
            "mixin",
            "model",
            "scripts",
            "stylesheets",
        };
    }
}


