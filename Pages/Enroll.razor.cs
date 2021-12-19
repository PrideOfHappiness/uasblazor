using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASBlazor.Models;
using UASBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace UASBlazor.Pages {
    public partial class Enroll { 
        [Parameter]
        public string id { get; set; }
        [Parameter]
        public Student student { get; set;}
        [Parameter]
        public DateTime waktu { get; set; } = new DateTime();

        [Inject]
        public IDStudentService StudentService { get;set;}
        [Inject]
        public NavigationManager NavigationManager { get; set;}

        protected override async Task OnInitializedAsync()
        {
            student = await StudentService.Enroll(int.Parse(id), waktu ,student);
            NavigationManager.NavigateTo("studentspage");
        }
    }
}