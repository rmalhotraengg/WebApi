﻿namespace Microservice.Model.Domain
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; } 

    }
}
