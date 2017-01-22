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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Repository/Commits.cshtml")]
    public partial class _Views_Repository_Commits_cshtml : System.Web.Mvc.WebViewPage<GitCandy.Models.CommitsModel>
    {
        public _Views_Repository_Commits_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Repository\Commits.cshtml"
  
    ViewBag.Title = String.Format(SR.Shared_TitleFormat, String.Format(SR.Repository_CommitsTitle, Model.Name ?? Model.Sha.ToShortSha(), Model.Path));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<h4>");

            
            #line 7 "..\..\Views\Repository\Commits.cshtml"
Write(SR.Repository_HistoryFor);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 7 "..\..\Views\Repository\Commits.cshtml"
                         Write(Html.Link(Model));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n\r\n");

            
            #line 9 "..\..\Views\Repository\Commits.cshtml"
Write(Html.Partial("_PathBar", Model.PathBar));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 11 "..\..\Views\Repository\Commits.cshtml"
 foreach (var commit in Model.Commits)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"border-area\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-9\"");

WriteLiteral(">\r\n                <div");

WriteAttribute("title", Tuple.Create(" title=\"", 457), Tuple.Create("\"", 491)
            
            #line 16 "..\..\Views\Repository\Commits.cshtml"
, Tuple.Create(Tuple.Create("", 465), Tuple.Create<System.Object, System.Int32>(commit.CommitMessageShort
            
            #line default
            #line hidden
, 465), false)
);

WriteLiteral(">");

            
            #line 16 "..\..\Views\Repository\Commits.cshtml"
                                                   Write(Html.ActionLink(commit.CommitMessageShort.ShortString(100), "Commit", new { branch = commit.Sha, path = Model.Path }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <strong");

WriteAttribute("title", Tuple.Create(" title=\"", 642), Tuple.Create("\"", 664)
            
            #line 17 "..\..\Views\Repository\Commits.cshtml"
, Tuple.Create(Tuple.Create("", 650), Tuple.Create<System.Object, System.Int32>(commit.Author
            
            #line default
            #line hidden
, 650), false)
);

WriteLiteral(">");

            
            #line 17 "..\..\Views\Repository\Commits.cshtml"
                                          Write(Html.Link(commit.Author));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n                <span>");

            
            #line 18 "..\..\Views\Repository\Commits.cshtml"
                 Write(SR.Repository_AuthoredAt);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                <span");

WriteAttribute("title", Tuple.Create(" title=\"", 779), Tuple.Create("\"", 806)
            
            #line 19 "..\..\Views\Repository\Commits.cshtml"
, Tuple.Create(Tuple.Create("", 787), Tuple.Create<System.Object, System.Int32>(commit.Author.When
            
            #line default
            #line hidden
, 787), false)
);

WriteLiteral(">");

            
            #line 19 "..\..\Views\Repository\Commits.cshtml"
                                             Write(commit.Author.When.LocalDateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 20 "..\..\Views\Repository\Commits.cshtml"
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Repository\Commits.cshtml"
                 if (commit.Author != commit.Committer)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <strong");

WriteAttribute("title", Tuple.Create(" title=\"", 968), Tuple.Create("\"", 993)
            
            #line 22 "..\..\Views\Repository\Commits.cshtml"
, Tuple.Create(Tuple.Create("", 976), Tuple.Create<System.Object, System.Int32>(commit.Committer
            
            #line default
            #line hidden
, 976), false)
);

WriteLiteral(">");

            
            #line 22 "..\..\Views\Repository\Commits.cshtml"
                                                 Write(Html.Link(commit.Committer));

            
            #line default
            #line hidden
WriteLiteral("</strong>\r\n");

WriteLiteral("                    <span>");

            
            #line 23 "..\..\Views\Repository\Commits.cshtml"
                     Write(SR.Repository_CommittedAt);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                    <span");

WriteAttribute("title", Tuple.Create(" title=\"", 1120), Tuple.Create("\"", 1150)
            
            #line 24 "..\..\Views\Repository\Commits.cshtml"
, Tuple.Create(Tuple.Create("", 1128), Tuple.Create<System.Object, System.Int32>(commit.Committer.When
            
            #line default
            #line hidden
, 1128), false)
);

WriteLiteral(">");

            
            #line 24 "..\..\Views\Repository\Commits.cshtml"
                                                    Write(commit.Committer.When.LocalDateTime.ToFullString());

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 25 "..\..\Views\Repository\Commits.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n            <div");

WriteLiteral(" class=\"col-md-3\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 28 "..\..\Views\Repository\Commits.cshtml"
                                   Write(Html.ActionLink(commit.Sha.ToShortSha(), "Commit", new { branch = commit.Sha }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                <div");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Repository\Commits.cshtml"
                                   Write(Html.ActionLink(SR.Repository_Tree, "Tree", new { branch = commit.Sha }));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");

            
            #line 33 "..\..\Views\Repository\Commits.cshtml"
}

            
            #line default
            #line hidden
            
            #line 34 "..\..\Views\Repository\Commits.cshtml"
Write(Html.Partial("_Pager"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
