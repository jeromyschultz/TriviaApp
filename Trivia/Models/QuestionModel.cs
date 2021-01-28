using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trivia.Models
{
    [BsonIgnoreExtraElements]
    public class QuestionModel
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("question")]
        public string Question { get; set; }
        
        [BsonElement("question_num")]
        public int QuestionNumber { get; set; }

        [BsonElement("answers")]
        public AnswerModel[] Answers { get; set; }

    }
}
