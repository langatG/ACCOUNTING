#pragma checksum "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a486604e01d6b77b5beac303be56f5d152bdcc2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AccountingSystem.Pages.Accounting.Pages_Accounting_BackCash), @"mvc.1.0.razor-page", @"/Pages/Accounting/BackCash.cshtml")]
namespace AccountingSystem.Pages.Accounting
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a486604e01d6b77b5beac303be56f5d152bdcc2f", @"/Pages/Accounting/BackCash.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a56f8c2dd73028c9204c690f3202789a632028e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Accounting_BackCash : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"modal-content hold-transition login-page\">\r\n\t<div class=\"modal-header\" ;color:white;text-align:center\">\r\n\t\t<h5 class=\"modal-title w-100 text-center\">Bank AND Cash</h5>\r\n\t</div>\r\n\t<div class=\"modal-body\">\r\n\t\t<div id=\"accordion\">\r\n");
#nullable restore
#line 12 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
             foreach (var bank in Model.Banks)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"card\">\r\n\t\t\t\t\t<div class=\"card-header row\" id=\"headingTwo\">\r\n\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\t<h5 class=\"mb-0\">\r\n\t\t\t\t\t\t\t\t<button class=\"btn btn-link collapsed\" data-toggle=\"collapse\" data-target=\"#");
#nullable restore
#line 18 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                                                                                                       Write(bank.Ref);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\" aria-controls=\"collapseTwo\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 19 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                               Write(bank.Ref);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</button>\r\n\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\tDr: ");
#nullable restore
#line 24 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                           Write(bank.Debit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-sm-4\">\r\n\t\t\t\t\t\t\tCr: ");
#nullable restore
#line 27 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                           Write(bank.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div");
            BeginWriteAttribute("id", " id=\"", 863, "\"", 877, 1);
#nullable restore
#line 30 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
WriteAttributeValue("", 868, bank.Ref, 868, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordion"">
						<div class=""card-body table-responsive"">
							<table class=""table table-sm table-hover"">
								<thead>
									<tr>
										<th scope=""col"">GL Account</th>
										<th scope=""col"">Debit</th>
										<th scope=""col"">Credit</th>
									</tr>
								</thead>
								<tbody>
");
#nullable restore
#line 41 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                                     foreach (var detail in bank.Details)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 44 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                                           Write(detail.GlAccount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 45 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                                           Write(detail.Debit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
#nullable restore
#line 46 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
                                           Write(detail.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 48 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t\t\t</table>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 54 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Accounting\BackCash.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountingSystem.Pages.Accounting.BackCashModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountingSystem.Pages.Accounting.BackCashModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountingSystem.Pages.Accounting.BackCashModel>)PageContext?.ViewData;
        public AccountingSystem.Pages.Accounting.BackCashModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
