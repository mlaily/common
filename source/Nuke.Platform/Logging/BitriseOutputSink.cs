﻿// Copyright 2018 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using JetBrains.Annotations;
using Nuke.Platform.Utilities;

namespace Nuke.Platform.Logging
{
    [UsedImplicitly]
    [ExcludeFromCodeCoverage]
    public class BitriseOutputSink : ConsoleOutputSink
    {
        public override IDisposable WriteBlock(string text)
        {
            Info(FigletTransform.GetText(text, "ansi-shadow"));
            return DelegateDisposable.CreateBracket();
        }
    }
}