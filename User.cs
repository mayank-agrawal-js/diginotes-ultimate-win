using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;

namespace DNUltimate.DBClasses
{
    [FirestoreData]
    public class UserLoginData
    {
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Pass { get; set; }

        public UserLoginData(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }

        public UserLoginData()
        {
        }
    }
}
