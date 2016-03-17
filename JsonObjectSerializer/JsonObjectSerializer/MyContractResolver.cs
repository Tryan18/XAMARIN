using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JsonObjectSerializer
{
	public class MyContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
	{
		protected override IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, MemberSerialization memberSerialization)
		{
			var props = type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

			List<Newtonsoft.Json.Serialization.JsonProperty> jsonProps = new List<Newtonsoft.Json.Serialization.JsonProperty>();

			foreach( var prop in props )
			{
				jsonProps.Add( base.CreateProperty(prop, memberSerialization));
			}

			var fields = type.GetFields (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

			foreach( var field in fields)
			{
				//if(field.FieldType != null && field.FieldType.BaseType != null && field.FieldType.BaseType.FullName != null && field.FieldType.BaseType.FullName != "System.MulticastDelegate")
				jsonProps.Add ( base.CreateProperty( field, memberSerialization ) );
			}

			jsonProps.ForEach(p => { p.Writable = true; p.Readable = true; });
			return jsonProps;
		}
	}
}

