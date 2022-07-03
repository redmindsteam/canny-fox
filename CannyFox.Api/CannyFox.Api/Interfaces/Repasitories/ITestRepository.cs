using CannyFox.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CannyFox.Api.Interfaces.Repasitories
{
    public interface ITestRepository
    {
        Task<bool> CreateAsync(Test test);

        Task<bool> UpdateAsync(Guid id, Test test);

        Task<Test> GetAsync(Guid id);

        Task<IList<Test>> GetAllAsync();

        Task<bool> DeleteAsync(Guid id);
    }
}
