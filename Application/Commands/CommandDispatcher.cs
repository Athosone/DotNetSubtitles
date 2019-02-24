//using System;
//using System.Runtime.Serialization;

//namespace Application.Commands
//{
//    public class CommandDispatcher : ICommandDispatcher
//    {
//        private readonly IDependencyResolver _resolver;

//        public CommandDispatcher(IDependencyResolver resolver)
//        {
//            _resolver = resolver;
//        }

//        public void Execute<TCommand>(TCommand command) where TCommand : ICommand
//        {
//            if (command == null)
//            {
//                throw new ArgumentNullException("command");
//            }

//            var handler = _resolver.Resolve<TCommandHandler>();

//            if (handler == null)
//            {
//                throw new CommandHandlerNotFoundException(typeof(TCommand));
//            }

//            handler.Execute(command);
//        }
//    }

//    [Serializable]
//    internal class CommandHandlerNotFoundException : Exception
//    {
//        private Type type;

//        public CommandHandlerNotFoundException()
//        {
//        }

//        public CommandHandlerNotFoundException(Type type)
//        {
//            this.type = type;
//        }

//        public CommandHandlerNotFoundException(string message) : base(message)
//        {
//        }

//        public CommandHandlerNotFoundException(string message, Exception innerException) : base(message, innerException)
//        {
//        }

//        protected CommandHandlerNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
//        {
//        }
//    }
//}
