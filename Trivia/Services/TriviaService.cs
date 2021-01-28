using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trivia.Models;

namespace Trivia.Services
{
    public class TriviaService
    {
        private readonly IMongoCollection<QuestionModel> questions;

        public TriviaService(IConfiguration config)
        {
            MongoClient client = new MongoClient(config.GetConnectionString("TriviaDB"));
            IMongoDatabase database = client.GetDatabase("Trivia");
            questions = database.GetCollection<QuestionModel>("Questions");
        }



        public List<QuestionModel> GetTriviaQuestion()
        {
            int numberOfQuestions = 1553;
            Random random = new Random();
            int rand = random.Next(1, numberOfQuestions);
            return questions.Find(question => true).Skip(rand).Limit(1).ToList();
        }

        public List<QuestionModel> GetTriviaQuestions()
        {
            return questions.Find(question => true).ToList();
        }

        public List<QuestionModel> GetTriviaQuestion(int number)
        {
            return questions.Find(question => true).Skip(number).Limit(1).ToList();
        }

        public int GetRandomInt()
        {
            int numberOfQuestions = 1553;
            Random random = new Random();
            return random.Next(1, numberOfQuestions);
        }
    }
}
