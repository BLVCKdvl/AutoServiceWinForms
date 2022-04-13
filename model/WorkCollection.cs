using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServicewinForms.model
{
    public class WorkCollection
    {
        private List<WorkType> workCollection;

        public WorkCollection() { }

        public WorkCollection(List<WorkType> workCollection)
        {
            this.workCollection = workCollection;
        }

        public List<WorkType> GetCollection()
        {
            return workCollection;
        }

        public void AddWorkType(WorkType workType)
        {
            workCollection.Add(workType);
        }

        public void RemoveWorkType(WorkType workType)
        {
            workCollection.Remove(workType);
        }

        public WorkType getWorkTypeByIndex(int index)
        {
            return workCollection[index];
        }

        public override string ToString()
        {
            StringBuilder collectionInfo = new StringBuilder("\n");
            
            foreach (var item in workCollection)
            {
                collectionInfo.Append(item.ToString()).Append("\n");
            }

            return collectionInfo + "";
        }
    }
}
