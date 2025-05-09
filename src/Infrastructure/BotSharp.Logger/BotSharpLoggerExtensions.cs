namespace BotSharp.Logger;

public static class BotSharpLoggerExtensions
{
    /// <summary>
    /// BotSharp conversation log
    /// </summary>
    /// <param name="services"></param>
    /// <param name="config"></param>
    /// <returns></returns>
    public static IServiceCollection AddBotSharpLogger(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IContentGeneratingHook, CommonContentGeneratingHook>();
        services.AddScoped<IContentGeneratingHook, TokenStatsConversationHook>();
        services.AddScoped<IContentGeneratingHook, VerboseLogHook>();
        services.AddScoped<IContentGeneratingHook, GlobalStatsConversationHook>();
        services.AddScoped<IConversationHook, RateLimitConversationHook>();
        services.AddScoped<IInstructHook, InstructionLogHook>();
        return services;
    }
}
