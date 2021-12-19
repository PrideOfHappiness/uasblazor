using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UASBlazor.Services;

namespace UASBlazor.Pages
{
    public partial class DeleteStudent
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IDStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await StudentService.Delete(int.Parse(id));
            NavigationManager.NavigateTo("/studentspage");
        }
    }
}