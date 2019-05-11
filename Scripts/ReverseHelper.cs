using System.Collections.Generic;

namespace RubeGoldbergArrayReverser
{
    class ReverseHelper
    {
        public static object[] Reverse(object[] array)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            for (int i = 0; i < array.Length; i++)
                dictionary.Add(i.ToString(), array[i]);

            object[] reversed = new object[dictionary.Count];
            for (int i = 0; i < reversed.Length / 2; i++)
            {
                object obj = dictionary[i.ToString()];
                dictionary[i.ToString()] = dictionary[(reversed.Length - i - 1).ToString()];
                dictionary[(reversed.Length - i - 1).ToString()] = obj;
            }

            for (int i = 0; i < reversed.Length; i++)
                reversed[i] = dictionary[i.ToString()];

            return reversed;
        }
    }
}
