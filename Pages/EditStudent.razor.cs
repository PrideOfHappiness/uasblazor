using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASBlazor.Models;
using UASBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace UASBlazor.Pages{
    public partial class EditStudent {
        public Student student { get; set; } = new Student();
        [Inject]
        public IDStudentService StudentService { get; set; }
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            student = await StudentService.GetbyId(int.Parse(Id));
        }

        protected async Task HandleValidSubmit() { 
            var result = await StudentService.Update(int.Parse(Id),student);
            NavigationManager.NavigateTo("studentspage");
        }

    }
}
