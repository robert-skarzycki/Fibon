using System.Threading.Tasks;

namespace Fibon.Messages.Commands
{
    public interface ICommand
    {
         
    }

    public interface ICommandHandler<in T> where T:ICommand
    {
        Task HandleAsync(T command);
    }

    public class CalculateValueCommand : ICommand {
        protected CalculateValueCommand()
        {            
        }

        public CalculateValueCommand(int number){
            Number = number;
        }

        public int Number { get; }
    }
}