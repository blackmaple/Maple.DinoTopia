using Maple.MonoGameAssistant.Common;
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
                ////    var monoclass = dic.Value.MonoClass;
                //;

                //var classtype = this.Context.RuntimeContext.RuntiemProvider.GetMonoClassType(monoclass);

                //var classfullname = this.Context.RuntimeContext.RuntiemProvider.GetMonoTypeName(classtype).ToString();

                //this.Logger.LogInformation("Key:{Key},Value:{Value},monoclass:{monoclass} classtype:{classtype},classfullname:{classfullname}",
                //    dic.Key.ToString(), dic.Value.ToString(),
                //      monoclass, classtype, classfullname);

            }

        }

        public void Test2()
        {
            //   this.Logger.DebugLine($"itemconfig:{ItemConfig.Ptr_ItemConfig.M_DIC}");
            foreach (var dic in ItemConfig.Ptr_ItemConfig.GET_DIC().AsRefArray())
            {
                this.Logger.LogInformation("key:{key},val:{val},id:{id},name:{name}", dic.Key, dic.Value, dic.Value.ID.ToString(), dic.Value.NAME.ToString());
            }
            //  this.Logger.DebugLine();
        }
    }
}
