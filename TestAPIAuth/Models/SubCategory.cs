﻿namespace TestAPIAuth.Models
{
    public class SubCategory
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public bool Deleted { get; set; }

    }
}
