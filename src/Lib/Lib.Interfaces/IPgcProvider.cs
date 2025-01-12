﻿// Copyright (c) Richasy. All rights reserved.

using System.Collections.Generic;
using System.Threading.Tasks;
using Bili.Models.App;
using Bili.Models.BiliBili;
using Bili.Models.Data.Appearance;
using Bili.Models.Data.Pgc;
using Bili.Models.Enums;

namespace Bili.Lib.Interfaces
{
    /// <summary>
    /// 提供动漫的数据处理.
    /// </summary>
    public interface IPgcProvider
    {
        /// <summary>
        /// 获取顶部导航（过滤掉网页标签）.
        /// </summary>
        /// <param name="type">动漫类型.</param>
        /// <returns>顶部导航列表.</returns>
        Task<IEnumerable<Models.Data.Community.Partition>> GetAnimeTabsAsync(PgcType type);

        /// <summary>
        /// 获取导航标签所指向的内容详情.
        /// </summary>
        /// <param name="tabId">标签Id.</param>
        /// <returns>内容详情.</returns>
        Task<PgcPageView> GetPageDetailAsync(string tabId);

        /// <summary>
        /// 获取PGC页面详情.
        /// </summary>
        /// <param name="type">类型.</param>
        /// <returns>内容详情.</returns>
        Task<PgcPageView> GetPageDetailAsync(PgcType type);

        /// <summary>
        /// 追番/追剧.
        /// </summary>
        /// <param name="seasonId">剧Id.</param>
        /// <param name="isFollow">是否关注.</param>
        /// <returns>关注结果.</returns>
        Task<bool> FollowAsync(string seasonId, bool isFollow);

        /// <summary>
        /// 获取PGC索引条件.
        /// </summary>
        /// <param name="type">PGC类型.</param>
        /// <returns>PGC索引条件响应.</returns>
        Task<IEnumerable<Filter>> GetPgcIndexFiltersAsync(PgcType type);

        /// <summary>
        /// 获取PGC索引结果.
        /// </summary>
        /// <param name="type">类型.</param>
        /// <param name="queryParameters">查询参数.</param>
        /// <returns>PGC索引结果响应.</returns>
        Task<(bool IsFinished, IEnumerable<SeasonInformation> Items)> GetPgcIndexResultAsync(PgcType type, Dictionary<string, string> queryParameters);

        /// <summary>
        /// 获取PGC内容发布时间线.
        /// </summary>
        /// <param name="type">类型.</param>
        /// <returns>时间轴响应结果.</returns>
        Task<TimelineView> GetPgcTimelinesAsync(PgcType type);

        /// <summary>
        /// 获取播放列表详情.
        /// </summary>
        /// <param name="listId">播放列表Id.</param>
        /// <returns>播放列表响应结果.</returns>
        Task<PgcPlaylist> GetPgcPlaylistAsync(string listId);

        /// <summary>
        /// 从 Biliplus 处获取视频 Id 对应的番剧信息.
        /// </summary>
        /// <param name="videoId">视频 Id.</param>
        /// <returns><see cref="BiliPlusBangumi"/>.</returns>
        Task<BiliPlusBangumi> GetBiliPlusBangumiInformationAsync(string videoId);

        /// <summary>
        /// 重置PGC页面请求的状态.
        /// </summary>
        /// <param name="type">PGC类型.</param>
        void ResetPageStatus(PgcType type);

        /// <summary>
        /// 重置索引页面请求状态.
        /// </summary>
        void ResetIndexStatus();
    }
}
