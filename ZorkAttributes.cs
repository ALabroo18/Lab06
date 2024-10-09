using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Zork
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandClassAttribute : Attribute
    {
        /*Type[] types = Assembly.GetExecutingAssembly().GetTypes();
        foreach(Type type in types)
        {
            CommandClassAttribute attribute = type.GetCustomAttribute<CommandClassAttribute>();
            if(attribute != null)
            {

            }
        }*/
}

    [AttributeUsage(AttributeTargets.Method)]
    public class CommandAttribute: Attribute
    {
        public string CommandName { get; }

        public IEnumerable<string> Verbs { get; }

        public CommandAttribute(string commandName, string verb):this(commandName, new string[] { verb })
        {

        }

        public CommandAttribute(string commandName, string[] verbs)
        {
            CommandName = commandName;
            Verbs = verbs;
        }   
    }
}
