#pragma checksum "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad0ba7cefbb69680ed0f38d089bf9f08163f0c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\_ViewImports.cshtml"
using SocialNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\_ViewImports.cshtml"
using SocialNetwork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
using SocialNetwork.Models.Users.Status;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
using SocialNetwork.Models.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad0ba7cefbb69680ed0f38d089bf9f08163f0c7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f753f9608fdc9f7cfcaef4fd6b8f21361e1f0383", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SocialNetwork.Models.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <div class=\"row\">\r\n                <!-- Form to post a status update -->\r\n");
#nullable restore
#line 14 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                 using (Html.BeginForm("StatusPost", "Status", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.Post.Content));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Post Update\" />\r\n");
#nullable restore
#line 19 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"post-container\" style=\"width: 100%;\">\r\n");
#nullable restore
#line 24 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                     foreach (Post post in Model.User.Posts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""post-container__item"" style=""border: 1px solid black; margin: 15px; padding: 15px;"">
                            <img style=""width: 45px;float:left;margin-right: 10px;"" src=""https://s3-us-west-2.amazonaws.com/s.cdpn.io/111167/balapa.jpg"">
                            <div class=""post__content"">
                                <span class=""post__content-name"">");
#nullable restore
#line 29 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                                            Write(post.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <span class=\"post__content-date\">");
#nullable restore
#line 30 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                                            Write(post.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <div class=\"post__content-status\">");
#nullable restore
#line 31 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                                             Write(post.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 32 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                 using (Html.BeginForm("StatusDelete", "Status", FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1647, "\"", 1669, 1);
#nullable restore
#line 34 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 1655, post.StatusId, 1655, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"statusId\" />\r\n                                    <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 36 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm\">\r\n            <div class=\"row\">\r\n                <div class=\"friend-container\">\r\n");
#nullable restore
#line 46 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                     foreach (ApplicationUser user in Model.FriendSuggestions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"friend-container__item\">\r\n                            <img style=\"width: 100px;\" src=\"https://s3-us-west-2.amazonaws.com/s.cdpn.io/111167/balapa.jpg\" />\r\n                            <span>");
#nullable restore
#line 50 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                             Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 50 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                             Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 51 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                             using (Html.BeginForm("AddFriend", "Friend", FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2604, "\"", 2620, 1);
#nullable restore
#line 53 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 2612, user.Id, 2612, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"userId\" />\r\n                                <input type=\"submit\" value=\"Add Friend\" />\r\n");
#nullable restore
#line 55 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 57 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n </div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad0ba7cefbb69680ed0f38d089bf9f08163f0c711781", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <script>
        ""use strict"";

        var connection = new signalR.HubConnectionBuilder()
            .withUrl(""/global"")
            .configureLogging(signalR.LogLevel.Information)
            .build();

        connection.start().then(
            () => console.log(""connected"")
        ).catch(
            err => console.error(err)
        );

        connection.on(""BroadcastMessage"", function (user, message) {
            console.log('received');
            var msg = message.replace(/&/g, ""&amp;"").replace(/</g, ""&lt;"").replace(/>/g, ""&gt;"");
            var encodedMsg = user + "" says "" + msg;
            var li = document.createElement(""li"");
            li.textContent = encodedMsg;
            alert(encodedMsg);
        });
    </script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SocialNetwork.Models.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
