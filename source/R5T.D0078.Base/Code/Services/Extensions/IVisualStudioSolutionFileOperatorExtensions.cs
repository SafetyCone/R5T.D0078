using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.D0078;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static Task AddProjectReferences(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify,
            params string[] projectReferenceFilePathsToAdd)
        {
            return visualStudioSolutionFileOperator.AddProjectReferences(
                solutionFilePathToModify,
                projectReferenceFilePathsToAdd.AsEnumerable());
        }

        public static async Task AddProjectReferences(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify,
            IEnumerable<string> projectReferenceFilePathsToAdd)
        {
            foreach (var projectReferenceFilePath in projectReferenceFilePathsToAdd)
            {
                await visualStudioSolutionFileOperator.AddProjectReference(
                    solutionFilePathToModify,
                    projectReferenceFilePath);
            }
        }

        /// <summary>
        /// Selects <see cref="IVisualStudioSolutionFileOperator.RemoveProjectReferenceIdempotent(string, string)"/> as the default.
        /// </summary>
        public static Task RemoveProjectReference(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify,
            string projectReferenceFilePathToRemove)
        {
            return visualStudioSolutionFileOperator.RemoveProjectReferenceIdempotent(
                solutionFilePathToModify,
                projectReferenceFilePathToRemove);
        }
    }
}
