﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
using System.Collections.Generic;

namespace NuGetGallery
{
    public class Windows8PackageCurator : TagBasedPackageCurator
    {
        public Windows8PackageCurator(ICuratedFeedService curatedFeedService)
            : base(curatedFeedService)
        {
        }

        protected override IEnumerable<string> RequiredTags
        {
            get
            {
                yield return "winrt";
                yield return "win8";
                yield return "windows8";
                yield return "winjs";
            }
        }

        protected override string CuratedFeedName
        {
            get { return "windows8-packages"; }
        }
    }
}