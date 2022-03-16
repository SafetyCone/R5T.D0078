using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0078
{
    [ServiceDefinitionMarker]
    public interface IVisualStudioSolutionFileOperator : IServiceDefinition
    {
        Task AddProjectReferences(string solutionFilePathToModify, IEnumerable<string> projectReferenceFilePathsToAdd);

        Task AddProjectReferences(string solutionFilePathToModify, IEnumerable<string> projectReferenceFilePathsToAdd, string solutionFolder);

        //Task AddSolutionFolder(string solutionFilePath, string solutionFolder);

        /// <summary>
        /// Specifying the name and directory path matches the "dotnet new sln" command, and thus is the default.
        /// Conversely, there are operations involved in combining a solution directory and solution name to get a solution file path. (ex: What is the file extension?)
        /// </summary>
        Task Create(string solutionName, string solutionDirectoryPath);

        Task RemoveProjectReferenceIdempotent(string solutionFilePathToModify, string projectReferenceFilePathToRemove);

        Task<string[]> ListProjectReferenceRelativePaths(string solutionFilePath);
    }
}
