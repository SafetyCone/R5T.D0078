using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.D0078.D001;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static async Task<string[]> ListProjectReferencePaths(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            var solutionDirectoryPath = stringlyTypedPathOperator.GetDirectoryPathForFilePath(solutionFilePath);

            var projectReferenceRelativePaths = await visualStudioSolutionFileOperator.Core.ListProjectReferenceRelativePaths(solutionFilePath);

            var output = projectReferenceRelativePaths
                .Select(xRelativeFilePath => stringlyTypedPathOperator.Combine(solutionDirectoryPath, xRelativeFilePath))
                .ToArray();

            return output;
        }

        public static async Task<bool> HasProjectReference(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            string projectReferenceFilePath,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            var projectReferencePaths = await visualStudioSolutionFileOperator.ListProjectReferencePaths(
                solutionFilePath,
                stringlyTypedPathOperator);

            var output = projectReferencePaths.Contains(projectReferenceFilePath);
            return output;
        }

        public static async Task<bool> RemoveProjectReferenceOkIfNotExists(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            string projectReferenceFilePath,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            var hasProjectReference = await visualStudioSolutionFileOperator.HasProjectReference(
                solutionFilePath,
                projectReferenceFilePath,
                stringlyTypedPathOperator);

            if (hasProjectReference)
            {
                await visualStudioSolutionFileOperator.Core.RemoveProjectReferenceIdempotent(solutionFilePath, projectReferenceFilePath);
            }

            return hasProjectReference;
        }
    }
}