#pragma checksum "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "146ea9a944798c5d13684f7c2997eeb90a04390e"
// <auto-generated/>
#pragma warning disable 1591
namespace CustomMethodBenjamin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\CustomMethodBenjamin\server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CustomMethodBenjamin\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CustomMethodBenjamin\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CustomMethodBenjamin\server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CustomMethodBenjamin\server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CustomMethodBenjamin\server\_Imports.razor"
using CustomMethodBenjamin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
using CustomMethodBenjamin.Models.ConData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/add-product-category")]
    public partial class AddProductCategory : CustomMethodBenjamin.Pages.AddProductCategoryComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTemplateForm<CustomMethodBenjamin.Models.ConData.ProductCategory>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CustomMethodBenjamin.Models.ConData.ProductCategory>(
#nullable restore
#line 12 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                   productcategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                                               productcategory != null

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Submit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CustomMethodBenjamin.Models.ConData.ProductCategory>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CustomMethodBenjamin.Models.ConData.ProductCategory>(this, 
#nullable restore
#line 12 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                                                                                                                                              Form0Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenElement(12, "div");
                    __builder3.AddAttribute(13, "style", "margin-bottom: 1rem");
                    __builder3.AddAttribute(14, "class", "row");
                    __builder3.OpenElement(15, "div");
                    __builder3.AddAttribute(16, "class", "col-md-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenLabel>(17);
                    __builder3.AddAttribute(18, "Text", "Category Name");
                    __builder3.AddAttribute(19, "Component", "CategoryName");
                    __builder3.AddAttribute(20, "style", "width: 100%");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(21, "\n              ");
                    __builder3.OpenElement(22, "div");
                    __builder3.AddAttribute(23, "class", "col-md-9");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(24);
                    __builder3.AddAttribute(25, "MaxLength", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64?>(
#nullable restore
#line 20 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                          70

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "style", "width: 100%");
                    __builder3.AddAttribute(27, "Name", "CategoryName");
                    __builder3.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                                                                 productcategory.CategoryName

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productcategory.CategoryName = __value, productcategory.CategoryName))));
                    __builder3.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productcategory.CategoryName));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(31, "\n            ");
                    __builder3.OpenElement(32, "div");
                    __builder3.AddAttribute(33, "class", "row");
                    __builder3.OpenElement(34, "div");
                    __builder3.AddAttribute(35, "class", "col offset-sm-3");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(36);
                    __builder3.AddAttribute(37, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonType>(
#nullable restore
#line 26 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                          ButtonType.Submit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Icon", "save");
                    __builder3.AddAttribute(39, "Text", "Save");
                    __builder3.AddAttribute(40, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 26 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                                                                                  ButtonStyle.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\n                ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(42);
                    __builder3.AddAttribute(43, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 28 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                           ButtonStyle.Light

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "style", "margin-left: 1rem");
                    __builder3.AddAttribute(45, "Text", "Cancel");
                    __builder3.AddAttribute(46, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\CustomMethodBenjamin\server\Pages\AddProductCategory.razor"
                                                                                                              Button2Click

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
