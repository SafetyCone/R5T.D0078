using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.D0078;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static Task EnsureHasAllDependencyProjectReferences(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            IEnumerable<string> projectReferenceFilePaths,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            return visualStudioSolutionFileOperator.EnsureHasAllDependencyProjectReferences(
                solutionFilePath,
                projectReferenceFilePaths,
                solutionFilePath => visualStudioSolutionFileOperator.ListProjectReferencePaths(
                    solutionFilePath,
                    stringlyTypedPathOperator));
        }
    }
}