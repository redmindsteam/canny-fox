using CannyFox.Api.Interfaces.Repasitories;
using CannyFox.Api.Interfaces.Services;
using CannyFox.Api.Models;
using CannyFox.Api.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CannyFox.Api.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepository testRepository;

        public TestService(ITestRepository testRepository)
        {
            this.testRepository = testRepository;
        }

        public async Task<bool> CreateAsync(TestCreationViewModel testCreationViewModel)
        {
            Test test = new Test();
            test.Id = Guid.NewGuid();
            test.Question = testCreationViewModel.Question;
            test.Answer = testCreationViewModel.Answer;
            await testRepository.CreateAsync(test);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
            => await testRepository.DeleteAsync(id);

        public async Task<Test> FindAsync(string search)
        {
            var list = await testRepository.GetAllAsync();
            return list.FirstOrDefault(test => test.Question.StartsWith(search));
        }

        public async Task<IList<Test>> GetAllAsync()
            => await testRepository.GetAllAsync();

        public async Task<Test> GetAsync(Guid id)
            => await testRepository.GetAsync(id);

        public async Task<bool> UpdateAsync(Guid id, TestCreationViewModel testCreationViewModel)
        {
            Test test = new Test();
            test.Id = id;
            test.Question = testCreationViewModel.Question;
            test.Answer = testCreationViewModel.Answer;
            await testRepository.UpdateAsync(id, test);
            return true;
        }
    }
}
