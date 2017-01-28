﻿using System;
using System.Linq;
using System.Reflection;
using VirtualTaluva.Protocol.DataTypes.Attributes;
using VirtualTaluva.Protocol.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace VirtualTaluva.Protocol
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractCommand
    {
        /// <summary>
        /// Always contains '{CommandName}' to distinguish the command from others."
        /// </summary>
        [JsonProperty(Order = -100)]
        [ExampleValue("{CommandName}")]
        public string CommandName => GetType().Name;

        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public abstract TaluvaCommandEnum CommandType { get; }

        /// <summary>
        /// Browsing all Types inheriting "AbstractBluffinCommand", it finds the type named exactly like the "CommandName" attribute in the JSON.
        /// </summary>
        public static AbstractCommand DeserializeCommand(string data)
        {
            var cmd = JsonConvert.DeserializeObject<JObject>(data);
            Type commType = Assembly.GetExecutingAssembly().GetTypes().Single(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(AbstractCommand)) && t.Name == cmd["CommandName"].Value<string>());
            MethodInfo method = typeof(JsonConvert).GetMethods().First(m => m.Name == "DeserializeObject" && m.IsGenericMethod).MakeGenericMethod(commType);
            return (AbstractCommand)method.Invoke(null, new object[] { data });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Encode()
        {
            return JsonConvert.SerializeObject(this, new StringEnumConverter());
        }
    }
}
