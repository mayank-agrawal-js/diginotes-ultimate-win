using Google.Cloud.Firestore;
namespace DNUltimate.DBClasses
{
    public static class DBConstants
    {
        public static readonly string keyPath = AppDomain.CurrentDomain.BaseDirectory + "dbKey.json";
        public static readonly string NOTES_COLLECTION = "UserNoteData";
        public static readonly string USER_COLLECTION = "UserLoginData";
        public static readonly string USER_RATING = "UserRatingData";
        public static FirestoreDb db { get; set; }
        
    }
}