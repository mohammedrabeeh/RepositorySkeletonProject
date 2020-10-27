using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Core.Models
{
    public interface IBaseEntity
    {
        public object Id { get; set; }
    }

    public interface IBaseEntity<TId> : IBaseEntity
    {
        public new TId Id { get; set; }
        public bool IsRemoved { get; set; }
    }

    public abstract class BaseEntity<TId> : IBaseEntity<TId>
    {

        public TId Id { get; set; }
        public bool IsRemoved { get; set; }
        object IBaseEntity.Id { get => this.Id; set => throw new NotImplementedException(); }
    }
}
