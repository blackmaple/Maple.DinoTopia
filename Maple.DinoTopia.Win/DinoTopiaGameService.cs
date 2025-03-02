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


        //protected sealed override async ValueTask F9_KeyDown()
        //{
        //    await this.UITaskAsync(p => new DinoTopiaGameEnv(p).Test()).ConfigureAwait(false);
        //}
        protected sealed override async ValueTask F8_KeyDown()
        {
            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadActorConfig()).ConfigureAwait(false);

           await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadBuffConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadBuffEffectConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadBuildConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadChapter_Config()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadCharacterDIYConfig()).ConfigureAwait(false);

            await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadCharacterStrengthenConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadDropConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadGatherRes_Config()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadGlobalEffectConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadGuideConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadHomeUpdateConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadHuntingTaskConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadInputManagerConfig()).ConfigureAwait(false);

          await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadItemConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadLevel_Config()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadMapBKConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadMap_Group_Config()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadMap_Type_Config()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadMonsterConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadMonsterRandomConfig()).ConfigureAwait(false);

             await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadPet_Config()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadRandomSpawnMonsterConfig()).ConfigureAwait(false);

    //         await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadRelicConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadRoomShopConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadRoomShopItemConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadRoom_Config()).ConfigureAwait(false);

        //     await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadSeedConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadShopItemConfig()).ConfigureAwait(false);

            // await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadSkillConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadSkinColorConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadSkinPresetConfig()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadStage_Config()).ConfigureAwait(false);

            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadStatusConfig()).ConfigureAwait(false);

            await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadTalentConfig()).ConfigureAwait(false);
 
            //await this.UITaskAsync(p => DinoTopiaGameEnv.ReadTaskConfig()).ConfigureAwait(false);
 
            await this.UITaskAsync(p => DinoTopiaGameEnv.ReadTecBuildConfig()).ConfigureAwait(false);
 
           await this.UITaskAsync(p => DinoTopiaGameEnv.ReadTecRuleConfig()).ConfigureAwait(false);
 
             await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadTecTotemConfig()).ConfigureAwait(false);
 
       //     await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadToolConfig()).ConfigureAwait(false);
 
             await this.UITaskAsync(p => new DinoTopiaGameEnv(p).LoadTotemConfig()).ConfigureAwait(false);
 

        }
    }


}
