using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.D0078;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static Task<string[]> ListProjectReferencePaths(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            return visualStudioSolutionFileOperator.ListProjectReferencePaths(
                solutionFilePath,
                stringlyTypedPathOperator.GetDirectoryPathForFilePath,
                stringlyTypedPathOperator.Combine);
        }
    }
}