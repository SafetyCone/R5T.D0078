using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.D0077;
using R5T.D0077.New;
using R5T.D0077.X001; /// <see cref="R5T.D0077.X001.Documentation"/>


namespace R5T.D0078
{
    public class VisualStudioSolutionFileOperator : IVisualStudioSolutionFileOperator
    {
        private IDotnetOperator DotnetOperator { get; }


        public VisualStudioSolutionFileOperator(
            IDotnetOperator dotnetOperator)
        {
            this.DotnetOperator = dotnetOperator;
        }

        public Task Create(string solutionName, string solutionDirectoryPath)
        {
            return this.DotnetOperator.NewSolution(solutionName, solutionDirectoryPath);
        }

        public Task AddProjectReferences(string solutionFilePathToModify, IEnumerable<string> projectReferenceFilePathsToAdd)
        {
            return this.DotnetOperator.AddProjectReferencesToSolution(
                solutionFilePathToModify,
                projectReferenceFilePathsToAdd);
        }

        public Task AddProjectReferences(string solutionFilePathToModify, IEnumerable<string> projectReferenceFilePathsToAdd, string solutionFolder)
        {
            return this.DotnetOperator.AddProjectReferencesToSolution(
                solutionFilePathToModify,
                projectReferenceFilePathsToAdd,
                solutionFolder);
        }

        public Task RemoveProjectReferenceIdempotent(string solutionFilePathToModify, string projectReferenceFilePathToRemove)
        {
            return this.DotnetOperator.RemoveProjectReferenceFromSolution(solutionFilePathToModify, projectReferenceFilePathToRemove);
        }

        public Task<string[]> ListProjectReferenceRelativePaths(string solutionFilePath)
        {
            return this.DotnetOperator.ListSolutionProjectReferenceRelativePaths(solutionFilePath);   
        }

        //public async Task AddSolutionFolder(string solutionFilePath, string solutionFolder)
        //{
        //    await this.AddProjectReferences(solutionFilePath, EnumerableHelper.Empty<string>(), solutionFolder);
        //}
    }
}
