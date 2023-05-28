using System;

namespace Develop03
{
    public class Reference
    {
        public (string, string) GetReference(string scripture)
        {
            int separatorIndex = scripture.IndexOf(' ');
            string reference = scripture.Substring(0, separatorIndex);
            string scriptureText = scripture.Substring(separatorIndex + 1);
            return (reference, scriptureText);
        }
    }
}