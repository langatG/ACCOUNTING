#pragma checksum "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "740e0382de537afdb5e094296a066855d30fb0fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AccountingSystem.Pages.Vendors.bill.Pages_Vendors_bill_Listbill), @"mvc.1.0.razor-page", @"/Pages/Vendors/bill/Listbill.cshtml")]
namespace AccountingSystem.Pages.Vendors.bill
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740e0382de537afdb5e094296a066855d30fb0fb", @"/Pages/Vendors/bill/Listbill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a56f8c2dd73028c9204c690f3202789a632028e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vendors_bill_Listbill : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditBill", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
  
	var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf/1.5.3/jspdf.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jspdf-autotable/3.5.6/jspdf.plugin.autotable.min.js""></script>

<div>
	<div class=""row color m-1"" style=""color:green"">Bills</div>
	<div class=""modal-header"" style=""background-color:white;color:white;text-align:center"">
		");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740e0382de537afdb5e094296a066855d30fb0fb5176", async() => {
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
            WriteLiteral("\r\n\t\t<input type=\"button\" onclick=\"generate()\" value=\"Export To PDF\" />\r\n\t</div>\r\n\t<div class=\"table-responsive\">\r\n");
#nullable restore
#line 16 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
         if (!Model.Success)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"alert-danger text-center\" id=\"simple_table\">\r\n\t\t\t\t");
#nullable restore
#line 19 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
           Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n");
#nullable restore
#line 21 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		<table class=""table table-sm table-hover"">
			<thead>
				<tr>
					<th scope=""col"">#</th>
					<th scope=""col"">Ref</th>
					<th scope=""col"">Vender</th>
					<th scope=""col"">Date</th>
					<th scope=""col"">Due Date</th>
					<th scope=""col"">Net Amount</th>
					<th scope=""col"">Tax</th>
					<th scope=""col"">Total</th>
					<th scope=""col"">Status</th>
					<th scope=""col"">Personnel</th>
				</tr>
			</thead>
			<tbody>
");
#nullable restore
#line 38 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                 foreach (var bill in Model.Bills)
				{
					count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<th scope=\"row\">");
#nullable restore
#line 42 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 43 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.Ref);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 44 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.Vender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 45 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 46 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 47 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.NetAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 48 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.Tax);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 49 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 50 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 51 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
                       Write(bill.Personnel);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "740e0382de537afdb5e094296a066855d30fb0fb11586", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<button class=\"btn btn-default\">View</button>\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2053, "\"", 2069, 1);
#nullable restore
#line 60 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
WriteAttributeValue("", 2061, bill.Id, 2061, 8, false);

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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 66 "F:\2021\evans\Accounting\Accounting\Accounts\ODOO\AccountingSystem\AccountingSystem\Pages\Vendors\bill\Listbill.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			</tbody>
		</table>
	</div>
	<script type=""text/javascript"">
        function generate() {
            var doc = new jsPDF('p', 'pt', 'letter');
            var htmlstring = '';
            var tempVarToCheckPageHeight = 0;
            var pageHeight = 0;
            pageHeight = doc.internal.pageSize.height;
            specialElementHandlers = {
                // element with id of ""bypass"" - jQuery style selector
                '#bypassme': function (element, renderer) {
                    // true = ""handled elsewhere, bypass text extraction""
                    return true
                }
            };
            margins = {
                top: 150,
                bottom: 60,
                left: 40,
                right: 40,
                width: 600
            };
            var y = 20;
            doc.setLineWidth(2);
            doc.text(200, y = y + 30, ""BILLS LIST"");
            doc.autoTable({
                html: ""#simple_table"",
                startY");
            WriteLiteral(@": 70,
                theme: 'grid',
                columnStyles: {
                    0: {
                        cellWidth: 0,
                    },
                    1: {
                        cellWidth: 0,
                    },
                    2: {
                        cellWidth: 0,
                    }
                },
                styles: {
                    minCellHeight: 40
                }
            })
            doc.save('Bills.pdf');
        }
	</script>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccountingSystem.Pages.Vendors.ListBillModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountingSystem.Pages.Vendors.ListBillModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AccountingSystem.Pages.Vendors.ListBillModel>)PageContext?.ViewData;
        public AccountingSystem.Pages.Vendors.ListBillModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
