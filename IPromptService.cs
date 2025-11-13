using System.Collections.Generic;
using Domain;

namespace Service
{
    public interface IPromptService
    {
        IEnumerable<Prompt> GetAll();
        Prompt GetById(int id);
        void Add(Prompt prompt);
        void Update(Prompt prompt);
        void Delete(int id);
    }
}
