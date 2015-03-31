using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageNamespace
{
    [Serializable]
    public class Message
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public string Result { get; set; }
        public ActionType Action { get; set; }
    }

    [Serializable]
    public enum ActionType
    {
        SearchByWord, SearchByLetter, Add, Edit, Remove
    }

    
}
