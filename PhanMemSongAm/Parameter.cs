using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemSongAm
{
    public class Parameter
    {
        private string _key;
        public string Key { get { return _key; } }

        private string _value;

        public string Value { get { return _value; } }

        public Parameter(string key, string value)
        {
            this._key = key;
            this._value = value;
        }
    }

    public class ParameterList : List<Parameter> 
    {
        private string _name;

        public ParameterList() { }
        public ParameterList(string name) 
        {
            this._name = name;
        }

        public int Index(string parameterName)
        {
            var index = -1;

            var findOutElement = this.Find(parameter => parameter.Key == parameterName);

            if (findOutElement != null)
            {
                for (int i =0; i< this.Count; i++)
                {
                    if (this[i].Key == parameterName)
                    {
                        index = i;
                    }
                    
                }
            }

            return index;
        }

        public class ParameterDict : Dictionary<string, Parameter> 
        {
            private string _name;

            public ParameterDict() { }
            public ParameterDict(string name) 
            {
                this._name = name;
            }
        }
    }
}
