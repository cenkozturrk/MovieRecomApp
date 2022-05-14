using System;

namespace Entities
{
    public class Movie : BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Point { get; set; }
        public string Note { get; set; }

    }
}
