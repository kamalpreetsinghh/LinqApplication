#pragma checksum "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "330cc538b5ee177eb83121715a9dcf85cd32cf4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student__StudentListPartial), @"mvc.1.0.view", @"/Views/Student/_StudentListPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/_StudentListPartial.cshtml", typeof(AspNetCore.Views_Student__StudentListPartial))]
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
#line 1 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\_ViewImports.cshtml"
using LINQApplication;

#line default
#line hidden
#line 2 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\_ViewImports.cshtml"
using LINQApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"330cc538b5ee177eb83121715a9dcf85cd32cf4d", @"/Views/Student/_StudentListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8436906be27f6064edc0ff2b26c9f78b03dedfe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Student__StudentListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LINQApplication.Models.Student.StudentDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
  
    ViewData["Title"] = "_StudentListPartial";

#line default
#line hidden
            BeginContext(122, 404, true);
            WriteLiteral(@"
<h2>Student Details</h2>
<table border=""1"" align=""center"" width=""100%"">
    <tr style=""text-align: center; font-size: large; font-family: Calibri; font-weight:bold"">
        <td>Student ID</td>
        <td>Student Name</td>
        <td>Student Class</td>
        <td>Student Roll No</td>
        <td>Student Age</td>
        <td>Student Fees</td>
        <td>Transaction Date</td>
    </tr>
");
            EndContext();
#line 17 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
            BeginContext(570, 89, true);
            WriteLiteral("    <tr style=\"text-align: center; font-size: large; font-family: Calibri\">\r\n        <td>");
            EndContext();
            BeginContext(660, 17, false);
#line 20 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
       Write(student.studentID);

#line default
#line hidden
            EndContext();
            BeginContext(677, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(697, 19, false);
#line 21 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
       Write(student.studentName);

#line default
#line hidden
            EndContext();
            BeginContext(716, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(736, 20, false);
#line 22 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
       Write(student.studentClass);

#line default
#line hidden
            EndContext();
            BeginContext(756, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(776, 21, false);
#line 23 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
       Write(student.studentRollNo);

#line default
#line hidden
            EndContext();
            BeginContext(797, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(817, 18, false);
#line 24 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
       Write(student.studentAge);

#line default
#line hidden
            EndContext();
            BeginContext(835, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(855, 19, false);
#line 25 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
       Write(student.studentFees);

#line default
#line hidden
            EndContext();
            BeginContext(874, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(894, 23, false);
#line 26 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
       Write(student.transactionDate);

#line default
#line hidden
            EndContext();
            BeginContext(917, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 28 "D:\DotNet\LinqApplication\LINQApplication\LINQApplication\Views\Student\_StudentListPartial.cshtml"
    }

#line default
#line hidden
            BeginContext(942, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LINQApplication.Models.Student.StudentDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591
