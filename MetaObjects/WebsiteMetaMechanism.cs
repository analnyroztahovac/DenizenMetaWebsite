﻿using SharpDenizenTools.MetaObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenizenMetaWebsite.MetaObjects
{
    public class WebsiteMetaMechanism : WebsiteMetaObject<MetaMechanism>
    {
        public override void LoadHTML()
        {
            HtmlContent = Util.EscapeForHTML(Object.Name);
        }

        public override bool MatchesSearch(string search)
        {
            throw new NotImplementedException();
        }

        public override string GroupingString => Object.MechObject + " Mechanisms";
    }
}
