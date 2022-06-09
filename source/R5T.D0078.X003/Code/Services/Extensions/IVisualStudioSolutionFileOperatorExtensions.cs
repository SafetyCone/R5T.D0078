using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.D0078;

using Instances = R5T.D0078.X003.Instances;


namespace System
{
    public static class IVisualStudioSolutionFileOperatorExtensions
    {
        public static Task AddDependencyProjectReference(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify,
            string dependencyProjectReferenceFilePathToAdd)
        {
            return visualStudioSolutionFileOperator.AddProjectReference(
                solutionFilePathToModify,
                dependencyProjectReferenceFilePathToAdd,
                Instances.SolutionFolderName.Dependencies());
        }

        public static Task AddDependencyProjectReferenceOkIfAlreadyAdded(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify,
            string dependencyProjectReferenceFilePathToAdd)
        {
            return visualStudioSolutionFileOperator.AddProjectReferenceOkIfAlreadyAdded(
                solutionFilePathToModify,
                dependencyProjectReferenceFilePathToAdd,
                Instances.SolutionFolderName.Dependencies());
        }

        public static Task AddDependencyProjectReferences(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePathToModify,
            IEnumerable<string> dependencyProjectReferenceFilePathsToAdd)
        {
            return visualStudioSolutionFileOperator.AddProjectReferences(
                solutionFilePathToModify,
                dependencyProjectReferenceFilePathsToAdd,
                Instances.SolutionFolderName.Dependencies());
        }

        public static async Task AddDependencyProjectReferences(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            IEnumerable<string> solutionFilePathsToModify,
            IEnumerable<string> dependencyProjectReferenceFilePathsToAdd)
        {
            foreach (var solutionFilePathToModify in solutionFilePathsToModify)
            {
                await visualStudioSolutionFileOperator.AddProjectReferences(
                    solutionFilePathToModify,
                    dependencyProjectReferenceFilePathsToAdd,
                    Instances.SolutionFolderName.Dependencies());
            }
        }

        public static async Task EnsureHasAllDependencyProjectReferences(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            IEnumerable<string> projectReferenceFilePaths,
            Func<IVisualStudioSolutionFileOperator, string, Task<string[]>> listProjectReferenceFilePaths)
        {
            var allCurrentProjectReferenceFilePaths = await listProjectReferenceFilePaths(
                visualStudioSolutionFileOperator,
                solutionFilePath);

            var currentlyMissingProjectReferenceFilePaths = projectReferenceFilePaths.Except(allCurrentProjectReferenceFilePaths);

            await visualStudioSolutionFileOperator.AddDependencyProjectReferences(
                solutionFilePath,
                currentlyMissingProjectReferenceFilePaths);
        }

        public static async Task EnsureHasAllDependencyProjectReferences(this IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator,
            string solutionFilePath,
            IEnumerable<string> projectReferenceFilePaths,
            Func<string, Task<string[]>> listProjectReferenceFilePaths)
        {
            var allCurrentProjectReferenceFilePaths = await listProjectReferenceFilePaths(solutionFilePath);

            var currentlyMissingProjectReferenceFilePaths = projectReferenceFilePaths.Except(allCurrentProjectReferenceFilePaths);

            await visualStudioSolutionFileOperator.AddDependencyProjectReferences(
                solutionFilePath,
                currentlyMissingProjectReferenceFilePaths);
        }
    }
}