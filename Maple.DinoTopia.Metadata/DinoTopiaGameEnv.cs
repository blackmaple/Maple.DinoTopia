using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Microsoft.Extensions.Logging;

namespace Maple.DinoTopia.Metadata
{
    public partial class DinoTopiaGameEnv
    {
        public DinoTopiaGameContext Context { get; }
        public ILogger Logger => Context.Logger;
        public Game.Ptr_Game Ptr_Game { get; }

        public UserDataSubsystem.Ptr_UserDataSubsystem Ptr_UserDataSubsystem { get; private set; }
        public LocalizationSubsystem.Ptr_LocalizationSubsystem Ptr_LocalizationSubsystem { get; private set; }
        public DinoTopiaGameEnv(DinoTopiaGameContext gameContext)
        {
            this.Context = gameContext;
            this.Ptr_Game = Game.Ptr_Game._INSTANCE;
            InitSubSystem();
        }

        public void InitSubSystem()
        {
            //this.Logger.LogInformation("userdataSubSystem:{s}", this.Context.UserDataSubsystem.ClassMetadata.ClassInfo.Pointer.ToString("X8"));
            foreach (var dic in Ptr_Game._SUBSYSTEMS.AsRefArray())
            {
                var pObject = dic.Value;
                var monoclass = this.Context.RuntimeContext.RuntiemProvider.GetMonoClass(pObject);

                if (monoclass == this.Context.UserDataSubsystem.ClassMetadata.ClassInfo.Pointer)
                {
                    this.Ptr_UserDataSubsystem = pObject.To<UserDataSubsystem.Ptr_UserDataSubsystem>();
                }
                else if (monoclass == this.Context.LocalizationSubsystem.ClassMetadata.ClassInfo.Pointer)
                {
                    this.Ptr_LocalizationSubsystem = pObject.To<LocalizationSubsystem.Ptr_LocalizationSubsystem>();
                }
                ////    var monoclass = dic.Value.MonoClass;
                //;

                //var classtype = this.Context.RuntimeContext.RuntiemProvider.GetMonoClassType(monoclass);

                //var classfullname = this.Context.RuntimeContext.RuntiemProvider.GetMonoTypeName(classtype).ToString();

                //this.Logger.LogInformation("Key:{Key},Value:{Value},monoclass:{monoclass} classtype:{classtype},classfullname:{classfullname}",
                //    dic.Key.ToString(), dic.Value.ToString(),
                //      monoclass, classtype, classfullname);

            }

        }


        public void LoadActorConfig()
        {
            foreach (var dic in ActorConfig.Ptr_ActorConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadBuffConfig()
        {
            foreach (var dic in BuffConfig.Ptr_BuffConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());

            }
        }
        public void LoadItemConfig()
        {
            foreach (var dic in ItemConfig.Ptr_ItemConfig.GET_DIC().AsRefArray())
            {
                var name = dic.Value.NAME;
                var localName = this.Ptr_LocalizationSubsystem.GET(name);
                this.Logger.LogInformation(" id:{id},{name}:{localName}", dic.Value.ID.ToString(), name, localName.ToString());
            }
        }

        public static List<GameCurrencyDisplayDTO> CurrencyDisplayDTOs { get; } = [];
        public static List<GameInventoryDisplayDTO> InventoryDisplayDTOs { get; } = [];

    }
}
