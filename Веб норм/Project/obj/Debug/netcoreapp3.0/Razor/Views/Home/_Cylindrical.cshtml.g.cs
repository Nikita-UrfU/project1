#pragma checksum "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281fde61f1872b1bda3d6d88e3defcb5e8293057"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Cylindrical), @"mvc.1.0.view", @"/Views/Home/_Cylindrical.cshtml")]
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
#line 1 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281fde61f1872b1bda3d6d88e3defcb5e8293057", @"/Views/Home/_Cylindrical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e31fbbec8fb4222cf117a26f28137c5b00e63f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Cylindrical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CylindricalDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Cylindrical"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e82930575357", async() => {
                WriteLiteral(@"
    <table>
        <tr>
            <td style=""font-size: 25px""> Исходные данные</td>
        </tr>

        <tr>
            <td>Количество слоев</td>
            <td>
                <select name=""data.LayerCount"" id=""count1"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e82930575879", async() => {
                    WriteLiteral("2 слоя");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 412, Model.LayerCount == 2, 412, 24, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e82930577594", async() => {
                    WriteLiteral("3 слоя");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 17 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 503, Model.LayerCount == 3, 503, 24, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>Положение поверхности</td>\r\n            <td>\r\n                <select name=\"data.Position\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e82930579513", async() => {
                    WriteLiteral("Вертикальное");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 26 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 778, Model.Position == 0, 778, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e829305711230", async() => {
                    WriteLiteral("Горизонтальное");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 871, Model.Position == 1, 871, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e829305712950", async() => {
                    WriteLiteral("Горизонтальное при теплоотдаче вниз");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 966, Model.Position == 2, 966, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Вид поверхности</td>\r\n            <td>\r\n                <select name=\"data.View\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e829305714881", async() => {
                    WriteLiteral("Кирпичные");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 1256, Model.View == 0, 1256, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e829305716594", async() => {
                    WriteLiteral("Стальные");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 1342, Model.View == 1, 1342, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e829305718306", async() => {
                    WriteLiteral("Алюминевая краска");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 1427, Model.View == 2, 1427, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Альфа</td>\r\n            <td>\r\n                <select name=\"data.Alfa\" id=\"count2\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e829305720221", async() => {
                    WriteLiteral("Для естественной конвекции");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 46 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 1697, Model.Alfa == 0, 1697, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "281fde61f1872b1bda3d6d88e3defcb5e829305721951", async() => {
                    WriteLiteral("При принудительной конвекции");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "select", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
AddHtmlAttributeValue("", 1800, Model.Alfa == 1, 1800, 18, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>Температура наружной поверхности стенки</td>\r\n            <td>  <input type=\"number\" name=\"data.TWall\"");
                BeginWriteAttribute("value", " value=\"", 2052, "\"", 2072, 1);
#nullable restore
#line 53 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 2060, Model.TWall, 2060, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Температура внутренней поверхности стенки</td>\r\n            <td>  <input type=\"number\" name=\"data.TWn\"");
                BeginWriteAttribute("value", " value=\"", 2230, "\"", 2248, 1);
#nullable restore
#line 57 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 2238, Model.TWn, 2238, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Температура окружающей среды</td>\r\n            <td> <input type=\"number\" name=\"data.TOkr\"");
                BeginWriteAttribute("value", " value=\"", 2393, "\"", 2412, 1);
#nullable restore
#line 61 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 2401, Model.TOkr, 2401, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"for_U\">Скорость омывающего потока, м/с</td>\r\n            <td class=\"for_U\"><input type=\"text\" name=\"data.U\"");
                BeginWriteAttribute("value", " value=\"", 2582, "\"", 2598, 1);
#nullable restore
#line 65 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 2590, Model.U, 2590, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Радиус R0</td>\r\n            <td> <input type=\"text\" name=\"data.R0\"");
                BeginWriteAttribute("value", " value=\"", 2720, "\"", 2737, 1);
#nullable restore
#line 69 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 2728, Model.R0, 2728, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Радиус R1</td>\r\n            <\r\n            <td> <input type=\"text\" name=\"data.R1\"");
                BeginWriteAttribute("value", " value=\"", 2874, "\"", 2891, 1);
#nullable restore
#line 74 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 2882, Model.R1, 2882, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>Радиус R2</td>\r\n            <\r\n            <td> <input type=\"text\" name=\"data.R2\"");
                BeginWriteAttribute("value", " value=\"", 3028, "\"", 3045, 1);
#nullable restore
#line 79 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 3036, Model.R2, 3036, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"for_3\">Радиус R3</td>\r\n            <td class=\"for_3\"> <input type=\"text\" name=\"data.R3\"");
                BeginWriteAttribute("value", " value=\"", 3195, "\"", 3212, 1);
#nullable restore
#line 83 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 3203, Model.R3, 3203, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>Теплопроводность, Вт/(м^2*K)</td>\r\n            <td>  <input type=\"text\" name=\"data.C1\"");
                BeginWriteAttribute("value", " value=\"", 3356, "\"", 3373, 1);
#nullable restore
#line 88 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 3364, Model.C1, 3364, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            <td>  <input type=\"text\" name=\"data.C2\"");
                BeginWriteAttribute("value", " value=\"", 3435, "\"", 3452, 1);
#nullable restore
#line 89 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 3443, Model.C2, 3443, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n            <td class=\"for_3\">  <input type=\"text\" name=\"data.C3\"");
                BeginWriteAttribute("value", " value=\"", 3528, "\"", 3545, 1);
#nullable restore
#line 90 "C:\Users\AlenaK\Desktop\Веб норм\Project\Views\Home\_Cylindrical.cshtml"
WriteAttributeValue("", 3536, Model.C3, 3536, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <button type=\"submit\" ; style=\"font-size: 25px\"> Расчет </button>\r\n            </td>\r\n        </tr>\r\n\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
$(document).ready(function () {
        function layerCountTrigger() {
            if ($('#count1').val() == ""2"") {
                $('.for_3').hide();
            }
            else {
                $('.for_3').show();
            }
        }

        $('#count1').on('change', layerCountTrigger);

        layerCountTrigger();
    });
</script>
<script>
    $(document).ready(function () {
        $('#count2').on('change', function () {
            if ($(this).val() == ""0"") {
                $('.for_U').hide();
            }
            else {
                $('.for_U').show();
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CylindricalDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
