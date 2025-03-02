﻿using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.DinoTopia.Win
{
    internal static class DinoTopiaGameExtensions
    {

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
            {
                p.GameName = "Dino Topia Demo";
                p.QQ = "0";
                p.Http = true;
                p.NamedPipe = true;
                p.AutoOpenUrl = true;

            }, services =>
            {
                services.UseGameContextService<DinoTopiaGameService>();
            });

            //延迟启动
            Thread.Sleep(8000);
            webapp.Run();

            return 1;
        }

    }


}
