using Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator;

namespace Maple.DinoTopia.Metadata
{
    [ContextParentMetadata<ContextMetadataCollector>(true)]

    [ContextMemberMetadata<Game>]
    [ContextMemberMetadata<ItemConfig>]
    [ContextMemberMetadata<UserDataSubsystem>]

    public partial class DinoTopiaGameContext
    {
    }
}
