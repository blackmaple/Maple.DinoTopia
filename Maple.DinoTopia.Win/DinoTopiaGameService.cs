using Maple.DinoTopia.Metadata;
using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.Windows.HotKey.HookWindowMessage;
using Maple.MonoGameAssistant.Windows.Service;
using Maple.MonoGameAssistant.Windows.UITask;
using Microsoft.Extensions.Logging;

namespace Maple.DinoTopia.Win
{
    internal sealed class DinoTopiaGameService
        (ILogger<DinoTopiaGameService> logger, MonoRuntimeContext runtimeContext, MonoTaskScheduler monoTaskScheduler, MonoGameSettings gameSettings, HookWinMsgFactory hookWinMsgFactory)
                : GameContextService<DinoTopiaGameContext>(logger, runtimeContext, monoTaskScheduler, gameSettings, hookWinMsgFactory)
    {
        protected override DinoTopiaGameContext LoadGameContext()
        {
            var searchService = new MonoGameAssistant.MetadataExtensions.MetadataService.MetadataCollectorSearchService();
            searchService.UpdateMetadata(new MonoDescriptionCollectionDTO()
            {
                Classes = DinoTopiaGameContext.MonoJsonClassDTO,
                Methods = DinoTopiaGameContext.MonoJsonMethodDTO,
                Fields = DinoTopiaGameContext.MonoJsonFieldDTO,
            });
            return new DinoTopiaGameContext(Logger, searchService, RuntimeContext);
        }




    }


}
