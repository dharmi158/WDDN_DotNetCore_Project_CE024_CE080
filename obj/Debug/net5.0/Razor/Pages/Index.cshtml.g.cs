#pragma checksum "C:\Users\Balaji\source\repos\SignalRChatDemo\SignalRChatDemo\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "513fd9fa758a475c357bf9bbde460b66ad7bdaba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SignalRChatDemo.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SignalRChatDemo.Pages
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
#line 1 "C:\Users\Balaji\source\repos\SignalRChatDemo\SignalRChatDemo\Pages\_ViewImports.cshtml"
using SignalRChatDemo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"513fd9fa758a475c357bf9bbde460b66ad7bdaba", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"469f98c7865b7c8aec249612d1c1133aebaa2104", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
    <div class=""container"">
        <div id=""userinfo"" class=""row"">
            <label>Enter your Username</label>
            <input type=""text"" class=""form-control"" id=""username"" name=""username"" autocomplete=""off"" />
            <button type=""button"" class=""btn btn-block"" onclick=""SetUsername();""> join</button>
        </div>
        <div id=""messagearea"" class=""row"" style=""display:none;"">
            <div> Logged in as :<b><span id=""username1"">Not set</span></b></div><hr />
            <div class=""row"">
                <div class=""col-6"">
                    <ul id=""messagelist""></ul>
                </div>
            </div>
            <hr />
            <input type=""text"" class=""form-control"" id=""message"" autocomplete=""off"" />
            <input type=""button"" id=""sendbutton"" value=""send message"" />
        </div>
    </div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "513fd9fa758a475c357bf9bbde460b66ad7bdaba4236", async() => {
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
        var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();
        var username = """";

        document.getElementById(""sendbutton"").disabled = true;

        connection.on(""ReceiveMessage"", function (Username, message) {
            var li = document.createElement(""li"");
            var msg = message.replace(/&/g, ""&amp;"").replace(/</g, ""&lt;"").replace(/>/g, ""&gt;"");
            var encodingmsg = Username + "" Says : "" + msg;
            li.textContent = encodingmsg;
            document.getElementById(""messagelist"").appendChild(li);

            // li.textContent = `${Username} says ${msg}`;

        }
        );
        connection.start().then(function () {
            document.getElementById(""sendbutton"").disabled = false;
        }).catch(function (err) {
            return console.error(err.tostring());

        });
        document.getElementById(""sendbutton"").addEventListener(""click"", function (event) {
        ");
            WriteLiteral(@"    var message = document.getElementById(""message"").value;
            var Username = document.getElementById(""username"").value;
            connection.invoke(""SendMessage"", Username, message).then(function () {
                document.getElementById(""message"").value = """";
            }).catch(function (err) {
                return console.error(err.tostring());
            });
            event.preventDefault();
        });

        function SetUsername() {
            var usernameinput = document.getElementById(""username"").value;
            if (usernameinput === """") {
                alert(""please enter username"");
                return;
            }
            username = usernameinput;
            document.getElementById(""userinfo"").style.display = 'none';
            document.getElementById(""messagearea"").style.display = 'block';
            document.getElementById(""username1"").innerText = usernameinput;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Index>)PageContext?.ViewData;
        public Pages_Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
