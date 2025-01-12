﻿// Copyright (c) Richasy. All rights reserved.

using Bili.Lib.Interfaces;
using Bili.Models.Enums;
using Bili.Toolkit.Interfaces;
using Bili.ViewModels.Uwp.Base;
using Bili.ViewModels.Uwp.Core;

namespace Bili.ViewModels.Uwp.Pgc
{
    /// <summary>
    /// 番剧页视图模型.
    /// </summary>
    public sealed class BangumiPageViewModel : AnimePageViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BangumiPageViewModel"/> class.
        /// </summary>
        public BangumiPageViewModel(
            IPgcProvider pgcProvider,
            IAuthorizeProvider authorizeProvider,
            IHomeProvider homeProvider,
            IResourceToolkit resourceToolkit,
            NavigationViewModel navigationViewModel)
            : base(pgcProvider, authorizeProvider, homeProvider, resourceToolkit, navigationViewModel, PgcType.Bangumi)
        {
        }
    }
}
