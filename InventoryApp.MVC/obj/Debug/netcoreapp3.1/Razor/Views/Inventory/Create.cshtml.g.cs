#pragma checksum "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628ddeb37199b6722ab6a8e78fa5a51d77acb8ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_Create), @"mvc.1.0.razor-page", @"/Views/Inventory/Create.cshtml")]
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
#line 1 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\_ViewImports.cshtml"
using InventoryApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\_ViewImports.cshtml"
using InventoryApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628ddeb37199b6722ab6a8e78fa5a51d77acb8ce", @"/Views/Inventory/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71501f071d19e52ce688c2d83403603ed259e5d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
 using (Html.BeginForm("CreateOrUpdate", "Inventory", FormMethod.Post, new { @id = "newInventoryFrm" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\" row\">\r\n                <div class=\"card\">\r\n                    ");
#nullable restore
#line 11 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\" row\">\r\n                <div class=\"card\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.TextAreaFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\" row\">\r\n                <div class=\"card\">\r\n                    ");
#nullable restore
#line 27 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.LabelFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 30 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.TextAreaFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 33 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\" row\">\r\n                <div class=\"card\">\r\n                    ");
#nullable restore
#line 38 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.LabelFor(model => model.AvailableUnits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.TextBoxFor(model => model.AvailableUnits, Enumerable.Range(1, 100).Select(i => new SelectListItem { Text = i.ToString(), Value = i.ToString() })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.AvailableUnits, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\" row\">\r\n                <div class=\"card\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.LabelFor(model => model.ReOrderLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 52 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.TextBoxFor(model => model.ReOrderLevel, Enumerable.Range(1, 10).Select(i => new SelectListItem { Text = i.ToString(), Value = i.ToString() })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.ReOrderLevel, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\" row\">\r\n                <div class=\"card\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.LabelFor(model => model.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 63 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.TextBoxFor(model => model.UnitPrice, Enumerable.Range(1, 10000).Select(i => new SelectListItem { Text = i.ToString(), Value = i.ToString() })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-group-item-info\">\r\n                    ");
#nullable restore
#line 66 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.UnitPrice, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <br />\r\n            <div class=\"btn rounded\">\r\n                <button type=\"submit\"> Save</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 75 "C:\Users\User\Desktop\Test\InventoryApp\InventoryApp.MVC\Views\Inventory\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "628ddeb37199b6722ab6a8e78fa5a51d77acb8ce11210", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InventoryApp.DTO.InventoryDTO> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InventoryApp.DTO.InventoryDTO> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<InventoryApp.DTO.InventoryDTO>)PageContext?.ViewData;
        public InventoryApp.DTO.InventoryDTO Model => ViewData.Model;
    }
}
#pragma warning restore 1591
