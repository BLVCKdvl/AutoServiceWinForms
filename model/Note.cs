using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServicewinForms.model
{
    internal class Note
    {
        public string name;
        public string autoMark;
        public string date;
        public WorkCollection workCollection;

        public Note() { }

        public Note(string name, string autoMark, string date, WorkCollection workCollection) 
        { 
            this.name = name;
            this.autoMark = autoMark;
            this.date = date;
            this.workCollection = workCollection;
        }

        public override string ToString()
        {
            return $"name : {name}\nauto mark : {autoMark}\ndate of acception : {date}" +
                $"\nwork types {workCollection.ToString()}";
        }
        
    }
}
