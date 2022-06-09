using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.D0078;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static async Task<string[]> ListProjectReferencePaths(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            Func<string, string> getDirectoryPathForFilePath,
            Func<string, string, string> combineDirectoryPathAndRelativeFilePath)
        {
            var solutionDirectoryPath = getDirectoryPathForFilePath(solutionFilePath);

            var projectReferenceRelativePaths = await visualStudioSolutionFileOperator.ListProjectReferenceRelativePaths(solutionFilePath);

            var output = projectReferenceRelativePaths
                .Select(xRelativeFilePath => combineDirectoryPathAndRelativeFilePath(solutionDirectoryPath, xRelativeFilePath))
                .ToArray();

            return output;
        }
    }
}