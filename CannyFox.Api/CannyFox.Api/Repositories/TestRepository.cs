using CannyFox.Api.Interfaces.Repasitories;
using CannyFox.Api.Models;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CannyFox.Api.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly string path;

        public TestRepository(IWebHostEnvironment _env)
        {
            path = Path.Combine(_env.WebRootPath, "Database", "db.json");
        }

        public async Task<bool> CreateAsync(Test test)
        {
            try
            {
                string json = await File.ReadAllTextAsync(path);
                var list = JsonConvert.DeserializeObject<List<Test>>(json);
                list.Add(test);
                json = JsonConvert.SerializeObject(list);
                await File.WriteAllTextAsync(path, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(path);
                var list = JsonConvert.DeserializeObject<List<Test>>(json);
                list.Remove(list.FirstOrDefault(x => x.Id == id));
                json = JsonConvert.SerializeObject(list);
                await File.WriteAllTextAsync(path, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<IList<Test>> GetAllAsync()
        {
            try
            {
                string json = await File.ReadAllTextAsync(path);
                var list = JsonConvert.DeserializeObject<List<Test>>(json);
                return list;
            }
            catch
            {
                return new List<Test>();
            }
        }

        public async Task<Test> GetAsync(Guid id)
        {
            try
            {
                string json = await File.ReadAllTextAsync(path);
                var list = JsonConvert.DeserializeObject<List<Test>>(json);
                var test = list.FirstOrDefault(x => x.Id == id);
                return test;
            }
            catch
            {
                return new Test();
            }
        }

        public async Task<bool> UpdateAsync(Guid id, Test test)
        {
            try
            {
                string json = await File.ReadAllTextAsync(path);
                var list = JsonConvert.DeserializeObject<List<Test>>(json);
                int index = list.TakeWhile(x => x.Id != id).Count();
                list[index] = test;
                json = JsonConvert.SerializeObject(list);
                await File.WriteAllTextAsync(path, json);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
