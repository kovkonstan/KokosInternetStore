#pragma checksum "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e45e3f5664bb709ec19b96b833f394fde221a95a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\_ViewImports.cshtml"
using KokosInternetStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\_ViewImports.cshtml"
using Kokos_Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
using Kokos_Utility;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e45e3f5664bb709ec19b96b833f394fde221a95a", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7713141711761095145e7ac6a624f03397edf1fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Clear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("Update"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Обновить корзину"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_18 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e3f5664bb709ec19b96b833f394fde221a95a10447", async() => {
                WriteLiteral(@"
    <br />
    <div class=""backgroundWhiteBorder"">
        <div class=""container row"">
            <div class=""col -8"">
                <div class=""card mt-4"">
                    <div class=""card-header bg-dark text-light ml-0 row container"">
                        <div class=""col-6"">
                            <i class=""fa fa-shopping-cart""></i> &nbsp;
                            Корзина
                        </div>
                        <div class=""col-6 text-right"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e3f5664bb709ec19b96b833f394fde221a95a11241", async() => {
                    WriteLiteral("Очистить корзину");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e3f5664bb709ec19b96b833f394fde221a95a12586", async() => {
                    WriteLiteral("Продолжить покупки");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                     if (Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""card-body"">
                            <div class="" d-none d-lg-block"">
                                <div class=""row"" style=""color:#821f3d"">
                                    <div class=""col-lg-2"">
                                    </div>
");
#nullable restore
#line 27 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstants.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-12 col-lg-3\">\r\n                                            Сведения о товаре\r\n                                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-12 col-lg-7\">\r\n                                            Сведения о товаре\r\n                                        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-12 col-lg-2\">\r\n                                        Цена товара\r\n                                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstants.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <div class=""col-6 col-lg-2"">
                                            Количество
                                        </div>
                                        <div class=""col-6Ы col-lg-2"">
                                            Общая цена
                                        </div>
");
#nullable restore
#line 50 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-6 col-sm-4 col-lg-1\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n                            <hr />\r\n");
#nullable restore
#line 57 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                              
                                var orderTotal = 0.0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                             for (int i = 0; i < Model.Count(); i++)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e45e3f5664bb709ec19b96b833f394fde221a95a18068", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 62 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <div class=\"row h-100\">\r\n                                    <div class=\"col-4 col-md-2 text-center py-2\">\r\n                                        <img");
                BeginWriteAttribute("src", " src=\"", 3250, "\"", 3294, 2);
#nullable restore
#line 65 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3256, WebConstants.ImagePath, 3256, 23, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3279, Model[i].Image, 3279, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"rounded\" width=\"100%\" />\r\n                                    </div>\r\n");
#nullable restore
#line 67 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstants.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-8 col-lg-3\">\r\n                                            <h5>");
#nullable restore
#line 70 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                            <div style=\"font-size:11px;\">");
#nullable restore
#line 71 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                                                    Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                        </div>\r\n");
#nullable restore
#line 73 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"

                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-8 col-lg-7\">\r\n                                            <h5>");
#nullable restore
#line 78 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                           Write(Model[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                            <div style=\"font-size:11px;\">");
#nullable restore
#line 79 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                                                    Write(Model[i].ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                        </div>\r\n");
#nullable restore
#line 81 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                        <span style=\"font-size:17px;\"> ");
#nullable restore
#line 83 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                                                  Write(Model[i].Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n\r\n                                    </div>\r\n");
#nullable restore
#line 86 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstants.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <div class=\"col-4 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e45e3f5664bb709ec19b96b833f394fde221a95a24386", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 89 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].TempQuantity);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e3f5664bb709ec19b96b833f394fde221a95a26244", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 90 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].TempQuantity);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                        </div>\r\n                                        <div class=\"col-3 col-lg-2 pt-lg-4\" style=\"font-size:11px;\">\r\n                                            <span style=\"font-size:17px;\"> ");
#nullable restore
#line 94 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                                                       Write((Model[i].Price* Model[i].TempQuantity).ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                        </div>\r\n");
#nullable restore
#line 96 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"col-2 col-lg-1 p-0 pt-lg-4 text-center\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e45e3f5664bb709ec19b96b833f394fde221a95a28955", async() => {
                    WriteLiteral("\r\n                                            <i class=\"fas fa-trash\"></i>\r\n                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                                                 WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                                <hr />\r\n");
#nullable restore
#line 105 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                orderTotal += Model[i].Price * Model[i].TempQuantity;
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                             if (User.IsInRole(WebConstants.AdminRole))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"row\">\r\n                                    <div class=\"col-12 text-right pr-4\" style=\"color:#821f3d\">\r\n                                        Общая стоимость заказа: ");
#nullable restore
#line 111 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                                           Write(string.Format("{0:c}", orderTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 114 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                        <div class=\"card-footer\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-6 col-md-3 offset-md-6\">\r\n");
#nullable restore
#line 119 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                     if (User.IsInRole(WebConstants.AdminRole))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e45e3f5664bb709ec19b96b833f394fde221a95a33670", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </input>\r\n");
#nullable restore
#line 125 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </div>
                                <div class=""col-6 col-md-3"">
                                    <button type=""submit"" class=""btn btn-success form-control "">
                                        <span>Продолжить</span>
                                    </button>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 134 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                      
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <h3 class=\"text-center m-5\">Добавьте товары в корзину</h3>\r\n");
#nullable restore
#line 139 "C:\Users\Администратор\source\repos\KokosInternetStore\KokosInternetStore\Views\Cart\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_17.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e45e3f5664bb709ec19b96b833f394fde221a95a38247", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_18.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_18);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
