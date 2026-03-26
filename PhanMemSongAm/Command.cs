using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PhanMemSongAm.ParameterList;

namespace PhanMemSongAm
{
    // TODO: 2 dau / cua Phuc
    // $iam: "Phuc" $message: "Viet tinh tien di" $with: "Dat" $topic: "Viet tinh tien di"
    // $iam: "Phuc" $message: "Viet ve nha di Viet" $with: "Dat" $topic: "Viet ve nha di Viet"
    public class Command
    {
        private const char PARAMETER_REF_INDICATOR = '$';
        private const char PARAMETER_ASSIGN_OPERATOR = ':';

        private const string IAM_KEY = "iam";
        private const string MESSAGE_KEY = "message";
        private const string WITH_KEY = "with";
        private const string TOPIC_KEY = "topic";

        private string _command = "";

        private string _iam = "";
        protected string _message  = "";
        private string _with = "";
        private string _topic = "";
        
        private ParameterDict _parameterDict = new ParameterDict();
        private ParameterList _parameterList = new ParameterList();

        public Command(string input)
        {
            this._command = input;

            this._parameterDict = this.ToParameterDict(this._command);
            this._parameterList = this.ToParameterList(this._parameterDict);

            this._iam = this.GetIam();
            this._message = this.GetMessage();
            this._with = this.GetWith();
            this._topic = this.GetTopic();
        }

        static bool Detect(string message)
        {
            bool isCommand = false;

            var indicators = new List<string>();

            // $ isRefInd
            // : isAssignOperator
            // $: $: isPairs
            // $from: $from: $to: $to:

            return isCommand;
        }

        public void PrintParameters()
        {
            Console.WriteLine();
            Console.Write("PrintParameters: ");
            Console.Write($"iam: {this._iam}, ");
            Console.Write($"message: {this._message}, ");
            Console.Write($"with: {this._with}, ");
            Console.Write($"topic: {this._topic}, ");
        }

        public void PrintNames()
        {
            Console.WriteLine();
            Console.Write("PrintNames: ");
        }

        private ParameterDict ToParameterDict(string command)
        {
            var parameterDict = new ParameterDict();

            if (command != null && command.Contains(PARAMETER_REF_INDICATOR))
            {
                var gexParameters = command.Split(PARAMETER_REF_INDICATOR);

                for (int i = 0; i < gexParameters.Length; i++)
                {
                    var currentGexParameter = gexParameters[i];
                    if (currentGexParameter != null && currentGexParameter.Contains(PARAMETER_ASSIGN_OPERATOR))
                    {
                        var paramPair = currentGexParameter.Split(PARAMETER_ASSIGN_OPERATOR);
                        var paramPairKey = paramPair[0].ToLower();
                        var paramPairValue = paramPair[1];

                        var isFill = true;
                        var isParamaterRef = false;

                        if (string.IsNullOrWhiteSpace(paramPairKey) && string.IsNullOrWhiteSpace(paramPairValue))
                        {
                            isFill = false;
                        }

                        if (string.IsNullOrEmpty(paramPairKey) && string.IsNullOrEmpty(paramPairValue))
                        {
                            isFill = false;
                        }

                        isParamaterRef = paramPair[0].Contains(IAM_KEY)
                            || paramPair[0].Contains(MESSAGE_KEY)
                            || paramPair[0].Contains(WITH_KEY)
                            || paramPair[0].Contains(TOPIC_KEY);

                        if (isFill && isParamaterRef)
                        {
                            var parameter = new Parameter(paramPair[0], paramPair[1]);

                            parameterDict.Add(parameter.Key, parameter);
                        }
                        
                    }
                }
            }

            return parameterDict;
        }

        private ParameterList ToParameterList(ParameterDict parameterDict)
        {
            var parameterList = new ParameterList();

            foreach (var parameter in parameterDict.Values.ToList())
            {
                parameterList.Add(parameter);
            }

            return parameterList;
        }

        private string UnDoubleQuote(string input)
        {
            return "";
        }

        private string GetIam()
        {
            string iam = "";

            if (this._parameterDict.ContainsKey(IAM_KEY) && this._parameterDict[IAM_KEY] != null)
            {
                iam = this._parameterDict[IAM_KEY].Value;
            }

            return iam;
        }

        private string GetMessage()
        {
            string message = "";

            if (this._parameterDict.ContainsKey(MESSAGE_KEY) && this._parameterDict[MESSAGE_KEY] != null)
            {
                message = this._parameterDict[MESSAGE_KEY].Value;
            }

            return message;
        }

        private string GetWith()
        {
            string with = "";

            if (this._parameterDict.ContainsKey(WITH_KEY) && this._parameterDict[WITH_KEY] != null)
            {
                with = this._parameterDict[WITH_KEY].Value;
            }

            return with;
        }

        private string GetTopic()
        {
            string topic = "";

            if (this._parameterDict.ContainsKey(TOPIC_KEY) && this._parameterDict[TOPIC_KEY] != null)
            {
                topic = this._parameterDict[TOPIC_KEY].Value;

            } else if (this._parameterDict.ContainsKey(MESSAGE_KEY) && this._parameterDict[MESSAGE_KEY] != null)
            {
                topic = this._parameterDict[MESSAGE_KEY].Value;

            }

            return topic;
        }
    }
}
