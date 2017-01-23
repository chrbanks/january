using System.Collections.Generic;
using January.Models;

namespace January.Data
{
    public interface ITopicRepository
    {
        IEnumerable<Topic> GetAll();
        Topic Get(int id);
        void Add(Topic entity);

        void Update(Topic entity);

        void Delete(Topic entity);
    }
}