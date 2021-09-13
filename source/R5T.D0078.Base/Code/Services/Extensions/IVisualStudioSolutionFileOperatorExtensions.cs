using System;
using System.Threading.Tasks;

using R5T.D0078;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
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
