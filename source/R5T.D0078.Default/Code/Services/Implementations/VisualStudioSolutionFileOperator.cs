using System;
using System.Threading.Tasks;

using R5T.D0077;
using R5T.D0077.New;


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
    }
}
