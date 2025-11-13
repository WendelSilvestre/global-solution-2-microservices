using Domain;

namespace Repository
{
    public interface IPromptRepository
    {
        Task<IEnumerable<Prompt>> GetAllPromptsAsync();
        Task<Prompt> AddPromptAsync(Prompt vehicle);
        Task UpdatePromptAsync(Prompt vehicle);
        Task DeletePromptAsync(int id);
    }
}