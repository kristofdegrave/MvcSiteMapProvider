﻿//// -----------------------------------------------------------------------
//// <copyright file="SiteMapLoaderFactory.cs" company="">
//// TODO: Update copyright text.
//// </copyright>
//// -----------------------------------------------------------------------

//namespace MvcSiteMapProvider.Core.Loader
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using System.Text;
//    using MvcSiteMapProvider.Core.Cache;
//    using MvcSiteMapProvider.Core.SiteMap;
//    using MvcSiteMapProvider.Core.SiteMap.Builder;

//    /// <summary>
//    /// TODO: Update summary.
//    /// </summary>
//    public class SiteMapLoaderFactory
//        : ISiteMapLoaderFactory
//    {
//        public SiteMapLoaderFactory(
//            TimeSpan slidingCacheExpiration,
//            ISiteMapCache siteMapCache,
//            ISiteMapCacheKeyGenerator siteMapCacheKeyGenerator,
//            ISiteMapBuilderSetStrategy siteMapBuilderSetStrategy,
//            ISiteMapFactory siteMapFactory
//            )
//        {
//            if (slidingCacheExpiration == null)
//                throw new ArgumentNullException("slidingCacheExpiration");
//            if (siteMapCache == null)
//                throw new ArgumentNullException("siteMapCache");
//            if (siteMapCacheKeyGenerator == null)
//                throw new ArgumentNullException("siteMapCacheKeyGenerator");
//            if (siteMapBuilderSetStrategy == null)
//                throw new ArgumentNullException("siteMapBuilderSetStrategy");
//            if (siteMapFactory == null)
//                throw new ArgumentNullException("siteMapFactory");

//            this.slidingCacheExpiration = slidingCacheExpiration;
//            this.siteMapCache = siteMapCache;
//            this.siteMapCacheKeyGenerator = siteMapCacheKeyGenerator;
//            this.siteMapBuilderSetStrategy = siteMapBuilderSetStrategy;
//            this.siteMapFactory = siteMapFactory;
//        }

//        private readonly TimeSpan slidingCacheExpiration;
//        private readonly ISiteMapCache siteMapCache;
//        private readonly ISiteMapCacheKeyGenerator siteMapCacheKeyGenerator;
//        private readonly ISiteMapBuilderSetStrategy siteMapBuilderSetStrategy;
//        private readonly ISiteMapFactory siteMapFactory;

//        #region ISiteMapLoaderFactory Members

//        public ISiteMapLoader Create()
//        {
//            return new SiteMapLoader(
//                slidingCacheExpiration, 
//                siteMapCache, 
//                siteMapCacheKeyGenerator, 
//                siteMapBuilderSetStrategy, 
//                siteMapFactory);
//        }

//        #endregion
//    }
//}