﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using GitCandy;
    using GitCandy.Base;
    using GitCandy.Configuration;
    using GitCandy.Extensions;
    using GitCandy.Models;
    using GitCandy.Web;
    using GitCandy.Web.App_GlobalResources;
    using NewLife;
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Serialization;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Repository/_PathBar.cshtml")]
    public partial class _Views_Repository__PathBar_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.PathBarModel>
    {
        public _Views_Repository__PathBar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Repository\_PathBar.cshtml"
  
    var branch = (Model.ReferenceName ?? Model.ReferenceSha);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<ul");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n    <li>");

            
            #line 7 "..\..\Views\Repository\_PathBar.cshtml"
   Write(Html.ActionLink(Model.Name, Model.Action, new { path = branch }));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n\r\n");

            
            #line 9 "..\..\Views\Repository\_PathBar.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Repository\_PathBar.cshtml"
     if (!String.IsNullOrEmpty(Model.Path))
    {
        var dirs = Model.Path.Split('/');
        var length = dirs.Length;
        var currentPath = String.Empty;
        for (var i = 0; i < length; i++)
        {
            if (i != 0)
            {
                currentPath += "/" + dirs[i];
            }
            else
            {
                currentPath += dirs[i];
            }
            if (i + 1 == length)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 27 "..\..\Views\Repository\_PathBar.cshtml"
               Write(dirs[i]);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </li>\r\n");

            
            #line 29 "..\..\Views\Repository\_PathBar.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li>");

            
            #line 32 "..\..\Views\Repository\_PathBar.cshtml"
               Write(Html.ActionLink(dirs[i], Model.Action, new { path = branch + "/" + currentPath }));

            
            #line default
            #line hidden
WriteLiteral(" </li>\r\n");

            
            #line 33 "..\..\Views\Repository\_PathBar.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n");

        }
    }
}
#pragma warning restore 1591
