﻿using System;
using PCRE.Wrapper;

namespace PCRE
{
    [Flags]
    public enum PcreMatchOptions : long
    {
        None = 0,

        Anchored = PatternOptions.Anchored,

        NotBeginningOfLine = PatternOptions.NotBol,
        NotEndOfLine = PatternOptions.NotEol,
        NotEmpty = PatternOptions.NotEmpty,
        NotEmptyAtStart = PatternOptions.NotEmptyAtStart,

        NewLineCr = PatternOptions.NewLineCr,
        NewLineLf = PatternOptions.NewLineLf,
        NewLineCrLf = PatternOptions.NewLineCrLf,
        NewLineAny = PatternOptions.NewLineAny,
        NewLineAnyCrLf = PatternOptions.NewLineAnyCrLf,

        NoStartOptimize = PatternOptions.NoStartOptimize,

        PartialSoft = PatternOptions.PartialSoft,
        PartialHard = PatternOptions.PartialHard
    }
}
