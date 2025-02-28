using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.DinoTopia.Metadata
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]


    [ContextMemberMetadata<ActorConfig>]
    [ContextMemberMetadata<BuffConfig>]

    [ContextMemberMetadata<ItemConfig>]

    [ContextMemberMetadata<Game>]
    [ContextMemberMetadata<UserDataSubsystem>]

    [ContextMemberMetadata<LocalizationSubsystem>]
    public partial class DinoTopiaGameContext
    {
    }
}
