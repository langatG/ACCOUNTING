#pragma checksum "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e98f2d609c58b6bda0f2f36d37d4deba3bb489e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AccountingSystem.Pages.Configuration.Pages_Configuration_ListDefferredRevenueModels), @"mvc.1.0.razor-page", @"/Pages/Configuration/ListDefferredRevenueModels.cshtml")]
namespace AccountingSystem.Pages.Configuration
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
#line 1 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\_ViewImports.cshtml"
using AccountingSystem;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e98f2d609c58b6bda0f2f36d37d4deba3bb489e", @"/Pages/Configuration/ListDefferredRevenueModels.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a56f8c2dd73028c9204c690f3202789a632028e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Configuration_ListDefferredRevenueModels : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditDefferredRevenueModel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
  
	var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\t<div class=\"modal-header\" style=\"background-color:white;color:white;text-align:center\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e98f2d609c58b6bda0f2f36d37d4deba3bb489e5352", async() => {
                WriteLiteral("CREATE");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n\t<div class=\"table-responsive\">\r\n");
#nullable restore
#line 11 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
         if (!Model.Success)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert-danger text-center\">\r\n\t\t\t\t");
#nullable restore
#line 14 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
           Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 16 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<table class=""table table-sm table-hover"">
			<thead>
				<tr>
					<th scope=""col"">#</th>
					<th scope=""col"">Name</th>
					<th scope=""col"">GL Account</th>
					<th scope=""col"">Depreciation Method</th>
					<th scope=""col"">Depreciation Duration</th>
					<th scope=""col"">Depreciation GL Account</th>
					<th scope=""col"">Revenue GL Account</th>
					<th scope=""col"">Journal</th>
					<th scope=""col"">Personnel</th>
				</tr>
			</thead>
			<tbody>
");
#nullable restore
#line 32 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                 foreach (var revenueModel in Model.DefferredRevenueModels)
				{
					count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<th scope=\"row\">");
#nullable restore
#line 36 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 37 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 38 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.GlAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 39 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.DepreciationMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 40 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.DepreciationDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 41 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.DepreciationGlAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 42 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.RevenueGlAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 43 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.Journal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 44 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
                       Write(revenueModel.Personnel);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
						<td class=""text-right"">
							<div class=""dropdown"">
								<a class=""btn btn-sm btn-icon-only text-dark"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
									<i class=""fas fa-ellipsis-v""></i>
								</a>
								<div class=""dropdown-menu dropdown-menu-right dropdown-menu-arrow"">
									");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e98f2d609c58b6bda0f2f36d37d4deba3bb489e11777", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<button class=\"btn btn-default\">Edit</button>\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1885, "\"", 1909, 1);
#nullable restore
#line 53 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
WriteAttributeValue("", 1893, revenueModel.Id, 1893, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e98f2d609c58b6bda0f2f36d37d4deba3bb489e14021", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<button class=\"btn btn-default\">Delete</button>\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2089, "\"", 2113, 1);
#nullable restore
#line 57 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
WriteAttributeValue("", 2097, revenueModel.Id, 2097, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\t\t\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 63 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Configuration\ListDefferredRevenueModels.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountingSystem.Pages.Configuration.ListDefferredRevenueModelsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountingSystem.Pages.Configuration.ListDefferredRevenueModelsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountingSystem.Pages.Configuration.ListDefferredRevenueModelsModel>)PageContext?.ViewData;
        public AccountingSystem.Pages.Configuration.ListDefferredRevenueModelsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
