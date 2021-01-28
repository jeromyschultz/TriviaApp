using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia.Models
{
    [BsonIgnoreExtraElements]
    public class AnswerModel
    {
        [BsonElement("text")]
        public string Text { get; set; }
        
        [BsonElement("correct")]
        public bool IsCorrect { get; set; }

        [BsonElement("choice")]
        public string Choice { get; set; }
    }
}
