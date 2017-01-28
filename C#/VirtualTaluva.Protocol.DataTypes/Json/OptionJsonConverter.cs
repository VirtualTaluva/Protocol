﻿using VirtualTaluva.Protocol.DataTypes.Options;
using Newtonsoft.Json.Linq;

namespace VirtualTaluva.Protocol.DataTypes.Json
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TOption"></typeparam>
    /// <typeparam name="TEnum"></typeparam>
    public class OptionJsonConverter<TOption, TEnum> : AbstractCustomJsonConverter<TOption>
        where TOption : IOption<TEnum>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="jObject"></param>
        /// <returns></returns>
        public override TOption ObtainCustomObject(JObject jObject)
        {
            return FactoryOption<TOption, TEnum>.GenerateOption(jObject.Value<string>("OptionType"));
        }
    }
}
