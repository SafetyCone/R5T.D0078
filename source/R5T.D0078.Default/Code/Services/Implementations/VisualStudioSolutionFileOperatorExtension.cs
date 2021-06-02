using System;
using System.Threading.Tasks;

using R5T.Lombardy;


namespace R5T.D0078
{
    public class VisualStudioSolutionFileOperatorExtension : IVisualStudioSolutionFileOperatorExtension
    {
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }
        private IVisualStudioSolutionFileOperator VisualStudioSolutionFileOperator { get; }


        public VisualStudioSolutionFileOperatorExtension(
            IStringlyTypedPathOperator stringlyTypedPathOperator,
            IVisualStudioSolutionFileOperator visualStudioSolutionFileOperator)
        {
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
            this.VisualStudioSolutionFileOperator = visualStudioSolutionFileOperator;
        }

        public Task Create(string solutionFilePath)
        {
            var solutionName = this.StringlyTypedPathOperator.GetFileNameWithoutExtension(solutionFilePath);

            var solutionDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPathForFilePath(solutionFilePath);

            return this.VisualStudioSolutionFileOperator.Create(solutionName, solutionDirectoryPath);
        }
    }
}
