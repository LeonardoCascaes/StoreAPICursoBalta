using FluentValidator;
using System;

namespace Store.Shared.Entities
{
    public abstract class Entity : Notifiable
    {
        public Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
