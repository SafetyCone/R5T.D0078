using System;

using R5T.T0032; /// <see cref="R5T.T0032.Documentation"/>
using R5T.D0078.T0032;


namespace System
{
    public static class FileExtensionsExtensions
    {
        public static string Sln(this IFileExtension _)
        {
            return FileExtensions.Sln;
        }

        public static string Solution(this IFileExtension _)
        {
            return _.Sln();
        }
    }
}
