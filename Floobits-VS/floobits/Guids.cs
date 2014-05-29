// Guids.cs
// MUST match guids.h
using System;

namespace Floobits.Floobits_VS
{
    static class GuidList
    {
        public const string guidFloobits_VSPkgString = "2fe4c11c-d566-44ae-8906-b09bb9f62ea9";
        public const string guidFloobits_VSCmdSetString = "1d2705dc-df9e-4290-acd9-7f93b367a005";
        public const string guidToolWindowPersistanceString = "eb6a0650-08d7-472f-9ff5-e1fb98f78672";


        public static readonly Guid guidFloobits_VSCmdSet = new Guid(guidFloobits_VSCmdSetString);

    };
}