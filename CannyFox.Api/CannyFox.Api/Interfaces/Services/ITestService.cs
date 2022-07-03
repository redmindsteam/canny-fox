using CannyFox.Api.Models;
using CannyFox.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CannyFox.Api.Interfaces.Services
{
    public interface ITestService
    {
        Task<Test> GetAsync(Guid id);

        Task<IList<Test>> GetAllAsync();

        Task<bool> CreateAsync(TestCreationViewModel testCreationViewModel);

        Task<bool> UpdateAsync(Guid id, TestCreationViewModel testCreationViewModel);

        Task<bool> DeleteAsync(Guid id);

        Task<Test> FindAsync(string search);
    }
}
