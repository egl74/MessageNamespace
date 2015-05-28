using System;
using System.Collections.Generic;

namespace MessageNamespace
{
    [Serializable]
    public class Message
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Result { get; set; }
        public ActionType Action { get; set; }
        public Dictionary<string, string> Dictionary { get; set; }
    }

    [Serializable]
    public enum ActionType
    {
        SearchByWord, SearchByLetter, Add, Edit, Remove, GetAllDictionary
    }
}
