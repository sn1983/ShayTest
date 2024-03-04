using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShayTest
{
    public class T4
    {
        bool SetAllFlag = false;
       
        public override string ToString()
        {

            StringBuilder stringBuilder = new StringBuilder();
            if (keyMap.Count > 0)
            {
                //foreach (var item in keyMap)
                //{
                //    stringBuilder.Append($"[{item}]:{item.Value}\n");
                //}

                for (int i = 0; i < keyMap.Count; i++)
                {
                    if (SetAllFlag)
                        stringBuilder.Append($"[{keyMap[i + 1].Key}]: {commonValue}\n");
                    else
                         
                    stringBuilder.Append($"[{keyMap[i+1].Key}]:{keyMap[i+1].Value}\n");
                }
                return stringBuilder.ToString();
            }
            SetAllFlag = false;
            return "";
        }

        private Dictionary<int, Node> keyMap;
        
        private int commonValue; // Store the common value set by SetAll

        public T4()
        {
            //adding dummy data to dictionary

            keyMap=new Dictionary<int, Node> ();
            for (int i = 0; i < 30; i++)
            {
                Random rand = new Random();
                Node node = new Node (i + 1, rand.Next());
                 keyMap.Add(i+1, node);
               // keyMap[i].Value = rand.Next();
            }


        }

        public int Get(int key=-2)
        {

            if (SetAllFlag)
            {

                return commonValue;
            }
            if (keyMap.ContainsKey(key))
            {
                return keyMap[key].Value;
            }
            return int.MaxValue;
        }

        public void Set(int key, int value)
        {
            if (keyMap.ContainsKey(key))
            {
                keyMap[key].Value = value;
            }
            
        }

        public void SetAll(int value)
        {
            commonValue = value; // Update the common value
            SetAllFlag =true;
        }

       
    }
}
