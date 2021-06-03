using System;
using System.Collections.Generic;
using System.Linq;

namespace KindleAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mocking in the dataset
            var areas = new List<Tuple<int, string, int>>();
            areas.Add(Tuple.Create(1, "Continent", 0));
            areas.Add(Tuple.Create(2, "Country", 1));
            areas.Add(Tuple.Create(3, "Province", 2));
            areas.Add(Tuple.Create(4, "City1", 3));
            areas.Add(Tuple.Create(5, "Suburb1", 6));
            areas.Add(Tuple.Create(6, "City2", 3));
            areas.Add(Tuple.Create(7, "Suburb2", 6));
            areas.Add(Tuple.Create(8, "Suburb3", 6));
            areas.Add(Tuple.Create(9, "Suburb4", 4));
            areas.Add(Tuple.Create(10, "House1", 7));
            areas.Add(Tuple.Create(11, "House3", 9));
            areas.Add(Tuple.Create(12, "House4", 8));
            areas.Add(Tuple.Create(13, "House5", 8));
            areas.Add(Tuple.Create(14, "House6", 7));


            var sortedAreas = new List<Tuple<int, string, int>>();
            var listNum = 0;

            while (areas.Count > 0)
            {
                var removalList = new List<int>();

                //for loop to push tree to new list and remove from old
                for (int i = 0; i < areas.Count(); i++)
                {
                    if (areas[i].Item3 == listNum)
                    {
                        listNum = areas[i].Item1;

                        sortedAreas.Add(Tuple.Create(areas[i].Item1,
                        areas[i].Item2, areas[i].Item3));

                        removalList.Add(areas[i].Item1);

                    }
                };
                listNum++;
                if (removalList.Count > 0)
                {
                    foreach (var thing in removalList)
                    {
                        areas.RemoveAll(x => x.Item1 == thing);
                        listNum = 0;

                    }
                }

            }

            foreach (var item in sortedAreas)
            {
                Console.WriteLine(item.Item2);
            }
        }
    }
}
