using System.Collections.Generic;
using Domain;
using Repository;

namespace Service
{
    public class PromptService : IPromptService
    {
        private readonly IPromptRepository _promptRepository;

        public PromptService(IPromptRepository promptRepository)
        {
            _promptRepository = promptRepository;
        }

        public IEnumerable<Prompt> GetAll()
        {
            return _promptRepository.GetAll();
        }

        public Prompt GetById(int id)
        {
            return _promptRepository.GetById(id);
        }

        public void Add(Prompt prompt)
        {
            _promptRepository.Add(prompt);
        }

        public void Update(Prompt prompt)
        {
            _promptRepository.Update(prompt);
        }

        public void Delete(int id)
        {
            _promptRepository.Delete(id);
        }
    }
}
