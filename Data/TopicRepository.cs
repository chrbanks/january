using System.Collections.Generic;
using System.Linq;
using January.Models;

namespace January.Data
{
    public class TopicRepository : ITopicRepository
    {
        private DataContext context;

        public TopicRepository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Topic> GetAll()
        {
            return context.Topics.AsEnumerable();
        }

        public Topic Get(int id)
        {
            return context.Topics.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Topic entity)
        {
            context.Topics.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Topic entity)
        {
            context.Topics.Remove(entity);
            context.SaveChanges();
        }

        public void Update(Topic entity)
        {
            context.Topics.Update(entity);
            context.SaveChanges();
        }
    }
}