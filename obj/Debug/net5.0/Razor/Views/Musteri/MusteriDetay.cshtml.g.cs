#pragma checksum "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94eb7c9be645a8d8b14d648a7b833da3de1022e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musteri_MusteriDetay), @"mvc.1.0.view", @"/Views/Musteri/MusteriDetay.cshtml")]
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
#line 1 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\_ViewImports.cshtml"
using InfotechTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\_ViewImports.cshtml"
using InfotechTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
using InfotechTask.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94eb7c9be645a8d8b14d648a7b833da3de1022e0", @"/Views/Musteri/MusteriDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e255cdf30d785f1dc202bf25c27537b5ad7ef9bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Musteri_MusteriDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Musteri>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-5\">\r\n    <div class=\"card\">\r\n        <div class=\"card-header bg-primary text-white\">\r\n            <h4>Müşteri Profili</h4>\r\n        </div>\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 13 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
             using (Html.BeginForm("MusteriDetay", "Musteri", FormMethod.Post, new { @class = "musteri-detay" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-6 mb-3\">\r\n                        <label>Adı: </label>\r\n                        ");
#nullable restore
#line 20 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
                   Write(Html.TextBoxFor(x => x.Ad, new { @class = "form-control", @placeholder = "Adınızı girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6 mb-3\">\r\n                        <label>Soyad: </label>\r\n                        ");
#nullable restore
#line 24 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
                   Write(Html.TextBoxFor(x => x.Soyad, new { @class = "form-control", @placeholder = "Soyadınızı girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-6 mb-3\">\r\n                        <label>Telefon: </label>\r\n                        ");
#nullable restore
#line 31 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
                   Write(Html.TextBoxFor(x => x.Telefon, new { @class = "form-control", @placeholder = "Telefon numaranızı girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"col-md-6 mb-3\">\r\n\r\n                        <label>Şehir: </label>\r\n                        ");
#nullable restore
#line 37 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
                   Write(Html.TextBoxFor(x => x.Il, new { @class = "form-control", @placeholder = "Şehir adını girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"row \">\r\n\r\n                    <div class=\"col-md-4 mb-3\">\r\n                        <label>İlçe: </label>\r\n                        ");
#nullable restore
#line 45 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
                   Write(Html.TextBoxFor(x => x.Ilce, new { @class = "form-control", @placeholder = "İlçe adını girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"col-md-4 mb-3\">\r\n                        <label>Mahalle: </label>\r\n                        ");
#nullable restore
#line 50 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
                   Write(Html.TextBoxFor(x => x.Mahalle, new { @class = "form-control", @placeholder = "Mahalle adını girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-4 mb-3\">\r\n                        <label>Posta Kodu: </label>\r\n                        ");
#nullable restore
#line 54 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
                   Write(Html.TextBoxFor(x => x.PostaKodu, new { @class = "form-control", @placeholder = "Posta Kodunu girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"mb-3\">\r\n                    <label>Adres: </label>\r\n                    ");
#nullable restore
#line 61 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
               Write(Html.TextAreaFor(x => x.Adres, new { @class = "form-control", @placeholder = "Adresinizi girin" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <button type=\"submit\" class=\"btn btn-primary\">Bilgileri Kaydet</button>\r\n");
#nullable restore
#line 65 "C:\Users\FUJITSU.DESKTOP-MRA9NE4\Desktop\InfotechTask\InfotechTask\Views\Musteri\MusteriDetay.cshtml"
 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musteri> Html { get; private set; }
    }
}
#pragma warning restore 1591