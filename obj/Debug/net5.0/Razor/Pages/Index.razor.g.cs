#pragma checksum "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63ccbc7827f862239c88d62dd9a95477b9abe08f"
// <auto-generated/>
#pragma warning disable 1591
namespace WhosAppClienteBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using WhosAppClienteBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\_Imports.razor"
using WhosAppClienteBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/StartChat")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "container overflow-auto shadow-sm p-3 mb-5 bg-white rounded");
                __builder2.AddAttribute(4, "style", "height: 500px;");
#nullable restore
#line 12 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                 if (!userMessages.Any())
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(5, "<p>No messages yet, start chatting!</p>");
#nullable restore
#line 15 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                 foreach (var userMessage in userMessages)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row" + " mb-3" + " d-flex" + " " + (
#nullable restore
#line 19 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                                  userMessage.CurrentUser ? "justify-content-end" : ""

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card" + " shadow" + " " + (
#nullable restore
#line 20 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                                  userMessage.CurrentUser ? "color-green mr-5" : "ml-5"

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "style", "width: 18rem;");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-header");
#nullable restore
#line 22 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
__builder2.AddContent(13, userMessage.CurrentUser ? "You" : userMessage.UserName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                            ");
                __builder2.OpenElement(15, "ul");
                __builder2.AddAttribute(16, "class", "list-group list-group-flush");
                __builder2.OpenElement(17, "li");
                __builder2.AddAttribute(18, "class", "list-group-item" + " " + (
#nullable restore
#line 25 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                                             userMessage.CurrentUser ? "color-green" : ""

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 25 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
__builder2.AddContent(19, userMessage.Message);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "card-footer");
                __builder2.OpenElement(23, "span");
                __builder2.AddAttribute(24, "class", "small");
#nullable restore
#line 28 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
__builder2.AddContent(25, userMessage.DateSent.ToString("HH:mm | MMM dd"));

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 32 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n            ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "container");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-3");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "placeholder", "Your name");
                __builder2.AddAttribute(37, "readonly", 
#nullable restore
#line 38 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                                                                                                         isUserReadonly

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                      usernameInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usernameInput = __value, usernameInput));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "col-6");
                __builder2.OpenElement(43, "textarea");
                __builder2.AddAttribute(44, "class", "form-control");
                __builder2.AddAttribute(45, "placeholder", "Start typing...");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                         messageInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                    ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-3");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "type", "button");
                __builder2.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                                        Send

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "disabled", 
#nullable restore
#line 44 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
                                                                          !IsConnected

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(55, "class", "btn btn-primary");
                __builder2.AddContent(56, "Send");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Lucaaas\Desktop\Programación\6 - Bootcamp\ProyectoFinalClienteWhosAppVistasMejoradas\WhosAppClienteBlazor\Pages\Index.razor"
          
        private HubConnection hubConnection;
        private List<UserMessage> userMessages = new();
        private string usernameInput;
        private string messageInput;
        private bool isUserReadonly = false;

        public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

        protected override async Task OnInitializedAsync()
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
                .Build();

            hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
            {
                userMessages.Add(new UserMessage
                {
                    UserName = user,
                    Message = message,
                    CurrentUser = user == usernameInput,
                    DateSent = DateTime.Now
                });
                StateHasChanged();
            });
            await hubConnection.StartAsync();
        }

        private async Task Send()
        {
            if (!string.IsNullOrEmpty(usernameInput) && !string.IsNullOrEmpty(messageInput))
            {
                await hubConnection.SendAsync("SendMessage", usernameInput, messageInput);

                isUserReadonly = true;
                messageInput = string.Empty;
            }
        }

        public async ValueTask DisposeAsync()
        {
            if (hubConnection is not null)
            {
                await hubConnection.DisposeAsync();
            }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
