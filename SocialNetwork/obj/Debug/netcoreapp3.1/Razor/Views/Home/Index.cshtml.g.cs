#pragma checksum "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3bae9b2c52edf9b7cafbd6cadf8a7258e51f126"
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
using SocialNetwork.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3bae9b2c52edf9b7cafbd6cadf8a7258e51f126", @"/Views/Home/Index.cshtml")]
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
#line 7 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm\">\r\n            <div class=\"row\">\r\n                <!-- Form to post a status update -->\r\n");
#nullable restore
#line 16 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                 using (Html.BeginForm("StatusPost", "Status", FormMethod.Post))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
               Write(Html.LabelFor(m => m.Post.Content));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
               Write(Html.TextBoxFor(m => m.Post.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"submit\" value=\"Post Update\" />\r\n");
#nullable restore
#line 21 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>

            <div class=""row"">
                <div class=""post-container"" style=""width: 100%;"">
                    <div class=""post-container__item"">
                        <h3>carlf</h3><br />
                        Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ea, iusto, maxime, ullam autem a voluptate rem quos repudiandae.
                        <div class=""over-bubble"">
                            <div class=""icon-mail-reply action""></div>
                            <div class=""icon-retweet action""></div>
                            <div class=""icon-star""></div>
                        </div>
                    </div>
                <!--   
                    {
                        <div class=""post-container__item"" style=""border: 1px solid black; margin: 15px; padding: 15px;"">
                            <img style=""width: 45px;float:left;margin-right: 10px;"" src=""https://s3-us-west-2.amazonaws.com/s.cdpn.io/111167/balapa.jpg"">
                  ");
            WriteLiteral(@"          <div class=""post__content"">
                                <span class=""post__content-name""></span>
                                <span class=""post__content-date""></span>
                                <div class=""post__content-status""></div>
");
#nullable restore
#line 43 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                 using (Html.BeginForm("StatusDelete", "Status", FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2221, "\"", 2229, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"statusId\" />\r\n                                    <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 47 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                    }-->
                </div>
            </div>
        </div>
        <div class=""col-sm"">
            <div class=""row"">
                <div class=""friend-container"">
");
#nullable restore
#line 57 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                     foreach (ApplicationUser user in Model.FriendSuggestions)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"friend-container__item\">\r\n                            <img style=\"width: 100px;\" src=\"https://s3-us-west-2.amazonaws.com/s.cdpn.io/111167/balapa.jpg\" />\r\n                            <span>");
#nullable restore
#line 61 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                             Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 61 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                             Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                             if (!Model.User.IsFriend(Model.User.Id, user.Id))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                 using (Html.BeginForm("AddFriend", "Friend", FormMethod.Post))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                               Write(Html.Hidden("UserId", Model.User.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                                                         ;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                               Write(Html.Hidden("FriendId", user.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                                                     ;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"submit\" value=\"Add Friend\" />\r\n");
#nullable restore
#line 70 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                 
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                 using (Html.BeginForm("RemoveFriend", "Friend", FormMethod.Post))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                               Write(Html.Hidden("UserId", Model.User.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                                                         ;
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                               Write(Html.Hidden("FriendId", user.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                                                     ;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"submit\" value=\"Remove Friend\" />\r\n");
#nullable restore
#line 80 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 83 "C:\Users\mjames\source\repos\Social Networking Website In ASP.NET\SocialNetwork\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3bae9b2c52edf9b7cafbd6cadf8a7258e51f12614103", async() => {
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
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
