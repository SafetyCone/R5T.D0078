using System;
using System.Threading.Tasks;

using R5T.Lombardy;

using R5T.T0032;


namespace R5T.D0078
{
    public class VisualStudioSolutionFileOperatorExtension : IVisualStudioSolutionFileOperatorExtension
    {
        private IFileNameOperator FileNameOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }
        private IVisualStudioSolutionFileOperator VisualStudioSolutionFileOperator { get; }


        public VisualStudioSolutionFileOperatorExtension(
            IFileNameOperator fileNameOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator,
            IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator)
        {
            this.FileNameOperator = fileNameOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
            this.VisualStudioSolutionFileOperator = visualStudioSolutionFileOperator;
        }

        public Task Create(string solutionFilePath)
        {
            var solutionName = this.StringlyTypedPathOperator.GetFileNameWithoutExtension(solutionFilePath);

            var solutionDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPathForFilePath(solutionFilePath);

            return this.VisualStudioSolutionFileOperator.Create(solutionName, solutionDirectoryPath);
        }

        public Task<string> GetSolutionFilePath(string solutionDirectoryPath, string solutionName)
        {
            // Assume that the solution name is a valid solution file name stem.
            var solutionFileNameStem = solutionName;

            var solutionFileName = this.FileNameOperator.GetFileName(solutionFileNameStem, FileExtension.Instance.Sln());

            var solutionFilePath = this.StringlyTypedPathOperator.GetFilePath(solutionDirectoryPath, solutionFileName);

            return Task.FromResult(solutionFilePath);
        }
    }
}
