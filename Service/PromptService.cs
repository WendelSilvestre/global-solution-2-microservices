namespace Service;

using Domain;
using Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PromptService : IPromptService
{
    private readonly IPromptRepository _promptRepository;

    public PromptService(IPromptRepository promptRepository)
    {
        _promptRepository = promptRepository;
    }

    public async Task<IEnumerable<Prompt>> GetAllPromptsAsync()
    {
        return await _promptRepository.GetAllPromptsAsync();
    }

    public async Task<Prompt> AddPromptAsync(Prompt prompt)
    {
        return await _promptRepository.AddPromptAsync(prompt);
    }

    public async Task UpdatePromptAsync(Prompt prompt)
    {
        await _promptRepository.UpdatePromptAsync(prompt);
    }

    public async Task DeletePromptAsync(int id)
    {
        await _promptRepository.DeletePromptAsync(id);
    }

    public IEnumerable<Prompt> GetAllPrompts()
    {
        throw new NotImplementedException();
    }

    public Prompt AddPrompt(Prompt prompt)
    {
        throw new NotImplementedException();
    }

    public void UpdatePrompt(Prompt prompt)
    {
        throw new NotImplementedException();
    }

    public void DeletePrompt(int id)
    {
        throw new NotImplementedException();
    }
}
