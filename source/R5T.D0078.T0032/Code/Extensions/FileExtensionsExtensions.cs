using System;

using R5T.T0032; /// <see cref="R5T.T0032.Documentation"/>
using R5T.D0078.T0032;


namespace System
{
    public static class FileExtensionsExtensions
    {
        [Obsolete("See R5T.Z0072.Z000")]
        public static string Sln(this IFileExtension _)
        {
            return FileExtensions.Sln;
        }

        [Obsolete("See R5T.Z0072.Z002")]
        public static string Solution(this IFileExtension _)
        {
            return _.Sln();
        }
    }
}
