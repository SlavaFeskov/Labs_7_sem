using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using AutoMapper.Execution;
using Bank_System.Utils;
using Bank_System.Utils.Attributes;
using Newtonsoft.Json.Serialization;

namespace Bank_System.Db
{
    public abstract class BaseDbManager<T>
    {
        protected DbManager dbManager = DbManager.GetInstanse();

        public virtual List<T> GetEntities(string tableName)
        {
            var cleanName = "Bank_System.MapProfiles." + typeof(T).Name.Replace("Model", String.Empty) + "MapProfile";
            var profileType = Assembly.GetExecutingAssembly().GetType(cleanName);
            var entities = new List<T>();
            if (dbManager.Status)
            {
                var entitiesFromDb = dbManager.SendQuery($"select * from {tableName}");
                foreach (var entity in entitiesFromDb)
                {
                    Mapper.Initialize(cnf => cnf.AddProfile(profileType));
                    var newEntity = Mapper.Map<object[], T>(entity);
                    entities.Add(newEntity);
                }
            }
            else
            {
                return null;
            }

            return entities;
        }

        protected List<string> GetAllColumnNamesFormType()
        {            
            return GetMembersInfosForMembersWithUpdatableAttribute()
                .Select(m => m.Name.MakeDataBaseConventionColumnName()).ToList();
        }

        private List<MemberInfo> GetMembersInfosForMembersWithUpdatableAttribute()
        {
            return typeof(T).GetMembers()
                .Where(m => m.MemberType == MemberTypes.Property && m.GetCustomAttributesData().Any(a => a.AttributeType == typeof(UpdatableAttribute)))
                .ToList();
        }

        protected string ComposeUpdateStringStatement(T entity)
        {
            var membersInfo = GetMembersInfosForMembersWithUpdatableAttribute();
            var queryString = string.Join(", ", membersInfo.Select(m =>
            {
                var columnName = m.Name.MakeDataBaseConventionColumnName();
                var value = new ReflectionValueProvider(m).GetValue(entity);
                if (m.GetMemberType() == typeof(DateTime))
                {
                    value = DateTime.Parse(value.ToString()).ToString("yyyy-MM-dd");
                }

                if (m.GetMemberType() == typeof(bool))
                {
                    value = value.ToString().MakeBoolean();
                }
                return $"{columnName}='{value}'";
            }));
            return queryString;
        }

        protected List<string> GetValuesForDataBase(T entity)
        {
            var membersInfo = GetMembersInfosForMembersWithUpdatableAttribute();
            return membersInfo.Select(m =>
            {
                var value = new ReflectionValueProvider(m).GetValue(entity);
                if (value == null)
                {
                    return "";
                }
                if (m.GetMemberType() == typeof(DateTime))
                {
                    value = DateTime.Parse(value.ToString()).ToString("yyyy-MM-dd");
                }

                if (m.GetMemberType() == typeof(bool))
                {
                    value = value.ToString().MakeBoolean();
                }

                return value.ToString();
            }).ToList();
        }

        protected Tuple<string, string> ComposeAddStringStatement(T entity)
        {            
            var columnsInBrackets = $"({string.Join(", ", GetAllColumnNamesFormType())})";
            var valuesInBrackets = $"({string.Join(", ", GetValuesForDataBase(entity).Select(v => $"'{v}'"))})";
            return new Tuple<string, string>(columnsInBrackets, valuesInBrackets);
        }

        public abstract void UpdateEntity(T entity);

        public abstract void AddEntity(T entity);

        public virtual T GetLastRowAdded(string tableName)
        {
            var cleanName = "Bank_System.MapProfiles." + typeof(T).Name.Replace("Model", String.Empty) + "MapProfile";
            var profileType = Assembly.GetExecutingAssembly().GetType(cleanName);
            var entity = dbManager.GetLastRowAdded(tableName);
            Mapper.Initialize(cnf => cnf.AddProfile(profileType));
            return Mapper.Map<object[], T>(entity);
        }
    }
}
