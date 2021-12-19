using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UASBlazor.Models;
using UASBlazor.Services;

namespace UASBlazor.Pages
{
    public partial class DetailStudent
    {
        [Parameter]

        public string id { get; set; }

        public Student Student { get; set; } = new Student();

        [Inject]
        public IDStudentService StudentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetbyId(int.Parse(id));
        } 


    }
}