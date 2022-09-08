using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace DNUltimate.DBClasses 
{


    [FirestoreData]
    public class Note
    {
        [FirestoreProperty]
        public string Note_ { get; set; }
        [FirestoreProperty]
        public string Time { get; set; }
        [FirestoreProperty]
        public int Priority { get; set; } // Can be only 0,1,2



        public Note(string note, string time, int priority)
        {
            Note_ = note;
            Time = time;
            Priority = priority;
        }
        
        public Note()
        {

        }

        public override string ToString()
        {
            return $"_NOTE: {Note_}, _TIME: {Time}, _PRIORITY: {Priority}";
        }
    }
}