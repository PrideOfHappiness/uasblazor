using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using UASBlazor.Models;

namespace UASBlazor.Services
{
    public class StudentService : IDStudentService {
        private HttpClient _httpclient;
        public StudentService (HttpClient httpclient) {
            _httpclient = httpclient;
        }

        public async Task<IEnumerable<Student>> GetAll() {
            var results = await _httpclient.GetFromJsonAsync<IEnumerable<Student>>("api/Student");
             return results;
        }

        public async Task<Student> GetbyId(int id) {
            var results = await _httpclient.GetFromJsonAsync<Student>($"api/Student/{id}");
            return results;
        }

        public async Task<Student> Add(Student student) {
            var response = await _httpclient.PostAsJsonAsync($"api/Student",student);
            if(response.IsSuccessStatusCode){ 
               return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync()); 
            }
            else { 
                throw new Exception("Gagal tambah data");
            }
        }

        public async Task<Student> Enroll (int id, DateTime waktu, Student student) {
            var response = await _httpclient.PutAsJsonAsync($"api/Student/{id}",student);
            if(response.IsSuccessStatusCode){ 
               return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync()); 
            }
            else { 
                throw new Exception("Gagal Memasukkan Absensi");
            }
        }

        public async Task<Student> Update (int id, Student student) {
            var response = await _httpclient.PutAsJsonAsync($"api/Student/{id}", student);
            if(response.IsSuccessStatusCode){ 
               return await JsonSerializer.DeserializeAsync<Student>(await response.Content.ReadAsStreamAsync()); 
            }
            else { 
                throw new Exception("Gagal ubah data");
            }
        }

        public async Task Delete(int id) {
            await _httpclient.DeleteAsync($"api/Student/{id}");  
        }
    }
}