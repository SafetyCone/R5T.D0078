using System;
using System.Threading.Tasks;


namespace R5T.D0078
{
    public interface IVisualStudioSolutionFileOperator
    {
        Task AddProjectReference(string solutionFilePathToModify, string projectReferenceFilePathToAdd);

        Task AddProjectReference(string solutionFilePathToModify, string projectReferenceFilePathToAdd, string solutionFolder);

        /// <summary>
        /// Specifying the name and directory path matches the "dotnet new sln" command, and thus is the default.
        /// Conversely, there are operations involved in combining a solution directory and solution name to get a solution file path. (ex: What is the file extension?)
        /// </summary>
        Task Create(string solutionName, string solutionDirectoryPath);

        Task RemoveProjectReferenceIdempotent(string solutionFilePathToModify, string projectReferenceFilePathToRemove);

        Task<string[]> ListProjectReferenceRelativePaths(string solutionFilePath);
    }
}
