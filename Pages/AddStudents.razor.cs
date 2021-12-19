using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASBlazor.Models;
using UASBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace UASBlazor.Pages{
    public partial class AddStudents {
        public Student Students { get; set; } = new Student();

        [Inject]
        public IDStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        

        protected async Task HandleValidSubmit(){
            var result = await StudentService.Add(Students);
            NavigationManager.NavigateTo("/studentspage");
        }
    }
}