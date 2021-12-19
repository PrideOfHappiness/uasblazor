using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UASBlazor.Models;
using UASBlazor.Services;
using Microsoft.AspNetCore.Components;

namespace UASBlazor.Pages
{
    public partial class StudentPage 
    {
        public List<Student> Students { get ; set; } = new List<Student>();

        [Inject]
        public IDStudentService StudentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
           Students = (await StudentService.GetAll()).ToList();
        }
    }
}