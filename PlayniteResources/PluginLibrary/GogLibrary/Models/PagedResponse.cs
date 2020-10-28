﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCommon.PlayniteResources.PluginLibrary.GogLibrary.Models
{
    public class PagedResponse<T>
    {
        public class Embedded
        {
            public List<T> items;
        }

        public int page;
        public int pages;
        public int total;
        public int limit;
        public Embedded _embedded;
    }
}
