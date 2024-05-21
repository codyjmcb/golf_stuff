using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Repositories
{
    public interface IRepository<T>
    {
        IList<T> FindAll();

        T Find(string id);

        bool Add(T x);

        bool Update(T x);

        bool Delete(string id);
    }

    ////////////////////////////////////Scores for Golfer
    public interface IItemsForRepository<I, J> : IRepository<I>
    {
        //find scores for golfer
        IList<I> FindFor(J x);

        //add scores for golfer
        bool AddFor(I x, J y);

        //delete entry with multiple different contingent parties
        //Example Author / Book
        //Delete author from book ... leaves other authors attached
        bool DeleteFor(I x, J y);

        //Delete all entries associated
        //Use this before deleting contingent data
        //Example all tee information must be deleted before a course can be deleted
        //this is because of Foreign Key relationships
        bool DeleteAllFor(J x);
    }


    //This class takes a JSON string and returns back a list of objects of type T
    public static partial class JsonExtensions
    {
        public static IEnumerable<T> FromDelimitedJson<T>(TextReader reader, JsonSerializerSettings settings = null)
        {
            using (var jsonReader = new JsonTextReader(reader) { CloseInput = false, SupportMultipleContent = true })
            {
                var serializer = JsonSerializer.CreateDefault(settings);

                while (jsonReader.Read())
                {
                    if (jsonReader.TokenType == JsonToken.Comment)
                        continue;
                    yield return serializer.Deserialize<T>(jsonReader);
                }
            }
        }
    }
}
