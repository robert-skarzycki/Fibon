using System.Threading.Tasks;

namespace Fibon.Messages.Events
{
    public interface IEvent
    {
         
    }

    public interface IEventHandler<in T> where T:IEvent
    {
        Task HandleAsync(T @event);
    }

    public class ValueCalculatedEvent : IEvent{
        protected ValueCalculatedEvent()
        {           
            
        }

        public ValueCalculatedEvent(int number, int value){
            Number = number;
            Value = value;
        }

        public int Number { get;}
        public int Value { get; }
    }
}