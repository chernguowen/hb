#pragma checksum "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ff06403c88843928b4dcdeba9f4c8d121c28cb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_NewsAdd), @"mvc.1.0.view", @"/Areas/Admin/Views/News/NewsAdd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/NewsAdd.cshtml", typeof(AspNetCore.Areas_Admin_Views_News_NewsAdd))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ff06403c88843928b4dcdeba9f4c8d121c28cb2", @"/Areas/Admin/Views/News/NewsAdd.cshtml")]
    public class Areas_Admin_Views_News_NewsAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsPublish.Model.Response.ResponseModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
  
    ViewData["Title"] = "NewsAdd";

#line default
#line hidden
            BeginContext(94, 27, true);
            WriteLiteral("\r\n<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(121, 1013, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff06403c88843928b4dcdeba9f4c8d121c28cb23278", async() => {
                BeginContext(127, 1000, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""renderer"" content=""webkit|ie-comp|ie-stand"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"" />
    <meta http-equiv=""Cache-Control"" content=""no-siteapp"" />
    <!--[if lt IE 9]>
    <script type=""text/javascript"" src=""/Admin/js/html5.js""></script>
    <script type=""text/javascript"" src=""/Admin/js/respond.min.js""></script>
    <script type=""text/javascript"" src=""/Admin/js/PIE_IE678.js""></script>
    <![endif]-->
    <link type=""text/css"" rel=""stylesheet"" href=""/Admin/css/H-ui.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""/Admin/css/H-ui.admin.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""/Admin/font/font-awesome.min.css"" />
    <!--[if IE 7]>
    <link href=""/Admin/font/font-awesome-ie7.min.css"" rel=""stylesheet"" type=""text/css"" />
    <![endif]-->
    <title>添加新闻</title>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1134, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1136, 3660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ff06403c88843928b4dcdeba9f4c8d121c28cb25516", async() => {
                BeginContext(1142, 871, true);
                WriteLiteral(@"
    <div class=""pd-20"">
        <div class=""Huiform"">
            <form   method=""post"" enctype=""multipart/form-data"" id=""addForm"">
                <table class=""table table-bg"">
                    <tbody>
                        <tr>
                            <th width=""300"" class=""text-r""><span class=""c-red"">*</span> 新闻标题：</th>
                            <td>
                                <input type=""text"" style=""width:300px"" class=""input-text"" value="""" placeholder="""" id=""Title"" name=""Title"" datatype=""*2-16"" nullmsg=""新闻标题不能为空"">
                            </td>
                        </tr>
                        <tr>
                            <th class=""text-r""><span class=""c-red"">*</span> 新闻类别：</th>
                            <td>
                                <select class=""select"" id=""NewsClassifyId"" name=""NewsClassifyId"">
");
                EndContext();
#line 44 "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                     if (Model.code == 200)
                                    {
                                        

#line default
#line hidden
#line 46 "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                         foreach (var classify in Model.data)
                                        {

#line default
#line hidden
                BeginContext(2235, 51, true);
                WriteLiteral("                                            <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2286, "\"", 2306, 1);
#line 48 "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
WriteAttributeValue("", 2294, classify.Id, 2294, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2307, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2309, 13, false);
#line 48 "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                                                    Write(classify.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2322, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 49 "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                        }

#line default
#line hidden
#line 49 "D:\cgw\Documents\GitHub\hb\NewsPublish.Web\Areas\Admin\Views\News\NewsAdd.cshtml"
                                         
                                    }

#line default
#line hidden
                BeginContext(2415, 2374, true);
                WriteLiteral(@"

                                </select>
                            </td>
                        </tr>
                        <tr>
                            <th class=""text-r"">新闻图片：</th>
                            <td><input type=""file"" class=""img"" name=""img"" multiple datatype=""*2-120"" nullmsg=""新闻图片不能为空""></td>
                        </tr>
                        <tr>
                            <th class=""text-r"">新闻内容：</th>
                            <td><textarea class=""input-text"" name=""Contents"" id=""Contents"" style=""height:330px;width:350px;""></textarea></td>
                        </tr>
                        <tr>
                            <th width=""300"" class=""text-r""> 新闻备注：</th>
                            <td>
                                <input type=""text"" style=""width:300px"" class=""input-text"" value="""" placeholder="""" id=""Remark"" name=""Remark"" datatype=""*2-16"" >
                            </td>
                        </tr>
                        <tr>
         ");
                WriteLiteral(@"                   <th></th>
                            <td><button class=""btn btn-success radius"" type=""button"" onclick=""add()""><i class=""icon-ok""></i> 确定</button></td>
                        </tr>
                    </tbody>
                </table>
            </form>
        </div>
    </div>
    <script type=""text/javascript"" src=""/Admin/js/jquery.min.js""></script>
    <script type=""text/javascript"" src=""/Admin/js/Validform_v5.3.2_min.js""></script>
    <script type=""text/javascript"" src=""/Admin/js/H-ui.js""></script>
    <script type=""text/javascript"" src=""/Admin/js/H-ui.admin.js""></script>
    <script type=""text/javascript"">
            $("".Huiform"").Validform();

    function add() {

   var formData = new FormData(document.getElementById(""addForm""));
            $.ajax({
                type: 'post',
                async: false,
                eache: false,
                contentType: false,
                processData: false,
                url:  '/Admin/News/AddNews',
");
                WriteLiteral(@"                data: formData,
                success: function (data) {
                    if (data.code == 200) {
                        parent.reload();
                    } else {
                        alert(data.result);
                    }
                }
            });

    }

    </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4796, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsPublish.Model.Response.ResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
