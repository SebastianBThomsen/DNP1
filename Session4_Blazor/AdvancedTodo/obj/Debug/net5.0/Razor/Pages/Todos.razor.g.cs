#pragma checksum "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fc2801d8ac74d6f38e2c5ec6feb6f79092be694"
// <auto-generated/>
#pragma warning disable 1591
namespace AdvancedTodo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using AdvancedTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\_Imports.razor"
using AdvancedTodo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
using AdvancedTodo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
using AdvancedTodo.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Todos</h1>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by User Id: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                                                        (arg) => FilterByUserId(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n    Filter by completed status:\r\n    ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control selectpicker");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                                                           (arg) => FilterByCompletedStatus(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "style", "width:100px");
            __builder.OpenElement(14, "option");
            __builder.AddContent(15, "Both");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "option");
            __builder.AddContent(18, "False");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "option");
            __builder.AddContent(21, "True");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
 if (todosToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<p><em>Loading...</em></p>");
#nullable restore
#line 27 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
}
else if (!todosToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "<p><em>No ToDo items exist. Please add some.</em></p>");
#nullable restore
#line 33 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "table");
            __builder.AddAttribute(25, "class", "table");
            __builder.AddMarkupContent(26, "<thead><tr><th>User ID</th>\r\n            <th>Todo ID</th>\r\n            <th>Title</th>\r\n            <th>Completed?</th>\r\n            <th>Remove</th>\r\n            <th>Edit</th></tr></thead>\r\n        ");
            __builder.OpenElement(27, "tbody");
#nullable restore
#line 48 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
         foreach (var item in todosToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "tr");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 51 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                     item.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 52 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                     item.TodoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 53 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                     item.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "checkbox");
            __builder.AddAttribute(41, "checked", 
#nullable restore
#line 55 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                                                    item.IsCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                                                                                  (arg) => CompletedChange(arg, item)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 57 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                     item.IsCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                                        () => RemoveTodo(item.TodoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.OpenElement(52, "td");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
                                        () => Edit(item.TodoId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\N_i_v\RiderProjects\DNP1\Session4_Blazor\AdvancedTodo\Pages\Todos.razor"
       
    private IList<Todo> allTodos;
    private IList<Todo> todosToShow;

    private int? filterById;
    private bool? filterByIsCompleted;

    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        ExecuteFilter();
    }

    private void FilterByCompletedStatus(ChangeEventArgs args)
    {
        filterByIsCompleted = null;
        try
        {
            filterByIsCompleted = bool.Parse(args.Value.ToString());
        } catch (Exception e){}
        ExecuteFilter();
    }

    private void ExecuteFilter()
    {
        todosToShow = allTodos.Where(t =>
            (filterById != null && t.UserId == filterById || filterById == null) &&
            (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)).ToList();
    }
    
    
    
    
    
    protected override async Task OnInitializedAsync()
    {
        allTodos = TodoData.GetTodos();
        todosToShow = allTodos;
    }

    private void RemoveTodo(int todoId)
    {
        Todo todoToRemove = allTodos.First(t => t.TodoId == todoId);
        TodoData.RemoveTodo(todoId);
        allTodos.Remove(todoToRemove);
        todosToShow.Remove(todoToRemove);
    }

    private void CompletedChange(ChangeEventArgs evt, Todo todo)
    {
        todo.IsCompleted = (bool) evt.Value;
        TodoData.Update(todo);
    }

    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"Edit/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosData TodoData { get; set; }
    }
}
#pragma warning restore 1591
