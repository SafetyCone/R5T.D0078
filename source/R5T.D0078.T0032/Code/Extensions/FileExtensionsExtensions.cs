using System;

using R5T.T0032; /// <see cref="R5T.T0032.Documentation"/>


namespace System
{
    public static class FileExtensionsExtensions
    {
#pragma warning disable IDE0060 // Remove unused parameter

        public static string Sln(this IFileExtension fileExtensions)
        {
            return "sln";
        }

        public static string Solution(this IFileExtension fileExtensions)
        {
            return fileExtensions.Sln();
        }

#pragma warning restore IDE0060 // Remove unused parameter
    }
}
