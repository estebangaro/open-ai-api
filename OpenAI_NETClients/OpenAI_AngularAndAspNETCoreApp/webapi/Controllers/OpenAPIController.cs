using Microsoft.AspNetCore.Mvc;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class OpenAPIController : ControllerBase
{
    const string my_open_ai_api_key = "{YOUR OPEN AI API KEY}";

    private readonly ILogger<OpenAPIController> _logger;

    public OpenAPIController(ILogger<OpenAPIController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "PostOpenAPI")]
    public async Task<IActionResult> Post(OpenAPIRequest openAPIRequest)
    {
        var openAiService = new OpenAIService(new OpenAiOptions()
        {
            ApiKey = my_open_ai_api_key
        });

        var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
        {
            Messages = new List<ChatMessage>
            {
                ChatMessage.FromUser(openAPIRequest.question)
            },
            Model = Models.ChatGpt3_5Turbo
        });

        return Ok(new { Response = completionResult?.Choices?.FirstOrDefault()?.Message?.Content ?? "Respuesta no determinada." });
    }
}
