using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace FreeCourse.Services.Catalog.Models
{
    public class Course
    {
        public string Id { get; set; }
        public string Name { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public string Price { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedTime { get; set; }

        public Feature Feature { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
