namespace Service;

using Domain;
using System.Collections.Generic;

public interface IPromptService
{
    IEnumerable<Prompt> GetAllPrompts();

    Prompt AddPrompt(Prompt prompt);

    void UpdatePrompt(Prompt prompt);

    void DeletePrompt(int id);
}