﻿using PCRE.Support;
using PCRE.Wrapper;

namespace PCRE
{
    public class PcrePossibleMatch : PcreMatch
    {
        internal PcrePossibleMatch(MatchResult result)
            : base(result)
        {
        }

        public PcreMatchResult Result
        {
            get { return InternalResult.ResultCode.ToMatchResult(); }
        }

        public bool IsMatch
        {
            get { return ((IPcreGroup)this).IsMatch; }
        }

        public bool IsPartialMatch
        {
            get { return Result == PcreMatchResult.Partial; }
        }

        public int PartialInspectionStartIndex
        {
            get { return IsPartialMatch ? InternalResult.GetPartialScanStartOffset() : -1; }
        }
    }
}
