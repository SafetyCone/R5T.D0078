using System;
using System.Threading.Tasks;


namespace R5T.D0078
{
    public interface IVisualStudioSolutionFileOperatorExtension
    {
        /// <summary>
        /// A solution name and directory path must be extracted from the solution file path for use in the "dotnet new sln" command, and thus is the default.
        /// This service will perform the translative work from a solution file path to the required solution name and directory path.
        /// </summary>
        Task Create(string solutionFilePath);
    }
}
