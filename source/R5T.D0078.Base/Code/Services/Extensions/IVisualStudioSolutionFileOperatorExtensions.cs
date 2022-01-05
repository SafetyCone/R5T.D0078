using System;
using System.Threading.Tasks;

using R5T.Magyar;

using R5T.D0078;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static Task AddProjectReference(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify, string projectReferenceFilePathToAdd)
        {
            return visualStudioSolutionFileOperator.AddProjectReferences(
                solutionFilePathToModify,
                EnumerableHelper.From(projectReferenceFilePathToAdd));
        }

        public static Task AddProjectReference(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify, string projectReferenceFilePathToAdd, string solutionFolder)
        {
            return visualStudioSolutionFileOperator.AddProjectReferences(
                solutionFilePathToModify,
                EnumerableHelper.From(projectReferenceFilePathToAdd),
                solutionFolder);
        }

        public static async Task AddProjectReferenceOkIfAlreadyAdded(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify, string projectReferenceFilePathToAdd)
        {
            // TODO, assumes that visual studio solution file operator can handle this. Should test for existence, then call.
            await visualStudioSolutionFileOperator.AddProjectReference(
                    solutionFilePathToModify,
                    projectReferenceFilePathToAdd);
        }

        public static async Task AddProjectReferenceOkIfAlreadyAdded(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify, string projectReferenceFilePathToAdd, string solutionFolder)
        {
            // TODO, assumes that visual studio solution file operator can handle this. Should test for existence, then call.
            await visualStudioSolutionFileOperator.AddProjectReference(
                    solutionFilePathToModify,
                    projectReferenceFilePathToAdd,
                    solutionFolder);
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
