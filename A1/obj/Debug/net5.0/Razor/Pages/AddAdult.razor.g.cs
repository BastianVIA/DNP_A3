#pragma checksum "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b9d922849eecfe0014b90b283ffe1cd0687eb17"
// <auto-generated/>
#pragma warning disable 1591
namespace A1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using A1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using A1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
using A1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
using Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddAdult</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                  adult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                         _AddAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "<label>First Name:</label>\r\n        ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "placeholder", "first name");
                __builder2.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                                 firstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label>Last Name:</label>\r\n        ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "text");
                __builder2.AddAttribute(19, "placeholder", "last name");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                                lastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "<label>Hair Color:</label>\r\n        ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "placeholder", "hair color");
                __builder2.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                                 hairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hairColor = __value, hairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddMarkupContent(34, "<label>Eye Color:</label>\r\n        ");
                __builder2.OpenElement(35, "input");
                __builder2.AddAttribute(36, "type", "text");
                __builder2.AddAttribute(37, "placeholder", "eye color");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                                eyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eyeColor = __value, eyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label>Age:</label>\r\n        ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "placeholder", "age");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                          age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => age = __value, age));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "<label>Weight:</label>\r\n        ");
                __builder2.OpenElement(53, "input");
                __builder2.AddAttribute(54, "type", "text");
                __builder2.AddAttribute(55, "placeholder", "weight");
                __builder2.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                             weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => weight = __value, weight));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "<label>Height:</label>\r\n        ");
                __builder2.OpenElement(62, "input");
                __builder2.AddAttribute(63, "type", "text");
                __builder2.AddAttribute(64, "placeholder", "height");
                __builder2.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                             height

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => height = __value, height));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n    ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "form-group");
                __builder2.AddMarkupContent(70, "<label>Sex:</label>\r\n        ");
                __builder2.OpenElement(71, "input");
                __builder2.AddAttribute(72, "type", "text");
                __builder2.AddAttribute(73, "placeholder", "sex");
                __builder2.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 42 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                          sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sex = __value, sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n    ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "<label>Job Title:</label>\r\n        ");
                __builder2.OpenElement(80, "input");
                __builder2.AddAttribute(81, "type", "text");
                __builder2.AddAttribute(82, "placeholder", "job title");
                __builder2.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                                jobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => jobTitle = __value, jobTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "form-group");
                __builder2.AddMarkupContent(88, "<label>Salary:</label>\r\n        ");
                __builder2.OpenElement(89, "input");
                __builder2.AddAttribute(90, "type", "text");
                __builder2.AddAttribute(91, "placeholder", "salary");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
                                                             salary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => salary = __value, salary));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.AddMarkupContent(95, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">Add</button></p>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(96, "\r\n\r\n");
            __builder.OpenElement(97, "p");
            __builder.AddContent(98, 
#nullable restore
#line 57 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
    warning

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\basti\RiderProjects\DNP_Assignment3\A1\Pages\AddAdult.razor"
       
    
    [Inject] public IAdultService Service { get; set; }
    
    private Adult adult = new Adult();
    private Job job = new Job();
    // private int id;
    private string firstName;
    private string lastName;
    private string hairColor;
    private string eyeColor;
    private int age;
    private float weight;
    private int height;
    private string sex;
    private string jobTitle;
    private int salary;
    private string warning;


    private async Task _AddAdult()
    {
        if (firstName != null && lastName != null && hairColor != null && eyeColor != null && age > 1 && weight > 1 && height > 1 && sex != null && salary > 1) //Dum test af at alle felter er udfyldt
        {
            try
            {
                warning = "";
                
                job.JobTitle = jobTitle;
                job.Salary = salary;

                adult.JobTitle = job;
                adult.FirstName = firstName;
                adult.LastName = lastName;
                adult.HairColor = hairColor;
                adult.EyeColor = eyeColor;
                adult.Age = age;
                adult.Weight = weight;
                adult.Height = height;
                adult.Sex = sex;
                
                await Service.AddAdult(adult);
                warning = "Adult added";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        else
        {
            warning = "Please fill all fields";
        }

        
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
